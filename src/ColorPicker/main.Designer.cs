namespace ColorPicker
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.screen_color = new System.Windows.Forms.PictureBox();
            this.screen = new System.Windows.Forms.PictureBox();
            this.xPosition = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.Label();
            this.rgbText = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.hexText = new System.Windows.Forms.Label();
            this.selected_B = new System.Windows.Forms.Label();
            this.color_list = new System.Windows.Forms.ListBox();
            this.selected_G = new System.Windows.Forms.Label();
            this.selected_color = new System.Windows.Forms.PictureBox();
            this.selected_R = new System.Windows.Forms.Label();
            this.hslText = new System.Windows.Forms.Label();
            this.hsvText = new System.Windows.Forms.Label();
            this.cmykText = new System.Windows.Forms.Label();
            this.screen_timer = new System.Windows.Forms.Timer(this.components);
            this.cielabText = new System.Windows.Forms.Label();
            this.xyzText = new System.Windows.Forms.Label();
            this.yuvText = new System.Windows.Forms.Label();
            this.ycbcrText = new System.Windows.Forms.Label();
            this.lchText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.screen_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_color)).BeginInit();
            this.SuspendLayout();
            // 
            // screen_color
            // 
            this.screen_color.Location = new System.Drawing.Point(169, 12);
            this.screen_color.Name = "screen_color";
            this.screen_color.Size = new System.Drawing.Size(138, 138);
            this.screen_color.TabIndex = 24;
            this.screen_color.TabStop = false;
            this.screen_color.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_color_Paint);
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(12, 12);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(138, 138);
            this.screen.TabIndex = 23;
            this.screen.TabStop = false;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            // 
            // xPosition
            // 
            this.xPosition.AutoSize = true;
            this.xPosition.BackColor = System.Drawing.Color.Transparent;
            this.xPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPosition.ForeColor = System.Drawing.Color.Black;
            this.xPosition.Location = new System.Drawing.Point(13, 153);
            this.xPosition.Name = "xPosition";
            this.xPosition.Size = new System.Drawing.Size(19, 17);
            this.xPosition.TabIndex = 25;
            this.xPosition.Text = "X:";
            // 
            // yPosition
            // 
            this.yPosition.AutoSize = true;
            this.yPosition.BackColor = System.Drawing.Color.Transparent;
            this.yPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPosition.ForeColor = System.Drawing.Color.Black;
            this.yPosition.Location = new System.Drawing.Point(71, 153);
            this.yPosition.Name = "yPosition";
            this.yPosition.Size = new System.Drawing.Size(19, 17);
            this.yPosition.TabIndex = 26;
            this.yPosition.Text = "Y:";
            // 
            // rgbText
            // 
            this.rgbText.AutoSize = true;
            this.rgbText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbText.ForeColor = System.Drawing.Color.Black;
            this.rgbText.Location = new System.Drawing.Point(325, 17);
            this.rgbText.Name = "rgbText";
            this.rgbText.Size = new System.Drawing.Size(36, 17);
            this.rgbText.TabIndex = 27;
            this.rgbText.Text = "RGB:";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.DarkGray;
            this.copyright.Location = new System.Drawing.Point(3, 361);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(195, 13);
            this.copyright.TabIndex = 36;
            this.copyright.Text = " © 2025 LeeKiJoon all rights reserved";
            // 
            // hexText
            // 
            this.hexText.AutoSize = true;
            this.hexText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexText.ForeColor = System.Drawing.Color.Black;
            this.hexText.Location = new System.Drawing.Point(325, 44);
            this.hexText.Name = "hexText";
            this.hexText.Size = new System.Drawing.Size(36, 17);
            this.hexText.TabIndex = 30;
            this.hexText.Text = "HEX:";
            // 
            // selected_B
            // 
            this.selected_B.AutoSize = true;
            this.selected_B.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_B.ForeColor = System.Drawing.Color.Black;
            this.selected_B.Location = new System.Drawing.Point(324, 297);
            this.selected_B.Name = "selected_B";
            this.selected_B.Size = new System.Drawing.Size(19, 17);
            this.selected_B.TabIndex = 35;
            this.selected_B.Text = "B:";
            // 
            // color_list
            // 
            this.color_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.color_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_list.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_list.ForeColor = System.Drawing.Color.White;
            this.color_list.FormattingEnabled = true;
            this.color_list.ItemHeight = 17;
            this.color_list.Location = new System.Drawing.Point(12, 190);
            this.color_list.Name = "color_list";
            this.color_list.Size = new System.Drawing.Size(147, 138);
            this.color_list.TabIndex = 31;
            // 
            // selected_G
            // 
            this.selected_G.AutoSize = true;
            this.selected_G.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_G.ForeColor = System.Drawing.Color.Black;
            this.selected_G.Location = new System.Drawing.Point(324, 269);
            this.selected_G.Name = "selected_G";
            this.selected_G.Size = new System.Drawing.Size(20, 17);
            this.selected_G.TabIndex = 34;
            this.selected_G.Text = "G:";
            // 
            // selected_color
            // 
            this.selected_color.Location = new System.Drawing.Point(169, 190);
            this.selected_color.Name = "selected_color";
            this.selected_color.Size = new System.Drawing.Size(138, 138);
            this.selected_color.TabIndex = 32;
            this.selected_color.TabStop = false;
            // 
            // selected_R
            // 
            this.selected_R.AutoSize = true;
            this.selected_R.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_R.ForeColor = System.Drawing.Color.Black;
            this.selected_R.Location = new System.Drawing.Point(325, 237);
            this.selected_R.Name = "selected_R";
            this.selected_R.Size = new System.Drawing.Size(19, 17);
            this.selected_R.TabIndex = 33;
            this.selected_R.Text = "R:";
            // 
            // hslText
            // 
            this.hslText.AutoSize = true;
            this.hslText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hslText.ForeColor = System.Drawing.Color.Black;
            this.hslText.Location = new System.Drawing.Point(327, 71);
            this.hslText.Name = "hslText";
            this.hslText.Size = new System.Drawing.Size(34, 17);
            this.hslText.TabIndex = 37;
            this.hslText.Text = "HSL:";
            // 
            // hsvText
            // 
            this.hsvText.AutoSize = true;
            this.hsvText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hsvText.ForeColor = System.Drawing.Color.Black;
            this.hsvText.Location = new System.Drawing.Point(325, 98);
            this.hsvText.Name = "hsvText";
            this.hsvText.Size = new System.Drawing.Size(36, 17);
            this.hsvText.TabIndex = 38;
            this.hsvText.Text = "HSV:";
            // 
            // cmykText
            // 
            this.cmykText.AutoSize = true;
            this.cmykText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmykText.ForeColor = System.Drawing.Color.Black;
            this.cmykText.Location = new System.Drawing.Point(314, 125);
            this.cmykText.Name = "cmykText";
            this.cmykText.Size = new System.Drawing.Size(47, 17);
            this.cmykText.TabIndex = 39;
            this.cmykText.Text = "CMYK:";
            // 
            // screen_timer
            // 
            this.screen_timer.Tick += new System.EventHandler(this.screen_timer_Tick);
            // 
            // cielabText
            // 
            this.cielabText.AutoSize = true;
            this.cielabText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cielabText.ForeColor = System.Drawing.Color.Black;
            this.cielabText.Location = new System.Drawing.Point(504, 18);
            this.cielabText.Name = "cielabText";
            this.cielabText.Size = new System.Drawing.Size(53, 17);
            this.cielabText.TabIndex = 40;
            this.cielabText.Text = "CIELAB:";
            // 
            // xyzText
            // 
            this.xyzText.AutoSize = true;
            this.xyzText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyzText.ForeColor = System.Drawing.Color.Black;
            this.xyzText.Location = new System.Drawing.Point(522, 44);
            this.xyzText.Name = "xyzText";
            this.xyzText.Size = new System.Drawing.Size(35, 17);
            this.xyzText.TabIndex = 41;
            this.xyzText.Text = "XYZ:";
            // 
            // yuvText
            // 
            this.yuvText.AutoSize = true;
            this.yuvText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yuvText.ForeColor = System.Drawing.Color.Black;
            this.yuvText.Location = new System.Drawing.Point(521, 70);
            this.yuvText.Name = "yuvText";
            this.yuvText.Size = new System.Drawing.Size(36, 17);
            this.yuvText.TabIndex = 42;
            this.yuvText.Text = "YUV:";
            // 
            // ycbcrText
            // 
            this.ycbcrText.AutoSize = true;
            this.ycbcrText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ycbcrText.ForeColor = System.Drawing.Color.Black;
            this.ycbcrText.Location = new System.Drawing.Point(508, 96);
            this.ycbcrText.Name = "ycbcrText";
            this.ycbcrText.Size = new System.Drawing.Size(49, 17);
            this.ycbcrText.TabIndex = 43;
            this.ycbcrText.Text = "YCbCr:";
            // 
            // lchText
            // 
            this.lchText.AutoSize = true;
            this.lchText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lchText.ForeColor = System.Drawing.Color.Black;
            this.lchText.Location = new System.Drawing.Point(522, 122);
            this.lchText.Name = "lchText";
            this.lchText.Size = new System.Drawing.Size(35, 17);
            this.lchText.TabIndex = 44;
            this.lchText.Text = "LCH:";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 376);
            this.Controls.Add(this.lchText);
            this.Controls.Add(this.ycbcrText);
            this.Controls.Add(this.yuvText);
            this.Controls.Add(this.xyzText);
            this.Controls.Add(this.cielabText);
            this.Controls.Add(this.cmykText);
            this.Controls.Add(this.hsvText);
            this.Controls.Add(this.hslText);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.xPosition);
            this.Controls.Add(this.yPosition);
            this.Controls.Add(this.rgbText);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.hexText);
            this.Controls.Add(this.selected_B);
            this.Controls.Add(this.color_list);
            this.Controls.Add(this.selected_G);
            this.Controls.Add(this.selected_color);
            this.Controls.Add(this.selected_R);
            this.Controls.Add(this.screen_color);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Color Picker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.screen_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox screen_color;
        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Label xPosition;
        private System.Windows.Forms.Label yPosition;
        private System.Windows.Forms.Label rgbText;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label hexText;
        private System.Windows.Forms.Label selected_B;
        private System.Windows.Forms.ListBox color_list;
        private System.Windows.Forms.Label selected_G;
        private System.Windows.Forms.PictureBox selected_color;
        private System.Windows.Forms.Label selected_R;
        private System.Windows.Forms.Label hslText;
        private System.Windows.Forms.Label hsvText;
        private System.Windows.Forms.Label cmykText;
        private System.Windows.Forms.Timer screen_timer;
        private System.Windows.Forms.Label cielabText;
        private System.Windows.Forms.Label xyzText;
        private System.Windows.Forms.Label yuvText;
        private System.Windows.Forms.Label ycbcrText;
        private System.Windows.Forms.Label lchText;
    }
}

