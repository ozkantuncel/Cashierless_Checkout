namespace Cashierless_Checkout
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.pnlG = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customPictureBox1 = new Cashierless_Checkout.CustomPictureBox();
            this.cstbtnLogin = new Cashierless_Checkout.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlG
            // 
            this.pnlG.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlG.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlG.Location = new System.Drawing.Point(0, 0);
            this.pnlG.Name = "pnlG";
            this.pnlG.Size = new System.Drawing.Size(63, 683);
            this.pnlG.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNick.Location = new System.Drawing.Point(86, 323);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(356, 15);
            this.txtNick.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(86, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(86, 470);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 1);
            this.panel2.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(86, 449);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(356, 15);
            this.txtPass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(81, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "İsim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(81, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Parola";
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.customPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(455, 12);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(31, 26);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 12;
            this.customPictureBox1.TabStop = false;
            this.customPictureBox1.Click += new System.EventHandler(this.customPictureBox1_Click);
            // 
            // cstbtnLogin
            // 
            this.cstbtnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.cstbtnLogin.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.cstbtnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cstbtnLogin.BorderRadius = 30;
            this.cstbtnLogin.BorderSize = 0;
            this.cstbtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cstbtnLogin.FlatAppearance.BorderSize = 0;
            this.cstbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cstbtnLogin.ForeColor = System.Drawing.Color.White;
            this.cstbtnLogin.Location = new System.Drawing.Point(168, 522);
            this.cstbtnLogin.Name = "cstbtnLogin";
            this.cstbtnLogin.Size = new System.Drawing.Size(198, 72);
            this.cstbtnLogin.TabIndex = 11;
            this.cstbtnLogin.Text = "Giriş Yap";
            this.cstbtnLogin.TextColor = System.Drawing.Color.White;
            this.cstbtnLogin.UseVisualStyleBackColor = false;
            this.cstbtnLogin.Click += new System.EventHandler(this.cstbtnLogin_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(498, 683);
            this.Controls.Add(this.customPictureBox1);
            this.Controls.Add(this.cstbtnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlG);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomButton cstbtnLogin;
        private CustomPictureBox customPictureBox1;
    }
}