namespace Cashierless_Checkout
{
    partial class OldSales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListOldSales = new System.Windows.Forms.ListView();
            this.Barkod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ürün = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Üretici = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vergi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Satis_zamani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CstbtnReport = new Cashierless_Checkout.CustomButton();
            this.SuspendLayout();
            // 
            // ListOldSales
            // 
            this.ListOldSales.BackColor = System.Drawing.SystemColors.Window;
            this.ListOldSales.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Barkod,
            this.Ürün,
            this.Üretici,
            this.Kategori,
            this.Fiyat,
            this.Vergi,
            this.Satis_zamani});
            this.ListOldSales.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListOldSales.FullRowSelect = true;
            this.ListOldSales.GridLines = true;
            this.ListOldSales.HideSelection = false;
            this.ListOldSales.Location = new System.Drawing.Point(25, 27);
            this.ListOldSales.Name = "ListOldSales";
            this.ListOldSales.Size = new System.Drawing.Size(1376, 508);
            this.ListOldSales.TabIndex = 55;
            this.ListOldSales.UseCompatibleStateImageBehavior = false;
            this.ListOldSales.View = System.Windows.Forms.View.Details;
            // 
            // Barkod
            // 
            this.Barkod.Text = "Barkod";
            this.Barkod.Width = 175;
            // 
            // Ürün
            // 
            this.Ürün.Text = "Ürün";
            this.Ürün.Width = 200;
            // 
            // Üretici
            // 
            this.Üretici.Text = "Üretici";
            this.Üretici.Width = 200;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            this.Kategori.Width = 125;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.Width = 85;
            // 
            // Vergi
            // 
            this.Vergi.Text = "Vergi";
            this.Vergi.Width = 85;
            // 
            // Satis_zamani
            // 
            this.Satis_zamani.Text = "Satış Zamanı";
            this.Satis_zamani.Width = 130;
            // 
            // CstbtnReport
            // 
            this.CstbtnReport.BackColor = System.Drawing.Color.White;
            this.CstbtnReport.BackgroundColor = System.Drawing.Color.White;
            this.CstbtnReport.BorderColor = System.Drawing.Color.Black;
            this.CstbtnReport.BorderRadius = 30;
            this.CstbtnReport.BorderSize = 1;
            this.CstbtnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CstbtnReport.FlatAppearance.BorderSize = 0;
            this.CstbtnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CstbtnReport.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CstbtnReport.ForeColor = System.Drawing.Color.Black;
            this.CstbtnReport.Location = new System.Drawing.Point(598, 541);
            this.CstbtnReport.Name = "CstbtnReport";
            this.CstbtnReport.Size = new System.Drawing.Size(198, 72);
            this.CstbtnReport.TabIndex = 56;
            this.CstbtnReport.Text = "Rapor oluştur";
            this.CstbtnReport.TextColor = System.Drawing.Color.Black;
            this.CstbtnReport.UseVisualStyleBackColor = false;
            this.CstbtnReport.Click += new System.EventHandler(this.CstbtnReport_Click);
            // 
            // OldSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.CstbtnReport);
            this.Controls.Add(this.ListOldSales);
            this.Name = "OldSales";
            this.Size = new System.Drawing.Size(1421, 657);
            this.Load += new System.EventHandler(this.OldSales_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListOldSales;
        private System.Windows.Forms.ColumnHeader Barkod;
        private System.Windows.Forms.ColumnHeader Ürün;
        private System.Windows.Forms.ColumnHeader Üretici;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ColumnHeader Vergi;
        private System.Windows.Forms.ColumnHeader Satis_zamani;
        private CustomButton CstbtnReport;
    }
}
