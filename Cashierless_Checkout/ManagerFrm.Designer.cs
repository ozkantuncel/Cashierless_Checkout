namespace Cashierless_Checkout
{
    partial class ManagerFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerFrm));
            this.cstbtnUrn = new Cashierless_Checkout.CustomButton();
            this.cstbtnAddMan = new Cashierless_Checkout.CustomButton();
            this.pnlMan = new System.Windows.Forms.Panel();
            this.lblHsg = new System.Windows.Forms.Label();
            this.lnkCks = new System.Windows.Forms.LinkLabel();
            this.pnlMan.SuspendLayout();
            this.SuspendLayout();
            // 
            // cstbtnUrn
            // 
            this.cstbtnUrn.BackColor = System.Drawing.Color.DodgerBlue;
            this.cstbtnUrn.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.cstbtnUrn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cstbtnUrn.BorderRadius = 30;
            this.cstbtnUrn.BorderSize = 0;
            this.cstbtnUrn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cstbtnUrn.FlatAppearance.BorderSize = 0;
            this.cstbtnUrn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cstbtnUrn.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cstbtnUrn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cstbtnUrn.Image = ((System.Drawing.Image)(resources.GetObject("cstbtnUrn.Image")));
            this.cstbtnUrn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cstbtnUrn.Location = new System.Drawing.Point(99, 184);
            this.cstbtnUrn.Name = "cstbtnUrn";
            this.cstbtnUrn.Size = new System.Drawing.Size(274, 181);
            this.cstbtnUrn.TabIndex = 14;
            this.cstbtnUrn.Text = "Ürün Yönetimi  Eski Satışlar";
            this.cstbtnUrn.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cstbtnUrn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cstbtnUrn.UseVisualStyleBackColor = false;
            this.cstbtnUrn.Click += new System.EventHandler(this.cstbtnUrn_Click);
            // 
            // cstbtnAddMan
            // 
            this.cstbtnAddMan.BackColor = System.Drawing.Color.DodgerBlue;
            this.cstbtnAddMan.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.cstbtnAddMan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cstbtnAddMan.BorderRadius = 30;
            this.cstbtnAddMan.BorderSize = 0;
            this.cstbtnAddMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cstbtnAddMan.FlatAppearance.BorderSize = 0;
            this.cstbtnAddMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cstbtnAddMan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cstbtnAddMan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cstbtnAddMan.Image = ((System.Drawing.Image)(resources.GetObject("cstbtnAddMan.Image")));
            this.cstbtnAddMan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cstbtnAddMan.Location = new System.Drawing.Point(453, 184);
            this.cstbtnAddMan.Name = "cstbtnAddMan";
            this.cstbtnAddMan.Size = new System.Drawing.Size(273, 181);
            this.cstbtnAddMan.TabIndex = 15;
            this.cstbtnAddMan.Text = "Yönetici Ekle";
            this.cstbtnAddMan.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cstbtnAddMan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cstbtnAddMan.UseVisualStyleBackColor = false;
            this.cstbtnAddMan.Click += new System.EventHandler(this.cstbtnAddMan_Click);
            // 
            // pnlMan
            // 
            this.pnlMan.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlMan.Controls.Add(this.lnkCks);
            this.pnlMan.Controls.Add(this.lblHsg);
            this.pnlMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMan.Location = new System.Drawing.Point(0, 0);
            this.pnlMan.Name = "pnlMan";
            this.pnlMan.Size = new System.Drawing.Size(800, 116);
            this.pnlMan.TabIndex = 16;
            // 
            // lblHsg
            // 
            this.lblHsg.AutoSize = true;
            this.lblHsg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHsg.Location = new System.Drawing.Point(293, 38);
            this.lblHsg.Name = "lblHsg";
            this.lblHsg.Size = new System.Drawing.Size(235, 34);
            this.lblHsg.TabIndex = 0;
            this.lblHsg.Text = "Hoşgeldiniz admin";
            // 
            // lnkCks
            // 
            this.lnkCks.AutoSize = true;
            this.lnkCks.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkCks.LinkColor = System.Drawing.Color.Black;
            this.lnkCks.Location = new System.Drawing.Point(696, 9);
            this.lnkCks.Name = "lnkCks";
            this.lnkCks.Size = new System.Drawing.Size(72, 19);
            this.lnkCks.TabIndex = 1;
            this.lnkCks.TabStop = true;
            this.lnkCks.Text = "Çıkış Yap";
            this.lnkCks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCks_LinkClicked);
            // 
            // ManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMan);
            this.Controls.Add(this.cstbtnAddMan);
            this.Controls.Add(this.cstbtnUrn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerFrm";
            this.Load += new System.EventHandler(this.ManagerFrm_Load);
            this.pnlMan.ResumeLayout(false);
            this.pnlMan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton cstbtnUrn;
        private CustomButton cstbtnAddMan;
        private System.Windows.Forms.Panel pnlMan;
        private System.Windows.Forms.Label lblHsg;
        private System.Windows.Forms.LinkLabel lnkCks;
    }
}