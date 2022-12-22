namespace Cashierless_Checkout
{
    partial class CheckoutFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutFrm));
            this.scannerBarcode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceWTaxLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTaxLabel = new System.Windows.Forms.Label();
            this.listScanner = new System.Windows.Forms.ListView();
            this.isAvLabel = new System.Windows.Forms.Label();
            this.totalPLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customButton3 = new Cashierless_Checkout.CustomButton();
            this.customButton2 = new Cashierless_Checkout.CustomButton();
            this.customButton1 = new Cashierless_Checkout.CustomButton();
            this.urnEkleBtn = new Cashierless_Checkout.CustomButton();
            this.customPictureBox1 = new Cashierless_Checkout.CustomPictureBox();
            this.odmButton = new Cashierless_Checkout.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.scannerBarcode)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // scannerBarcode
            // 
            this.scannerBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scannerBarcode.Location = new System.Drawing.Point(998, 41);
            this.scannerBarcode.Name = "scannerBarcode";
            this.scannerBarcode.Size = new System.Drawing.Size(508, 347);
            this.scannerBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scannerBarcode.TabIndex = 2;
            this.scannerBarcode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kdv\'siz Fiyat:";
            // 
            // totalPriceWTaxLabel
            // 
            this.totalPriceWTaxLabel.AutoSize = true;
            this.totalPriceWTaxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPriceWTaxLabel.Location = new System.Drawing.Point(145, 678);
            this.totalPriceWTaxLabel.Name = "totalPriceWTaxLabel";
            this.totalPriceWTaxLabel.Size = new System.Drawing.Size(20, 22);
            this.totalPriceWTaxLabel.TabIndex = 8;
            this.totalPriceWTaxLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(91, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kdv:";
            // 
            // totalTaxLabel
            // 
            this.totalTaxLabel.AutoSize = true;
            this.totalTaxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalTaxLabel.Location = new System.Drawing.Point(145, 647);
            this.totalTaxLabel.Name = "totalTaxLabel";
            this.totalTaxLabel.Size = new System.Drawing.Size(20, 22);
            this.totalTaxLabel.TabIndex = 10;
            this.totalTaxLabel.Text = "0";
            // 
            // listScanner
            // 
            this.listScanner.CheckBoxes = true;
            this.listScanner.FullRowSelect = true;
            this.listScanner.GridLines = true;
            this.listScanner.HideSelection = false;
            this.listScanner.Location = new System.Drawing.Point(9, 41);
            this.listScanner.Name = "listScanner";
            this.listScanner.Size = new System.Drawing.Size(983, 510);
            this.listScanner.TabIndex = 3;
            this.listScanner.UseCompatibleStateImageBehavior = false;
            this.listScanner.View = System.Windows.Forms.View.Details;
            this.listScanner.SelectedIndexChanged += new System.EventHandler(this.listScanner_SelectedIndexChanged);
            // 
            // isAvLabel
            // 
            this.isAvLabel.AutoSize = true;
            this.isAvLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.isAvLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isAvLabel.ForeColor = System.Drawing.Color.Green;
            this.isAvLabel.Location = new System.Drawing.Point(821, 557);
            this.isAvLabel.Name = "isAvLabel";
            this.isAvLabel.Size = new System.Drawing.Size(171, 25);
            this.isAvLabel.TabIndex = 14;
            this.isAvLabel.Text = "Okuyucu Durumu";
            // 
            // totalPLabel
            // 
            this.totalPLabel.AutoSize = true;
            this.totalPLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPLabel.Location = new System.Drawing.Point(145, 617);
            this.totalPLabel.Name = "totalPLabel";
            this.totalPLabel.Size = new System.Drawing.Size(20, 22);
            this.totalPLabel.TabIndex = 16;
            this.totalPLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 678);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Toplam Fiyat:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(15, 676);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 2);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBarcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(999, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 72);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBarcode.Location = new System.Drawing.Point(6, 44);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(495, 22);
            this.textBoxBarcode.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Barkod";
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.DodgerBlue;
            this.customButton3.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.BorderRadius = 22;
            this.customButton3.BorderSize = 0;
            this.customButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton3.Image = ((System.Drawing.Image)(resources.GetObject("customButton3.Image")));
            this.customButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.Location = new System.Drawing.Point(998, 473);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(247, 91);
            this.customButton3.TabIndex = 13;
            this.customButton3.Text = "Listeyi Temizle";
            this.customButton3.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.customButton2.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 22;
            this.customButton2.BorderSize = 0;
            this.customButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton2.Image = ((System.Drawing.Image)(resources.GetObject("customButton2.Image")));
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.Location = new System.Drawing.Point(1251, 473);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(255, 91);
            this.customButton2.TabIndex = 12;
            this.customButton2.Text = "Barkod Kodu";
            this.customButton2.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Azure;
            this.customButton1.BackgroundColor = System.Drawing.Color.Azure;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 17;
            this.customButton1.BorderSize = 0;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton1.Location = new System.Drawing.Point(12, 557);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(129, 48);
            this.customButton1.TabIndex = 11;
            this.customButton1.Text = "Sil";
            this.customButton1.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // urnEkleBtn
            // 
            this.urnEkleBtn.BackColor = System.Drawing.Color.Azure;
            this.urnEkleBtn.BackgroundColor = System.Drawing.Color.Azure;
            this.urnEkleBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.urnEkleBtn.BorderRadius = 17;
            this.urnEkleBtn.BorderSize = 0;
            this.urnEkleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urnEkleBtn.FlatAppearance.BorderSize = 0;
            this.urnEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urnEkleBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urnEkleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urnEkleBtn.Location = new System.Drawing.Point(845, 591);
            this.urnEkleBtn.Name = "urnEkleBtn";
            this.urnEkleBtn.Size = new System.Drawing.Size(129, 48);
            this.urnEkleBtn.TabIndex = 6;
            this.urnEkleBtn.Text = "Aktif et";
            this.urnEkleBtn.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urnEkleBtn.UseVisualStyleBackColor = false;
            this.urnEkleBtn.Click += new System.EventHandler(this.urnEkleBtn_Click);
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(1475, 12);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(31, 26);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 4;
            this.customPictureBox1.TabStop = false;
            this.customPictureBox1.Click += new System.EventHandler(this.customPictureBox1_Click);
            // 
            // odmButton
            // 
            this.odmButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.odmButton.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.odmButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.odmButton.BorderRadius = 30;
            this.odmButton.BorderSize = 0;
            this.odmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odmButton.FlatAppearance.BorderSize = 0;
            this.odmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odmButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odmButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odmButton.Location = new System.Drawing.Point(1015, 581);
            this.odmButton.Name = "odmButton";
            this.odmButton.Size = new System.Drawing.Size(491, 89);
            this.odmButton.TabIndex = 1;
            this.odmButton.Text = "Ödeme İslemleri";
            this.odmButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odmButton.UseVisualStyleBackColor = false;
            this.odmButton.Click += new System.EventHandler(this.odmButton_Click);
            // 
            // CheckoutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1518, 707);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalPLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isAvLabel);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.totalTaxLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalPriceWTaxLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urnEkleBtn);
            this.Controls.Add(this.customPictureBox1);
            this.Controls.Add(this.listScanner);
            this.Controls.Add(this.scannerBarcode);
            this.Controls.Add(this.odmButton);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckoutFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutFrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckoutFrm_FormClosed);
            this.Load += new System.EventHandler(this.CheckoutFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scannerBarcode)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomButton odmButton;
        private System.Windows.Forms.PictureBox scannerBarcode;
        private CustomPictureBox customPictureBox1;
        private CustomButton urnEkleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPriceWTaxLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalTaxLabel;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private System.Windows.Forms.ListView listScanner;
        private System.Windows.Forms.Label isAvLabel;
        private System.Windows.Forms.Label totalPLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label2;
    }
}