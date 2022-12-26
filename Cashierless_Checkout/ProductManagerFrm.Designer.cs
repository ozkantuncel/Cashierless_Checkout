namespace Cashierless_Checkout.entity
{
    partial class ProductManagerFrm
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
            System.Windows.Forms.Button BtnExit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagerFrm));
            System.Windows.Forms.Button BtnBack;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnOldSales = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureB = new System.Windows.Forms.PictureBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.customPictureBox1 = new Cashierless_Checkout.CustomPictureBox();
            BtnExit = new System.Windows.Forms.Button();
            BtnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnOldSales);
            this.panel1.Controls.Add(this.btnUrunEkle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 144);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(BtnExit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(701, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(789, 43);
            this.panel4.TabIndex = 55;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = System.Drawing.Color.SeaGreen;
            BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            BtnExit.Location = new System.Drawing.Point(736, 0);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new System.Drawing.Size(53, 43);
            BtnExit.TabIndex = 54;
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnOldSales
            // 
            this.btnOldSales.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOldSales.FlatAppearance.BorderSize = 0;
            this.btnOldSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnOldSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOldSales.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOldSales.Image = ((System.Drawing.Image)(resources.GetObject("btnOldSales.Image")));
            this.btnOldSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOldSales.Location = new System.Drawing.Point(481, 0);
            this.btnOldSales.Name = "btnOldSales";
            this.btnOldSales.Size = new System.Drawing.Size(220, 144);
            this.btnOldSales.TabIndex = 3;
            this.btnOldSales.Text = "Satış Geçmişi";
            this.btnOldSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOldSales.UseVisualStyleBackColor = true;
            this.btnOldSales.Click += new System.EventHandler(this.btnOldSales_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnUrunEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.btnUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunEkle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.Image")));
            this.btnUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunEkle.Location = new System.Drawing.Point(287, 0);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(194, 144);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(BtnBack);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 144);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Yönetimi & Eski Satışlar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.customPictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 656);
            this.panel3.TabIndex = 1;
            // 
            // pictureB
            // 
            this.pictureB.Image = ((System.Drawing.Image)(resources.GetObject("pictureB.Image")));
            this.pictureB.Location = new System.Drawing.Point(411, 211);
            this.pictureB.Name = "pictureB";
            this.pictureB.Size = new System.Drawing.Size(334, 284);
            this.pictureB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureB.TabIndex = 2;
            this.pictureB.TabStop = false;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.pictureB);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(70, 144);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(1420, 656);
            this.pnlUser.TabIndex = 3;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = System.Drawing.Color.SeaGreen;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            BtnBack.Location = new System.Drawing.Point(3, 3);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new System.Drawing.Size(52, 43);
            BtnBack.TabIndex = 56;
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.customPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(983, 12);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(31, 26);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 4;
            this.customPictureBox1.TabStop = false;
            // 
            // ProductManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1490, 800);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManagerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManagerFrm";
            this.Load += new System.EventHandler(this.ProductManagerFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureB)).EndInit();
            this.pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOldSales;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private CustomPictureBox customPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureB;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel panel4;
    }
}