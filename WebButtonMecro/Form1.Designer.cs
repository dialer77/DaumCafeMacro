
namespace WebButtonMecro
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerUpdateServerTime = new System.Windows.Forms.Timer(this.components);
            this.labelServerTime = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTargetTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDelayTime = new System.Windows.Forms.TextBox();
            this.buttonWaitStart = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerUpdateServerTime
            // 
            this.timerUpdateServerTime.Tick += new System.EventHandler(this.timerUpdateServerTime_Tick);
            // 
            // labelServerTime
            // 
            this.labelServerTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelServerTime.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelServerTime.Location = new System.Drawing.Point(153, 64);
            this.labelServerTime.Name = "labelServerTime";
            this.labelServerTime.Size = new System.Drawing.Size(194, 64);
            this.labelServerTime.TabIndex = 0;
            this.labelServerTime.Text = "00:00:00";
            this.labelServerTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 3;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonCancel, 2, 3);
            this.tableLayoutPanelMain.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelServerTime, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dateTimePickerTargetTime, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxDelayTime, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonWaitStart, 2, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxURL, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(523, 259);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 64);
            this.label2.TabIndex = 2;
            this.label2.Text = "목표 시간 : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "서버 시간 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerTargetTime
            // 
            this.dateTimePickerTargetTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerTargetTime.CalendarFont = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePickerTargetTime.CustomFormat = "HH:mm:ss";
            this.dateTimePickerTargetTime.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePickerTargetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTargetTime.Location = new System.Drawing.Point(153, 145);
            this.dateTimePickerTargetTime.Name = "dateTimePickerTargetTime";
            this.dateTimePickerTargetTime.ShowUpDown = true;
            this.dateTimePickerTargetTime.Size = new System.Drawing.Size(194, 29);
            this.dateTimePickerTargetTime.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 67);
            this.label3.TabIndex = 4;
            this.label3.Text = "딜레이 (ms)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDelayTime
            // 
            this.textBoxDelayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDelayTime.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxDelayTime.Location = new System.Drawing.Point(153, 211);
            this.textBoxDelayTime.Name = "textBoxDelayTime";
            this.textBoxDelayTime.Size = new System.Drawing.Size(194, 29);
            this.textBoxDelayTime.TabIndex = 5;
            this.textBoxDelayTime.Text = "800";
            // 
            // buttonWaitStart
            // 
            this.buttonWaitStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWaitStart.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonWaitStart.Location = new System.Drawing.Point(353, 67);
            this.buttonWaitStart.Name = "buttonWaitStart";
            this.tableLayoutPanelMain.SetRowSpan(this.buttonWaitStart, 2);
            this.buttonWaitStart.Size = new System.Drawing.Size(167, 122);
            this.buttonWaitStart.TabIndex = 6;
            this.buttonWaitStart.Text = "시작";
            this.buttonWaitStart.UseVisualStyleBackColor = true;
            this.buttonWaitStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonCancel.Location = new System.Drawing.Point(353, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(167, 61);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "취소";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 64);
            this.label4.TabIndex = 8;
            this.label4.Text = "사이트 주소 : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.SetColumnSpan(this.textBoxURL, 2);
            this.textBoxURL.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBoxURL.Location = new System.Drawing.Point(153, 17);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(367, 29);
            this.textBoxURL.TabIndex = 9;
            this.textBoxURL.Text = "https://cafe.daum.net/IVEstarship/bYfY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 259);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerUpdateServerTime;
        private System.Windows.Forms.Label labelServerTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTargetTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDelayTime;
        private System.Windows.Forms.Button buttonWaitStart;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxURL;
    }
}

