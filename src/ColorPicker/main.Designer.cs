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
            this.scroll_r = new System.Windows.Forms.HScrollBar();
            this.scroll_g = new System.Windows.Forms.HScrollBar();
            this.scroll_b = new System.Windows.Forms.HScrollBar();
            this.gradient_box = new System.Windows.Forms.PictureBox();
            this.coppyButton = new System.Windows.Forms.Button();
            this.bannerAds = new AdsJumboWinForm.BannerAds();
            this.selectedColorText = new System.Windows.Forms.TextBox();
            this.colorComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.screen_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradient_box)).BeginInit();
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
            this.xPosition.ForeColor = System.Drawing.Color.White;
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
            this.yPosition.ForeColor = System.Drawing.Color.White;
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
            this.rgbText.ForeColor = System.Drawing.Color.White;
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
            this.copyright.Location = new System.Drawing.Point(1, 477);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(195, 13);
            this.copyright.TabIndex = 36;
            this.copyright.Text = " © 2025 LeeKiJoon all rights reserved";
            // 
            // hexText
            // 
            this.hexText.AutoSize = true;
            this.hexText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexText.ForeColor = System.Drawing.Color.White;
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
            this.selected_B.ForeColor = System.Drawing.Color.White;
            this.selected_B.Location = new System.Drawing.Point(324, 297);
            this.selected_B.Name = "selected_B";
            this.selected_B.Size = new System.Drawing.Size(19, 17);
            this.selected_B.TabIndex = 35;
            this.selected_B.Text = "B:";
            // 
            // color_list
            // 
            this.color_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.color_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_list.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.selected_G.ForeColor = System.Drawing.Color.White;
            this.selected_G.Location = new System.Drawing.Point(324, 252);
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
            this.selected_color.Paint += new System.Windows.Forms.PaintEventHandler(this.selected_color_Paint);
            // 
            // selected_R
            // 
            this.selected_R.AutoSize = true;
            this.selected_R.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_R.ForeColor = System.Drawing.Color.White;
            this.selected_R.Location = new System.Drawing.Point(325, 210);
            this.selected_R.Name = "selected_R";
            this.selected_R.Size = new System.Drawing.Size(19, 17);
            this.selected_R.TabIndex = 33;
            this.selected_R.Text = "R:";
            // 
            // hslText
            // 
            this.hslText.AutoSize = true;
            this.hslText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hslText.ForeColor = System.Drawing.Color.White;
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
            this.hsvText.ForeColor = System.Drawing.Color.White;
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
            this.cmykText.ForeColor = System.Drawing.Color.White;
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
            this.cielabText.ForeColor = System.Drawing.Color.White;
            this.cielabText.Location = new System.Drawing.Point(523, 18);
            this.cielabText.Name = "cielabText";
            this.cielabText.Size = new System.Drawing.Size(53, 17);
            this.cielabText.TabIndex = 40;
            this.cielabText.Text = "CIELAB:";
            // 
            // xyzText
            // 
            this.xyzText.AutoSize = true;
            this.xyzText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xyzText.ForeColor = System.Drawing.Color.White;
            this.xyzText.Location = new System.Drawing.Point(541, 44);
            this.xyzText.Name = "xyzText";
            this.xyzText.Size = new System.Drawing.Size(35, 17);
            this.xyzText.TabIndex = 41;
            this.xyzText.Text = "XYZ:";
            // 
            // yuvText
            // 
            this.yuvText.AutoSize = true;
            this.yuvText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yuvText.ForeColor = System.Drawing.Color.White;
            this.yuvText.Location = new System.Drawing.Point(540, 70);
            this.yuvText.Name = "yuvText";
            this.yuvText.Size = new System.Drawing.Size(36, 17);
            this.yuvText.TabIndex = 42;
            this.yuvText.Text = "YUV:";
            // 
            // ycbcrText
            // 
            this.ycbcrText.AutoSize = true;
            this.ycbcrText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ycbcrText.ForeColor = System.Drawing.Color.White;
            this.ycbcrText.Location = new System.Drawing.Point(527, 96);
            this.ycbcrText.Name = "ycbcrText";
            this.ycbcrText.Size = new System.Drawing.Size(49, 17);
            this.ycbcrText.TabIndex = 43;
            this.ycbcrText.Text = "YCbCr:";
            // 
            // lchText
            // 
            this.lchText.AutoSize = true;
            this.lchText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lchText.ForeColor = System.Drawing.Color.White;
            this.lchText.Location = new System.Drawing.Point(541, 122);
            this.lchText.Name = "lchText";
            this.lchText.Size = new System.Drawing.Size(35, 17);
            this.lchText.TabIndex = 44;
            this.lchText.Text = "LCH:";
            // 
            // scroll_r
            // 
            this.scroll_r.LargeChange = 1;
            this.scroll_r.Location = new System.Drawing.Point(385, 210);
            this.scroll_r.Maximum = 255;
            this.scroll_r.Name = "scroll_r";
            this.scroll_r.Size = new System.Drawing.Size(331, 22);
            this.scroll_r.TabIndex = 45;
            this.scroll_r.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_r_Scroll);
            // 
            // scroll_g
            // 
            this.scroll_g.LargeChange = 1;
            this.scroll_g.Location = new System.Drawing.Point(385, 252);
            this.scroll_g.Maximum = 255;
            this.scroll_g.Name = "scroll_g";
            this.scroll_g.Size = new System.Drawing.Size(331, 22);
            this.scroll_g.TabIndex = 46;
            this.scroll_g.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_g_Scroll);
            // 
            // scroll_b
            // 
            this.scroll_b.LargeChange = 1;
            this.scroll_b.Location = new System.Drawing.Point(385, 297);
            this.scroll_b.Maximum = 255;
            this.scroll_b.Name = "scroll_b";
            this.scroll_b.Size = new System.Drawing.Size(331, 22);
            this.scroll_b.TabIndex = 47;
            this.scroll_b.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scroll_b_Scroll);
            // 
            // gradient_box
            // 
            this.gradient_box.Cursor = System.Windows.Forms.Cursors.Cross;
            this.gradient_box.Location = new System.Drawing.Point(15, 392);
            this.gradient_box.Name = "gradient_box";
            this.gradient_box.Size = new System.Drawing.Size(701, 64);
            this.gradient_box.TabIndex = 48;
            this.gradient_box.TabStop = false;
            this.gradient_box.Click += new System.EventHandler(this.gradient_box_Click);
            this.gradient_box.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient_box_Paint);
            this.gradient_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradient_box_MouseDown);
            this.gradient_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradient_box_MouseMove);
            this.gradient_box.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gradient_box_MouseUp);
            // 
            // coppyButton
            // 
            this.coppyButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.coppyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.coppyButton.FlatAppearance.BorderSize = 0;
            this.coppyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coppyButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coppyButton.ForeColor = System.Drawing.Color.White;
            this.coppyButton.Location = new System.Drawing.Point(317, 340);
            this.coppyButton.Name = "coppyButton";
            this.coppyButton.Size = new System.Drawing.Size(138, 33);
            this.coppyButton.TabIndex = 49;
            this.coppyButton.Text = "Copy Value";
            this.coppyButton.UseVisualStyleBackColor = false;
            this.coppyButton.Click += new System.EventHandler(this.coppyButton_Click);
            // 
            // bannerAds
            // 
            this.bannerAds.ApplicationId = null;
            this.bannerAds.BackColor = System.Drawing.Color.White;
            this.bannerAds.HeightAd = 0;
            this.bannerAds.Location = new System.Drawing.Point(726, 12);
            this.bannerAds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bannerAds.Name = "bannerAds";
            this.bannerAds.Size = new System.Drawing.Size(139, 462);
            this.bannerAds.TabIndex = 51;
            this.bannerAds.WidthAd = 0;
            // 
            // selectedColorText
            // 
            this.selectedColorText.BackColor = System.Drawing.Color.White;
            this.selectedColorText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedColorText.Location = new System.Drawing.Point(170, 340);
            this.selectedColorText.Name = "selectedColorText";
            this.selectedColorText.Size = new System.Drawing.Size(136, 33);
            this.selectedColorText.TabIndex = 52;
            this.selectedColorText.Text = "HotKey : X";
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.ItemHeight = 23;
            this.colorComboBox.Items.AddRange(new object[] {
            "RGB",
            "HEX",
            "HSL",
            "HSV",
            "CMYK",
            "CIELAB",
            "XYZ",
            "YUV",
            "YCbCr",
            "LCH"});
            this.colorComboBox.Location = new System.Drawing.Point(12, 344);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(147, 29);
            this.colorComboBox.TabIndex = 53;
            this.colorComboBox.UseSelectable = true;
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.ClientSize = new System.Drawing.Size(875, 496);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.selectedColorText);
            this.Controls.Add(this.bannerAds);
            this.Controls.Add(this.coppyButton);
            this.Controls.Add(this.gradient_box);
            this.Controls.Add(this.scroll_b);
            this.Controls.Add(this.scroll_g);
            this.Controls.Add(this.scroll_r);
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
            ((System.ComponentModel.ISupportInitialize)(this.gradient_box)).EndInit();
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
        private System.Windows.Forms.HScrollBar scroll_r;
        private System.Windows.Forms.HScrollBar scroll_g;
        private System.Windows.Forms.HScrollBar scroll_b;
        private System.Windows.Forms.PictureBox gradient_box;
        private System.Windows.Forms.Button coppyButton;
        private AdsJumboWinForm.BannerAds bannerAds;
        private System.Windows.Forms.TextBox selectedColorText;
        private MetroFramework.Controls.MetroComboBox colorComboBox;
    }
}

