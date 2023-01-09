namespace Cashierless_Checkout
{
    partial class PaymentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentFrm));
            this.lblTotalP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictrboxQR = new System.Windows.Forms.PictureBox();
            this.countDownLbl = new System.Windows.Forms.Label();
            this.cBtnCancel = new Cashierless_Checkout.CustomButton();
            this.countDownT = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictrboxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalP
            // 
            this.lblTotalP.AutoSize = true;
            this.lblTotalP.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalP.Location = new System.Drawing.Point(205, 62);
            this.lblTotalP.Name = "lblTotalP";
            this.lblTotalP.Size = new System.Drawing.Size(106, 50);
            this.lblTotalP.TabIndex = 0;
            this.lblTotalP.Text = "0.0 tl";
            this.lblTotalP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(161, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Fiyat";
            // 
            // pictrboxQR
            // 
            this.pictrboxQR.Location = new System.Drawing.Point(91, 138);
            this.pictrboxQR.Name = "pictrboxQR";
            this.pictrboxQR.Size = new System.Drawing.Size(339, 299);
            this.pictrboxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictrboxQR.TabIndex = 2;
            this.pictrboxQR.TabStop = false;
            // 
            // countDownLbl
            // 
            this.countDownLbl.AutoSize = true;
            this.countDownLbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countDownLbl.Location = new System.Drawing.Point(243, 458);
            this.countDownLbl.Name = "countDownLbl";
            this.countDownLbl.Size = new System.Drawing.Size(43, 33);
            this.countDownLbl.TabIndex = 15;
            this.countDownLbl.Text = "00";
            // 
            // cBtnCancel
            // 
            this.cBtnCancel.BackColor = System.Drawing.Color.Tomato;
            this.cBtnCancel.BackgroundColor = System.Drawing.Color.Tomato;
            this.cBtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cBtnCancel.BorderRadius = 22;
            this.cBtnCancel.BorderSize = 0;
            this.cBtnCancel.FlatAppearance.BorderSize = 0;
            this.cBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBtnCancel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBtnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cBtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cBtnCancel.Location = new System.Drawing.Point(153, 569);
            this.cBtnCancel.Name = "cBtnCancel";
            this.cBtnCancel.Size = new System.Drawing.Size(215, 84);
            this.cBtnCancel.TabIndex = 14;
            this.cBtnCancel.Text = "İptal";
            this.cBtnCancel.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cBtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBtnCancel.UseVisualStyleBackColor = false;
            this.cBtnCancel.Click += new System.EventHandler(this.cBtnCancel_Click);
            // 
            // countDownT
            // 
            this.countDownT.Tick += new System.EventHandler(this.CountDownTick);
            // 
            // PaymentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(521, 665);
            this.Controls.Add(this.countDownLbl);
            this.Controls.Add(this.cBtnCancel);
            this.Controls.Add(this.pictrboxQR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalP);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentFrm";
            this.Load += new System.EventHandler(this.PaymentFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictrboxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictrboxQR;
        private CustomButton cBtnCancel;
        private System.Windows.Forms.Label countDownLbl;
        private System.Windows.Forms.Timer countDownT;
    }
}