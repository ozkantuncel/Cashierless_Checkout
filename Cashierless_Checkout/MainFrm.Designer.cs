namespace Cashierless_Checkout
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            System.Windows.Forms.Button BtnExit;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customButton2 = new Cashierless_Checkout.CustomButton();
            this.customButton1 = new Cashierless_Checkout.CustomButton();
            this.lnkYntGr = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Tomato;
            this.customButton2.BackgroundColor = System.Drawing.Color.Tomato;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 20;
            this.customButton2.BorderSize = 0;
            this.customButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton2.ForeColor = System.Drawing.Color.Black;
            this.customButton2.Image = ((System.Drawing.Image)(resources.GetObject("customButton2.Image")));
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.Location = new System.Drawing.Point(12, 481);
            this.customButton2.Name = "customButton2";
            this.customButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customButton2.Size = new System.Drawing.Size(170, 57);
            this.customButton2.TabIndex = 2;
            this.customButton2.Text = "Yardım   ";
            this.customButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DodgerBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 30;
            this.customButton1.BorderSize = 0;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton1.Location = new System.Drawing.Point(249, 305);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(581, 89);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "Başlamak için tıklayın";
            this.customButton1.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // lnkYntGr
            // 
            this.lnkYntGr.ActiveLinkColor = System.Drawing.Color.MidnightBlue;
            this.lnkYntGr.AutoSize = true;
            this.lnkYntGr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkYntGr.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lnkYntGr.Location = new System.Drawing.Point(939, 522);
            this.lnkYntGr.Name = "lnkYntGr";
            this.lnkYntGr.Size = new System.Drawing.Size(112, 19);
            this.lnkYntGr.TabIndex = 5;
            this.lnkYntGr.TabStop = true;
            this.lnkYntGr.Text = "Yönetici Girişi";
            this.lnkYntGr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYntGr_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.Controls.Add(BtnExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1063, 39);
            this.panel4.TabIndex = 56;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = System.Drawing.Color.SeaGreen;
            BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            BtnExit.Location = new System.Drawing.Point(998, 0);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new System.Drawing.Size(65, 39);
            BtnExit.TabIndex = 54;
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 550);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lnkYntGr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton customButton1;
        private CustomButton customButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkYntGr;
        private System.Windows.Forms.Panel panel4;
    }
}

