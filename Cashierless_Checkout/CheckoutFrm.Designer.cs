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
            this.odmButton = new Cashierless_Checkout.CustomButton();
            this.scannerBarcode = new System.Windows.Forms.PictureBox();
            this.customPictureBox1 = new Cashierless_Checkout.CustomPictureBox();
            this.urnEkleBtn = new Cashierless_Checkout.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalTaxLabel = new System.Windows.Forms.Label();
            this.customButton1 = new Cashierless_Checkout.CustomButton();
            this.customButton2 = new Cashierless_Checkout.CustomButton();
            this.customButton3 = new Cashierless_Checkout.CustomButton();
            this.listScanner = new System.Windows.Forms.ListView();
            this.isAvLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scannerBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // odmButton
            // 
            this.odmButton.BackColor = System.Drawing.Color.SteelBlue;
            this.odmButton.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.odmButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.odmButton.BorderRadius = 30;
            this.odmButton.BorderSize = 0;
            this.odmButton.FlatAppearance.BorderSize = 0;
            this.odmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odmButton.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.odmButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odmButton.Location = new System.Drawing.Point(776, 462);
            this.odmButton.Name = "odmButton";
            this.odmButton.Size = new System.Drawing.Size(517, 89);
            this.odmButton.TabIndex = 1;
            this.odmButton.Text = "Ödeme İslemleri";
            this.odmButton.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odmButton.UseVisualStyleBackColor = false;
            this.odmButton.Click += new System.EventHandler(this.odmButton_Click);
            // 
            // scannerBarcode
            // 
            this.scannerBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scannerBarcode.Location = new System.Drawing.Point(12, 26);
            this.scannerBarcode.Name = "scannerBarcode";
            this.scannerBarcode.Size = new System.Drawing.Size(361, 255);
            this.scannerBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scannerBarcode.TabIndex = 2;
            this.scannerBarcode.TabStop = false;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.customPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("customPictureBox1.Image")));
            this.customPictureBox1.Location = new System.Drawing.Point(1262, 12);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(31, 26);
            this.customPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customPictureBox1.TabIndex = 4;
            this.customPictureBox1.TabStop = false;
            // 
            // urnEkleBtn
            // 
            this.urnEkleBtn.BackColor = System.Drawing.Color.Azure;
            this.urnEkleBtn.BackgroundColor = System.Drawing.Color.Azure;
            this.urnEkleBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.urnEkleBtn.BorderRadius = 17;
            this.urnEkleBtn.BorderSize = 0;
            this.urnEkleBtn.FlatAppearance.BorderSize = 0;
            this.urnEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urnEkleBtn.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urnEkleBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urnEkleBtn.Location = new System.Drawing.Point(12, 558);
            this.urnEkleBtn.Name = "urnEkleBtn";
            this.urnEkleBtn.Size = new System.Drawing.Size(125, 48);
            this.urnEkleBtn.TabIndex = 6;
            this.urnEkleBtn.Text = "Ekle";
            this.urnEkleBtn.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urnEkleBtn.UseVisualStyleBackColor = false;
            this.urnEkleBtn.Click += new System.EventHandler(this.urnEkleBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(613, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplam Fiyat:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPriceLabel.Location = new System.Drawing.Point(740, 554);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(20, 22);
            this.totalPriceLabel.TabIndex = 8;
            this.totalPriceLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(613, 584);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Toplam Vergi:";
            // 
            // totalTaxLabel
            // 
            this.totalTaxLabel.AutoSize = true;
            this.totalTaxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalTaxLabel.Location = new System.Drawing.Point(740, 584);
            this.totalTaxLabel.Name = "totalTaxLabel";
            this.totalTaxLabel.Size = new System.Drawing.Size(20, 22);
            this.totalTaxLabel.TabIndex = 10;
            this.totalTaxLabel.Text = "0";
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Azure;
            this.customButton1.BackgroundColor = System.Drawing.Color.Azure;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 17;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton1.Location = new System.Drawing.Point(143, 558);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(125, 48);
            this.customButton1.TabIndex = 11;
            this.customButton1.Text = "Sil";
            this.customButton1.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.SteelBlue;
            this.customButton2.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 22;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton2.Image = ((System.Drawing.Image)(resources.GetObject("customButton2.Image")));
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.Location = new System.Drawing.Point(1154, 365);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(140, 91);
            this.customButton2.TabIndex = 12;
            this.customButton2.Text = "Kod";
            this.customButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton2.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.SteelBlue;
            this.customButton3.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.BorderRadius = 22;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton3.Image = ((System.Drawing.Image)(resources.GetObject("customButton3.Image")));
            this.customButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.Location = new System.Drawing.Point(776, 365);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(166, 91);
            this.customButton3.TabIndex = 13;
            this.customButton3.Text = "Sıfırla";
            this.customButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customButton3.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // listScanner
            // 
            this.listScanner.FullRowSelect = true;
            this.listScanner.GridLines = true;
            this.listScanner.HideSelection = false;
            this.listScanner.Location = new System.Drawing.Point(11, 297);
            this.listScanner.Name = "listScanner";
            this.listScanner.Size = new System.Drawing.Size(759, 254);
            this.listScanner.TabIndex = 3;
            this.listScanner.UseCompatibleStateImageBehavior = false;
            this.listScanner.View = System.Windows.Forms.View.Details;
            // 
            // isAvLabel
            // 
            this.isAvLabel.AutoSize = true;
            this.isAvLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.isAvLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isAvLabel.ForeColor = System.Drawing.Color.Green;
            this.isAvLabel.Location = new System.Drawing.Point(391, 26);
            this.isAvLabel.Name = "isAvLabel";
            this.isAvLabel.Size = new System.Drawing.Size(141, 22);
            this.isAvLabel.TabIndex = 14;
            this.isAvLabel.Text = "Barkod Okuyucu";
            // 
            // CheckoutFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1305, 641);
            this.Controls.Add(this.isAvLabel);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.totalTaxLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urnEkleBtn);
            this.Controls.Add(this.customPictureBox1);
            this.Controls.Add(this.listScanner);
            this.Controls.Add(this.scannerBarcode);
            this.Controls.Add(this.odmButton);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckoutFrm";
            this.Text = "CheckoutFrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckoutFrm_FormClosed);
            this.Load += new System.EventHandler(this.CheckoutFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scannerBarcode)).EndInit();
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
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalTaxLabel;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private System.Windows.Forms.ListView listScanner;
        private System.Windows.Forms.Label isAvLabel;
    }
}