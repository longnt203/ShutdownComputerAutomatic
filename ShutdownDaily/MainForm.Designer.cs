namespace ShutdownDaily
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.tmCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.dtpShutdownDaily = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShutdownDaily = new System.Windows.Forms.Button();
            this.dtpShutdownOne = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShutdownOne = new System.Windows.Forms.Button();
            this.btnStopToday = new System.Windows.Forms.Button();
            this.lblStopShutdown = new System.Windows.Forms.Label();
            this.lblShutdownAt = new System.Windows.Forms.Label();
            this.ntiShutdown = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hiệnChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShutdownNow = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentTime.Location = new System.Drawing.Point(139, 9);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(174, 46);
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.Text = "00:00:00";
            // 
            // tmCurrentTime
            // 
            this.tmCurrentTime.Interval = 1000;
            this.tmCurrentTime.Tick += new System.EventHandler(this.tmCurrentTime_Tick);
            // 
            // dtpShutdownDaily
            // 
            this.dtpShutdownDaily.CustomFormat = "HH:mm";
            this.dtpShutdownDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShutdownDaily.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShutdownDaily.Location = new System.Drawing.Point(227, 77);
            this.dtpShutdownDaily.Name = "dtpShutdownDaily";
            this.dtpShutdownDaily.ShowUpDown = true;
            this.dtpShutdownDaily.Size = new System.Drawing.Size(86, 30);
            this.dtpShutdownDaily.TabIndex = 1;
            this.dtpShutdownDaily.Value = new System.DateTime(2018, 7, 5, 0, 0, 0, 0);
            this.dtpShutdownDaily.ValueChanged += new System.EventHandler(this.dtpTimeShutdownDaily_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tắt máy hàng ngày lúc";
            // 
            // btnShutdownDaily
            // 
            this.btnShutdownDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdownDaily.Location = new System.Drawing.Point(337, 75);
            this.btnShutdownDaily.Name = "btnShutdownDaily";
            this.btnShutdownDaily.Size = new System.Drawing.Size(97, 34);
            this.btnShutdownDaily.TabIndex = 3;
            this.btnShutdownDaily.Text = "Thiết lập";
            this.btnShutdownDaily.UseVisualStyleBackColor = true;
            this.btnShutdownDaily.Click += new System.EventHandler(this.btnShutdownDaily_Click);
            // 
            // dtpShutdownOne
            // 
            this.dtpShutdownOne.CustomFormat = "HH:mm";
            this.dtpShutdownOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpShutdownOne.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShutdownOne.Location = new System.Drawing.Point(227, 142);
            this.dtpShutdownOne.Name = "dtpShutdownOne";
            this.dtpShutdownOne.ShowUpDown = true;
            this.dtpShutdownOne.Size = new System.Drawing.Size(86, 30);
            this.dtpShutdownOne.TabIndex = 1;
            this.dtpShutdownOne.Value = new System.DateTime(2018, 7, 5, 23, 0, 0, 0);
            this.dtpShutdownOne.ValueChanged += new System.EventHandler(this.dtpShutdownOne_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Áp dụng cho hôm nay";
            // 
            // btnShutdownOne
            // 
            this.btnShutdownOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdownOne.Location = new System.Drawing.Point(337, 140);
            this.btnShutdownOne.Name = "btnShutdownOne";
            this.btnShutdownOne.Size = new System.Drawing.Size(97, 34);
            this.btnShutdownOne.TabIndex = 3;
            this.btnShutdownOne.Text = "Thiết lập";
            this.btnShutdownOne.UseVisualStyleBackColor = true;
            this.btnShutdownOne.Click += new System.EventHandler(this.btnShutdownOne_Click);
            // 
            // btnStopToday
            // 
            this.btnStopToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopToday.Location = new System.Drawing.Point(17, 198);
            this.btnStopToday.Name = "btnStopToday";
            this.btnStopToday.Size = new System.Drawing.Size(226, 34);
            this.btnStopToday.TabIndex = 3;
            this.btnStopToday.Text = "Hôm nay không tắt máy";
            this.btnStopToday.UseVisualStyleBackColor = true;
            this.btnStopToday.Click += new System.EventHandler(this.btnStopToday_Click);
            // 
            // lblStopShutdown
            // 
            this.lblStopShutdown.AutoSize = true;
            this.lblStopShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopShutdown.Location = new System.Drawing.Point(244, 246);
            this.lblStopShutdown.Name = "lblStopShutdown";
            this.lblStopShutdown.Size = new System.Drawing.Size(134, 25);
            this.lblStopShutdown.TabIndex = 2;
            this.lblStopShutdown.Text = "Lịch hôm nay:";
            this.lblStopShutdown.DoubleClick += new System.EventHandler(this.lblStopShutdown_DoubleClick);
            // 
            // lblShutdownAt
            // 
            this.lblShutdownAt.AutoSize = true;
            this.lblShutdownAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShutdownAt.Location = new System.Drawing.Point(384, 246);
            this.lblShutdownAt.Name = "lblShutdownAt";
            this.lblShutdownAt.Size = new System.Drawing.Size(0, 25);
            this.lblShutdownAt.TabIndex = 2;
            // 
            // ntiShutdown
            // 
            this.ntiShutdown.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntiShutdown.BalloonTipText = "Test";
            this.ntiShutdown.ContextMenuStrip = this.contextMenuStrip1;
            this.ntiShutdown.Text = "Test";
            this.ntiShutdown.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiệnChươngTrìnhToolStripMenuItem,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 48);
            // 
            // hiệnChươngTrìnhToolStripMenuItem
            // 
            this.hiệnChươngTrìnhToolStripMenuItem.Name = "hiệnChươngTrìnhToolStripMenuItem";
            this.hiệnChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.hiệnChươngTrìnhToolStripMenuItem.Text = "Hiện chương trình";
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            // 
            // btnShutdownNow
            // 
            this.btnShutdownNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdownNow.Location = new System.Drawing.Point(274, 198);
            this.btnShutdownNow.Name = "btnShutdownNow";
            this.btnShutdownNow.Size = new System.Drawing.Size(160, 34);
            this.btnShutdownNow.TabIndex = 3;
            this.btnShutdownNow.Text = "Tắt máy ngay";
            this.btnShutdownNow.UseVisualStyleBackColor = true;
            this.btnShutdownNow.Click += new System.EventHandler(this.btnShutdownNow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 276);
            this.Controls.Add(this.btnShutdownNow);
            this.Controls.Add(this.btnStopToday);
            this.Controls.Add(this.btnShutdownOne);
            this.Controls.Add(this.btnShutdownDaily);
            this.Controls.Add(this.lblShutdownAt);
            this.Controls.Add(this.lblStopShutdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpShutdownOne);
            this.Controls.Add(this.dtpShutdownDaily);
            this.Controls.Add(this.lblCurrentTime);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tắt máy tính tự động (Sản phẩm của LongKa)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer tmCurrentTime;
        private System.Windows.Forms.DateTimePicker dtpShutdownDaily;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShutdownDaily;
        private System.Windows.Forms.DateTimePicker dtpShutdownOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShutdownOne;
        private System.Windows.Forms.Button btnStopToday;
        private System.Windows.Forms.Label lblStopShutdown;
        private System.Windows.Forms.Label lblShutdownAt;
        private System.Windows.Forms.NotifyIcon ntiShutdown;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hiệnChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.Button btnShutdownNow;
    }
}

