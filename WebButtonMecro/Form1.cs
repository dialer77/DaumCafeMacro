using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebButtonMecro
{
    public partial class Form1 : Form
    {
        private DateTime m_serverDateTime = DateTime.Now;

        private Thread m_threadUpdateServerTime = null;

        private ChromeDriverService m_driverService = null;
        private ChromeOptions m_options = null;
        private ChromeDriver m_driver = null;

        private bool m_isClosing = false;

        public Form1()
        {
            InitializeComponent();

            m_threadUpdateServerTime = new Thread(UpdateServerTime);
            m_threadUpdateServerTime.Start();
            timerUpdateServerTime.Start();

            m_driverService = ChromeDriverService.CreateDefaultService();
            m_driverService.HideCommandPromptWindow = true;
            

            
            m_options = new ChromeOptions();
            m_options.AddArgument("disable-gpu");
            m_options.AddArgument("--user-data-dir=D:\\UserData");
            
            
                
            //m_options.AddArgument("headless");
        }



        private void timerUpdateServerTime_Tick(object sender, EventArgs e)
        {
            labelServerTime.Text = m_serverDateTime.ToString("HH:mm:ss");
        }

        private void UpdateServerTime()
        {
            while (m_isClosing == false)
            {
                try
                {
                    using (var response = WebRequest.Create("http://cafe.daum.net").GetResponse())
                    {
                        m_serverDateTime = DateTime.ParseExact(response.Headers["date"],

                           "ddd, dd MMM yyyy HH:mm:ss 'GMT'",

                           CultureInfo.InvariantCulture.DateTimeFormat,

                           DateTimeStyles.AssumeUniversal);

                        if(m_serverDateTime > dateTimePickerTargetTime.Value)
                        {
                            
                        }

                        
                    }
                }
                catch (Exception ex)
                {


                }
                finally
                {
                }
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_isClosing = true;
        }

        private bool m_isWaitCancel = false;

        private async void button1_Click(object sender, EventArgs e)
        {
            buttonWaitStart.Enabled = false;
            buttonCancel.Enabled = true;

            try
            {
                m_driver = new ChromeDriver(m_driverService, m_options);

                m_driver.Navigate().GoToUrl(textBoxURL.Text);

                m_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                // iframe 전환
                var iframe = m_driver.FindElement(By.Id("down"));
                m_driver.SwitchTo().Frame(iframe);

                await Task.Delay(2000);
                // 참여하기 버튼 클릭
                var element = m_driver.FindElement(By.XPath("//*[@id='btn_apply_new']"));
                element.Click();

                m_driver.SwitchTo().Window(m_driver.WindowHandles[1]);

                while (m_isWaitCancel == false)
                {
                    if ((dateTimePickerTargetTime.Value - m_serverDateTime).TotalMilliseconds <= 1000)
                    {
                        int delayTime = int.Parse(textBoxDelayTime.Text);
                        await Task.Delay(delayTime);
                        break;
                    }
                    await Task.Delay(10);
                }

                if(m_isWaitCancel == true)
                {
                    return;
                }

                // 작성하기 버튼 클릭
                var writeButton = m_driver.FindElement(By.XPath("//*[@id='btnSaveView']"));
                writeButton.Click();
                m_driver.SwitchTo().Window(m_driver.WindowHandles[0]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                buttonWaitStart.Enabled = true;
                buttonCancel.Enabled = false;
                m_isWaitCancel = false;
            }
            


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            m_isWaitCancel = true;
        }
    }
}
