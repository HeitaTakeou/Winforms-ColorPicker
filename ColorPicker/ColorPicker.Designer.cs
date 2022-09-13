namespace ColorPicker
{
    partial class ColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicker));
            this.label1 = new System.Windows.Forms.Label();
            this.rgbpanel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.blackgradientpanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.whitegradientpanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.colorpreviewpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.chromabutton = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.rgbpanelpicker = new Guna.UI2.WinForms.Guna2Panel();
            this.chromaRGB = new System.Windows.Forms.Timer(this.components);
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.rgbpanel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(199, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Color Picker";
            // 
            // rgbpanel
            // 
            this.rgbpanel.BorderRadius = 1;
            this.rgbpanel.Image = ((System.Drawing.Image)(resources.GetObject("rgbpanel.Image")));
            this.rgbpanel.ImageRotate = 0F;
            this.rgbpanel.Location = new System.Drawing.Point(218, 265);
            this.rgbpanel.Name = "rgbpanel";
            this.rgbpanel.Size = new System.Drawing.Size(156, 13);
            this.rgbpanel.TabIndex = 2;
            this.rgbpanel.TabStop = false;
            this.rgbpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rgbpanel_MouseMove);
            // 
            // blackgradientpanel
            // 
            this.blackgradientpanel.BorderRadius = 1;
            this.blackgradientpanel.FillColor = System.Drawing.Color.Cyan;
            this.blackgradientpanel.FillColor2 = System.Drawing.Color.Black;
            this.blackgradientpanel.Location = new System.Drawing.Point(218, 284);
            this.blackgradientpanel.Name = "blackgradientpanel";
            this.blackgradientpanel.Size = new System.Drawing.Size(156, 13);
            this.blackgradientpanel.TabIndex = 3;
            this.blackgradientpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.blackgradientpanel_MouseMove);
            // 
            // whitegradientpanel
            // 
            this.whitegradientpanel.BorderRadius = 3;
            this.whitegradientpanel.FillColor3 = System.Drawing.Color.Cyan;
            this.whitegradientpanel.FillColor4 = System.Drawing.Color.Cyan;
            this.whitegradientpanel.Location = new System.Drawing.Point(218, 128);
            this.whitegradientpanel.Name = "whitegradientpanel";
            this.whitegradientpanel.Size = new System.Drawing.Size(156, 131);
            this.whitegradientpanel.TabIndex = 4;
            this.whitegradientpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.whitegradientpanel_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(228, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Color preview";
            // 
            // colorpreviewpanel
            // 
            this.colorpreviewpanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.colorpreviewpanel.BorderThickness = 1;
            this.colorpreviewpanel.FillColor = System.Drawing.Color.Cyan;
            this.colorpreviewpanel.Location = new System.Drawing.Point(346, 303);
            this.colorpreviewpanel.Name = "colorpreviewpanel";
            this.colorpreviewpanel.Size = new System.Drawing.Size(19, 19);
            this.colorpreviewpanel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.label3.Location = new System.Drawing.Point(228, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chroma Mode";
            // 
            // chromabutton
            // 
            this.chromabutton.Animated = true;
            this.chromabutton.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.chromabutton.CheckedState.BorderRadius = 0;
            this.chromabutton.CheckedState.BorderThickness = 1;
            this.chromabutton.CheckedState.FillColor = System.Drawing.Color.White;
            this.chromabutton.CheckMarkColor = System.Drawing.Color.Transparent;
            this.chromabutton.Location = new System.Drawing.Point(346, 328);
            this.chromabutton.Name = "chromabutton";
            this.chromabutton.Size = new System.Drawing.Size(19, 19);
            this.chromabutton.TabIndex = 9;
            this.chromabutton.Text = "guna2CustomCheckBox1";
            this.chromabutton.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.chromabutton.UncheckedState.BorderRadius = 0;
            this.chromabutton.UncheckedState.BorderThickness = 1;
            this.chromabutton.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.chromabutton.Click += new System.EventHandler(this.chromabutton_Click);
            // 
            // rgbpanelpicker
            // 
            this.rgbpanelpicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.rgbpanelpicker.BorderThickness = 1;
            this.rgbpanelpicker.FillColor = System.Drawing.Color.White;
            this.rgbpanelpicker.Location = new System.Drawing.Point(292, 265);
            this.rgbpanelpicker.Name = "rgbpanelpicker";
            this.rgbpanelpicker.Size = new System.Drawing.Size(5, 13);
            this.rgbpanelpicker.TabIndex = 13;
            // 
            // chromaRGB
            // 
            this.chromaRGB.Interval = 30;
            this.chromaRGB.Tick += new System.EventHandler(this.chromaRGB_Tick);
            // 
            // fadeIn
            // 
            this.fadeIn.Interval = 20;
            this.fadeIn.Tick += new System.EventHandler(this.fadeIn_Tick);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(572, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox1.TabIndex = 14;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.Animated = true;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(549, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2ControlBox2.TabIndex = 15;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(592, 426);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.rgbpanelpicker);
            this.Controls.Add(this.chromabutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorpreviewpanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.whitegradientpanel);
            this.Controls.Add(this.blackgradientpanel);
            this.Controls.Add(this.rgbpanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColorPicker";
            this.Text = "Color Picker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorPicker_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColorPicker_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.rgbpanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox rgbpanel;
        private Guna.UI2.WinForms.Guna2GradientPanel blackgradientpanel;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel whitegradientpanel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel colorpreviewpanel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomCheckBox chromabutton;
        private Guna.UI2.WinForms.Guna2Panel rgbpanelpicker;
        private System.Windows.Forms.Timer chromaRGB;
        private System.Windows.Forms.Timer fadeIn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}

