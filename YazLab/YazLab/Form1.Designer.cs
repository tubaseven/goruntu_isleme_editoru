namespace YazLab
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_openFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_saveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_information = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_reopen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_negative = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_grayScale = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_histogram = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_mirror = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_rotateClockwise = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_rotateNClockwise = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox_width = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_height = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton_scale = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_RedChannel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_GreenChannel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_BlueChannel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox_resim = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resim)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(1, 1);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(311, 80);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 8;
            this.pictureBox_logo.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton_openFile,
            this.toolStripLabel5,
            this.toolStripButton_saveFile,
            this.toolStripLabel4,
            this.toolStripButton_information,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(315, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.toolStrip1.Size = new System.Drawing.Size(371, 73);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 54);
            this.toolStripLabel1.Text = "         ";
            // 
            // toolStripButton_openFile
            // 
            this.toolStripButton_openFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_openFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_openFile.Image")));
            this.toolStripButton_openFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_openFile.Name = "toolStripButton_openFile";
            this.toolStripButton_openFile.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton_openFile.Text = "DOSYA AÇ";
            this.toolStripButton_openFile.Click += new System.EventHandler(this.toolStripButton_openFile_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(45, 54);
            this.toolStripLabel5.Text = "         ";
            // 
            // toolStripButton_saveFile
            // 
            this.toolStripButton_saveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_saveFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_saveFile.Image")));
            this.toolStripButton_saveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_saveFile.Name = "toolStripButton_saveFile";
            this.toolStripButton_saveFile.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton_saveFile.Text = "RESMİ KAYDET";
            this.toolStripButton_saveFile.Click += new System.EventHandler(this.toolStripButton_saveFile_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(45, 54);
            this.toolStripLabel4.Text = "         ";
            // 
            // toolStripButton_information
            // 
            this.toolStripButton_information.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_information.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_information.Image")));
            this.toolStripButton_information.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_information.Name = "toolStripButton_information";
            this.toolStripButton_information.Size = new System.Drawing.Size(54, 54);
            this.toolStripButton_information.Text = "PROGRAM HAKKINDA";
            this.toolStripButton_information.Click += new System.EventHandler(this.toolStripButton_information_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(45, 54);
            this.toolStripLabel3.Text = "         ";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_reopen,
            this.toolStripSeparator5,
            this.toolStripButton_negative,
            this.toolStripSeparator3,
            this.toolStripButton_grayScale,
            this.toolStripSeparator8,
            this.toolStripButton_histogram,
            this.toolStripSeparator9,
            this.toolStripButton_mirror,
            this.toolStripSeparator2,
            this.toolStripButton_rotateClockwise,
            this.toolStripButton_rotateNClockwise,
            this.toolStripSeparator7,
            this.toolStripTextBox_width,
            this.toolStripTextBox_height,
            this.toolStripButton_scale,
            this.toolStripSeparator6,
            this.toolStripButton_RedChannel,
            this.toolStripButton_GreenChannel,
            this.toolStripButton_BlueChannel,
            this.toolStripSeparator1});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(4, 83);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.toolStrip2.Size = new System.Drawing.Size(64, 678);
            this.toolStrip2.TabIndex = 10;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton_reopen
            // 
            this.toolStripButton_reopen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_reopen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_reopen.Image")));
            this.toolStripButton_reopen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_reopen.Name = "toolStripButton_reopen";
            this.toolStripButton_reopen.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_reopen.Text = "REOPEN";
            this.toolStripButton_reopen.Click += new System.EventHandler(this.toolStripButton_reopen_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(45, 6);
            // 
            // toolStripButton_negative
            // 
            this.toolStripButton_negative.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_negative.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_negative.Image")));
            this.toolStripButton_negative.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_negative.Name = "toolStripButton_negative";
            this.toolStripButton_negative.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_negative.Text = "NEGATIVE";
            this.toolStripButton_negative.Click += new System.EventHandler(this.toolStripButton_negative_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(45, 6);
            // 
            // toolStripButton_grayScale
            // 
            this.toolStripButton_grayScale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_grayScale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_grayScale.Image")));
            this.toolStripButton_grayScale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_grayScale.Name = "toolStripButton_grayScale";
            this.toolStripButton_grayScale.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_grayScale.Text = "GRAY SCALING";
            this.toolStripButton_grayScale.Click += new System.EventHandler(this.toolStripButton_grayScale_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(45, 6);
            // 
            // toolStripButton_histogram
            // 
            this.toolStripButton_histogram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_histogram.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_histogram.Image")));
            this.toolStripButton_histogram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_histogram.Name = "toolStripButton_histogram";
            this.toolStripButton_histogram.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_histogram.Text = "HISTOGRAM";
            this.toolStripButton_histogram.Click += new System.EventHandler(this.toolStripButton_histogram_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(45, 6);
            // 
            // toolStripButton_mirror
            // 
            this.toolStripButton_mirror.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_mirror.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_mirror.Image")));
            this.toolStripButton_mirror.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_mirror.Name = "toolStripButton_mirror";
            this.toolStripButton_mirror.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_mirror.Text = "MIRRORING";
            this.toolStripButton_mirror.Click += new System.EventHandler(this.toolStripButton_mirror_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(45, 6);
            // 
            // toolStripButton_rotateClockwise
            // 
            this.toolStripButton_rotateClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_rotateClockwise.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_rotateClockwise.Image")));
            this.toolStripButton_rotateClockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_rotateClockwise.Name = "toolStripButton_rotateClockwise";
            this.toolStripButton_rotateClockwise.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_rotateClockwise.Text = "ROTATE-90-CLOCKWISE";
            this.toolStripButton_rotateClockwise.Click += new System.EventHandler(this.toolStripButton_rotateClockwise_Click);
            // 
            // toolStripButton_rotateNClockwise
            // 
            this.toolStripButton_rotateNClockwise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_rotateNClockwise.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_rotateNClockwise.Image")));
            this.toolStripButton_rotateNClockwise.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_rotateNClockwise.Name = "toolStripButton_rotateNClockwise";
            this.toolStripButton_rotateNClockwise.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_rotateNClockwise.Text = "ROTATION-90-N-CLOCKWISE";
            this.toolStripButton_rotateNClockwise.Click += new System.EventHandler(this.toolStripButton_rotateNClockwise_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(45, 6);
            // 
            // toolStripTextBox_width
            // 
            this.toolStripTextBox_width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_width.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripTextBox_width.Name = "toolStripTextBox_width";
            this.toolStripTextBox_width.Size = new System.Drawing.Size(43, 32);
            this.toolStripTextBox_width.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripTextBox_height
            // 
            this.toolStripTextBox_height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_height.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripTextBox_height.Name = "toolStripTextBox_height";
            this.toolStripTextBox_height.Size = new System.Drawing.Size(43, 32);
            this.toolStripTextBox_height.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripButton_scale
            // 
            this.toolStripButton_scale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_scale.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_scale.Image")));
            this.toolStripButton_scale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_scale.Name = "toolStripButton_scale";
            this.toolStripButton_scale.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_scale.Text = "SCALE";
            this.toolStripButton_scale.Click += new System.EventHandler(this.toolStripButton_scale_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(45, 6);
            // 
            // toolStripButton_RedChannel
            // 
            this.toolStripButton_RedChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_RedChannel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_RedChannel.Image")));
            this.toolStripButton_RedChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_RedChannel.Name = "toolStripButton_RedChannel";
            this.toolStripButton_RedChannel.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_RedChannel.Text = "RED CHANNEL";
            this.toolStripButton_RedChannel.Click += new System.EventHandler(this.toolStripButton_RedChannel_Click);
            // 
            // toolStripButton_GreenChannel
            // 
            this.toolStripButton_GreenChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_GreenChannel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_GreenChannel.Image")));
            this.toolStripButton_GreenChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_GreenChannel.Name = "toolStripButton_GreenChannel";
            this.toolStripButton_GreenChannel.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_GreenChannel.Text = "GREEN CHANNEL";
            this.toolStripButton_GreenChannel.Click += new System.EventHandler(this.toolStripButton_GreenChannel_Click);
            // 
            // toolStripButton_BlueChannel
            // 
            this.toolStripButton_BlueChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_BlueChannel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_BlueChannel.Image")));
            this.toolStripButton_BlueChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_BlueChannel.Name = "toolStripButton_BlueChannel";
            this.toolStripButton_BlueChannel.Size = new System.Drawing.Size(45, 46);
            this.toolStripButton_BlueChannel.Text = "BLUE CHANNEL";
            this.toolStripButton_BlueChannel.Click += new System.EventHandler(this.toolStripButton_BlueChannel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(45, 6);
            // 
            // pictureBox_resim
            // 
            this.pictureBox_resim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_resim.Location = new System.Drawing.Point(91, 92);
            this.pictureBox_resim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_resim.Name = "pictureBox_resim";
            this.pictureBox_resim.Size = new System.Drawing.Size(776, 769);
            this.pictureBox_resim.TabIndex = 11;
            this.pictureBox_resim.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 863);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(907, 25);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(328, 20);
            this.toolStripStatusLabel1.Text = " GÖRÜNTÜ İŞLEME EDİTÖRÜ V-1.0.0 YAZLAB-1.1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 888);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox_resim);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox_logo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntü İşleme Editörü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_resim)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton_openFile;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripButton toolStripButton_saveFile;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton toolStripButton_information;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton_histogram;
        private System.Windows.Forms.ToolStripButton toolStripButton_negative;
        private System.Windows.Forms.ToolStripButton toolStripButton_mirror;
        private System.Windows.Forms.ToolStripButton toolStripButton_rotateClockwise;
        private System.Windows.Forms.ToolStripButton toolStripButton_rotateNClockwise;
        private System.Windows.Forms.ToolStripButton toolStripButton_scale;
        private System.Windows.Forms.ToolStripButton toolStripButton_reopen;
        private System.Windows.Forms.PictureBox pictureBox_resim;
        private System.Windows.Forms.ToolStripButton toolStripButton_grayScale;
        private System.Windows.Forms.ToolStripButton toolStripButton_GreenChannel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_width;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_height;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton toolStripButton_RedChannel;
        private System.Windows.Forms.ToolStripButton toolStripButton_BlueChannel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

