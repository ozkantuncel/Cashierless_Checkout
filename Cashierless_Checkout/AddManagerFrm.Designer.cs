namespace Cashierless_Checkout
{
    partial class AddManagerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddManagerFrm));
            this.CstbtnDelManager = new Cashierless_Checkout.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlG = new System.Windows.Forms.Panel();
            this.listAdmin = new System.Windows.Forms.ListView();
            this.CstBtnAddManager = new Cashierless_Checkout.CustomButton();
            this.CstPboxEx = new Cashierless_Checkout.CustomPictureBox();
            this.btnGnrcPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.customPictureBox1 = new Cashierless_Checkout.CustomPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CstPboxEx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CstbtnDelManager
            // 
            this.CstbtnDelManager.BackColor = System.Drawing.Color.White;
            this.CstbtnDelManager.BackgroundColor = System.Drawing.Color.White;
            this.CstbtnDelManager.BorderColor = System.Drawing.Color.Black;
            this.CstbtnDelManager.BorderRadius = 30;
            this.CstbtnDelManager.BorderSize = 1;
            this.CstbtnDelManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CstbtnDelManager.FlatAppearance.BorderSize = 0;
            this.CstbtnDelManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CstbtnDelManager.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CstbtnDelManager.ForeColor = System.Drawing.Color.Black;
            this.CstbtnDelManager.Location = new System.Drawing.Point(435, 545);
            this.CstbtnDelManager.Name = "CstbtnDelManager";
            this.CstbtnDelManager.Size = new System.Drawing.Size(93, 73);
            this.CstbtnDelManager.TabIndex = 21;
            this.CstbtnDelManager.Text = "Sil";
            this.CstbtnDelManager.TextColor = System.Drawing.Color.Black;
            this.CstbtnDelManager.UseVisualStyleBackColor = false;
            this.CstbtnDelManager.Click += new System.EventHandler(this.CstbtnDelManager_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(88, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "Parola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(88, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 19;
            this.label2.Text = "İsim";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(93, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 1);
            this.panel2.TabIndex = 18;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Enabled = false;
            this.txtPass.Location = new System.Drawing.Point(93, 364);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(356, 15);
            this.txtPass.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(93, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 1);
            this.panel1.TabIndex = 16;
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNick.Location = new System.Drawing.Point(93, 278);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(356, 15);
            this.txtNick.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(184, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pnlG
            // 
            this.pnlG.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlG.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlG.Location = new System.Drawing.Point(0, 0);
            this.pnlG.Name = "pnlG";
            this.pnlG.Size = new System.Drawing.Size(63, 630);
            this.pnlG.TabIndex = 13;
            // 
            // listAdmin
            // 
            this.listAdmin.BackColor = System.Drawing.SystemColors.Window;
            this.listAdmin.CheckBoxes = true;
            this.listAdmin.FullRowSelect = true;
            this.listAdmin.GridLines = true;
            this.listAdmin.HideSelection = false;
            this.listAdmin.Location = new System.Drawing.Point(534, 43);
            this.listAdmin.Name = "listAdmin";
            this.listAdmin.Size = new System.Drawing.Size(454, 553);
            this.listAdmin.TabIndex = 26;
            this.listAdmin.UseCompatibleStateImageBehavior = false;
            this.listAdmin.View = System.Windows.Forms.View.Details;
            // 
            // CstBtnAddManager
            // 
            this.CstBtnAddManager.BackColor = System.Drawing.Color.White;
            this.CstBtnAddManager.BackgroundColor = System.Drawing.Color.White;
            this.CstBtnAddManager.BorderColor = System.Drawing.Color.Black;
            this.CstBtnAddManager.BorderRadius = 30;
            this.CstBtnAddManager.BorderSize = 1;
            this.CstBtnAddManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CstBtnAddManager.FlatAppearance.BorderSize = 0;
            this.CstBtnAddManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CstBtnAddManager.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CstBtnAddManager.ForeColor = System.Drawing.Color.Black;
            this.CstBtnAddManager.Location = new System.Drawing.Point(435, 467);
            this.CstBtnAddManager.Name = "CstBtnAddManager";
            this.CstBtnAddManager.Size = new System.Drawing.Size(93, 72);
            this.CstBtnAddManager.TabIndex = 28;
            this.CstBtnAddManager.Text = "Ekle";
            this.CstBtnAddManager.TextColor = System.Drawing.Color.Black;
            this.CstBtnAddManager.UseVisualStyleBackColor = false;
            this.CstBtnAddManager.Click += new System.EventHandler(this.CstBtnAddManager_Click);
            // 
            // CstPboxEx
            // 
            this.CstPboxEx.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CstPboxEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CstPboxEx.Image = ((System.Drawing.Image)(resources.GetObject("CstPboxEx.Image")));
            this.CstPboxEx.Location = new System.Drawing.Point(957, 12);
            this.CstPboxEx.Name = "CstPboxEx";
            this.CstPboxEx.Size = new System.Drawing.Size(31, 26);
            this.CstPboxEx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CstPboxEx.TabIndex = 27;
            this.CstPboxEx.TabStop = false;
            this.CstPboxEx.Click += new System.EventHandler(this.CstPboxEx_Click);
            // 
            // btnGnrcPass
            // 
            this.btnGnrcPass.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGnrcPass.FlatAppearance.BorderSize = 0;
            this.btnGnrcPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGnrcPass.Image = ((System.Drawing.Image)(resources.GetObject("btnGnrcPass.Image")));
            this.btnGnrcPass.Location = new System.Drawing.Point(455, 350);
            this.btnGnrcPass.Name = "btnGnrcPass";
            this.btnGnrcPass.Size = new System.Drawing.Size(60, 44);
            this.btnGnrcPass.TabIndex = 29;
            this.btnGnrcPass.UseVisualStyleBackColor = false;
            this.btnGnrcPass.Click += new System.EventHandler(this.BtnGnrcPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 30;
            this.label1.Text = "Yönetici Ekle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(88, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Parola";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(93, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 1);
            this.panel3.TabIndex = 32;
            // 
            // txtPass2
            // 
            this.txtPass2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass2.Enabled = false;
            this.txtPass2.Location = new System.Drawing.Point(93, 439);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.PasswordChar = '*';
            this.txtPass2.Size = new System.Drawing.Size(356, 15);
            this.txtPass2.TabIndex = 31;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.customPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(1210, 12);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(31, 26);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 22;
            this.customPictureBox1.TabStop = false;
            // 
            // AddManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPass2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGnrcPass);
            this.Controls.Add(this.CstBtnAddManager);
            this.Controls.Add(this.CstPboxEx);
            this.Controls.Add(this.listAdmin);
            this.Controls.Add(this.customPictureBox1);
            this.Controls.Add(this.CstbtnDelManager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddManagerFrm";
            this.Text = "AddManagerFrm";
            this.Load += new System.EventHandler(this.AddManagerFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CstPboxEx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton CstbtnDelManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlG;
        private System.Windows.Forms.ListView listAdmin;
        private CustomButton CstBtnAddManager;
        private CustomPictureBox CstPboxEx;
        private System.Windows.Forms.Button btnGnrcPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtPass2;
        private CustomPictureBox customPictureBox1;
    }
}