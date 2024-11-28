namespace ders_92_şehir_tahmin_oyunu_
{
    partial class Form1
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
            this.GrpSoruAlanı = new System.Windows.Forms.GroupBox();
            this.GrpCevapAlanı = new System.Windows.Forms.GroupBox();
            this.LblKalanHak = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGirilenHarf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKelime = new System.Windows.Forms.TextBox();
            this.BtnTahminEt = new System.Windows.Forms.Button();
            this.BtnHarfGir = new System.Windows.Forms.Button();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.BtnYeniOyunBaslat = new System.Windows.Forms.Button();
            this.GrpCevapAlanı.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpSoruAlanı
            // 
            this.GrpSoruAlanı.Location = new System.Drawing.Point(231, 86);
            this.GrpSoruAlanı.Name = "GrpSoruAlanı";
            this.GrpSoruAlanı.Size = new System.Drawing.Size(583, 227);
            this.GrpSoruAlanı.TabIndex = 0;
            this.GrpSoruAlanı.TabStop = false;
            this.GrpSoruAlanı.Text = "Soru Alanı";
            // 
            // GrpCevapAlanı
            // 
            this.GrpCevapAlanı.Controls.Add(this.LblKalanHak);
            this.GrpCevapAlanı.Controls.Add(this.label2);
            this.GrpCevapAlanı.Controls.Add(this.LblGirilenHarf);
            this.GrpCevapAlanı.Controls.Add(this.label1);
            this.GrpCevapAlanı.Controls.Add(this.TxtKelime);
            this.GrpCevapAlanı.Controls.Add(this.BtnTahminEt);
            this.GrpCevapAlanı.Controls.Add(this.BtnHarfGir);
            this.GrpCevapAlanı.Controls.Add(this.txtHarf);
            this.GrpCevapAlanı.Location = new System.Drawing.Point(231, 319);
            this.GrpCevapAlanı.Name = "GrpCevapAlanı";
            this.GrpCevapAlanı.Size = new System.Drawing.Size(583, 225);
            this.GrpCevapAlanı.TabIndex = 1;
            this.GrpCevapAlanı.TabStop = false;
            this.GrpCevapAlanı.Text = "Cevap Alanı";
            // 
            // LblKalanHak
            // 
            this.LblKalanHak.AutoSize = true;
            this.LblKalanHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKalanHak.Location = new System.Drawing.Point(171, 146);
            this.LblKalanHak.Name = "LblKalanHak";
            this.LblKalanHak.Size = new System.Drawing.Size(23, 25);
            this.LblKalanHak.TabIndex = 7;
            this.LblKalanHak.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkMagenta;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kalan Hak:";
            // 
            // LblGirilenHarf
            // 
            this.LblGirilenHarf.AutoSize = true;
            this.LblGirilenHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGirilenHarf.Location = new System.Drawing.Point(171, 107);
            this.LblGirilenHarf.Name = "LblGirilenHarf";
            this.LblGirilenHarf.Size = new System.Drawing.Size(19, 25);
            this.LblGirilenHarf.TabIndex = 5;
            this.LblGirilenHarf.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Girilen Harfler:";
            // 
            // TxtKelime
            // 
            this.TxtKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKelime.Location = new System.Drawing.Point(311, 36);
            this.TxtKelime.Name = "TxtKelime";
            this.TxtKelime.Size = new System.Drawing.Size(135, 26);
            this.TxtKelime.TabIndex = 3;
            // 
            // BtnTahminEt
            // 
            this.BtnTahminEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTahminEt.Location = new System.Drawing.Point(452, 35);
            this.BtnTahminEt.Name = "BtnTahminEt";
            this.BtnTahminEt.Size = new System.Drawing.Size(103, 27);
            this.BtnTahminEt.TabIndex = 2;
            this.BtnTahminEt.Text = "Tahmin Et";
            this.BtnTahminEt.UseVisualStyleBackColor = true;
            this.BtnTahminEt.Click += new System.EventHandler(this.BtnTahminEt_Click);
            // 
            // BtnHarfGir
            // 
            this.BtnHarfGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarfGir.Location = new System.Drawing.Point(156, 36);
            this.BtnHarfGir.Name = "BtnHarfGir";
            this.BtnHarfGir.Size = new System.Drawing.Size(103, 26);
            this.BtnHarfGir.TabIndex = 1;
            this.BtnHarfGir.Text = "Harf Gir";
            this.BtnHarfGir.UseVisualStyleBackColor = true;
            this.BtnHarfGir.Click += new System.EventHandler(this.BtnHarfGir_Click);
            // 
            // txtHarf
            // 
            this.txtHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf.Location = new System.Drawing.Point(15, 36);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(135, 26);
            this.txtHarf.TabIndex = 0;
            // 
            // BtnYeniOyunBaslat
            // 
            this.BtnYeniOyunBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniOyunBaslat.Location = new System.Drawing.Point(234, 31);
            this.BtnYeniOyunBaslat.Name = "BtnYeniOyunBaslat";
            this.BtnYeniOyunBaslat.Size = new System.Drawing.Size(580, 42);
            this.BtnYeniOyunBaslat.TabIndex = 2;
            this.BtnYeniOyunBaslat.Text = "Yeni Oyun Başlat";
            this.BtnYeniOyunBaslat.UseVisualStyleBackColor = true;
            this.BtnYeniOyunBaslat.Click += new System.EventHandler(this.BtnYeniOyunBaslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(1037, 556);
            this.Controls.Add(this.BtnYeniOyunBaslat);
            this.Controls.Add(this.GrpCevapAlanı);
            this.Controls.Add(this.GrpSoruAlanı);
            this.Name = "Form1";
            this.Text = "Oyun Syafası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GrpCevapAlanı.ResumeLayout(false);
            this.GrpCevapAlanı.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpSoruAlanı;
        private System.Windows.Forms.GroupBox GrpCevapAlanı;
        private System.Windows.Forms.Label LblGirilenHarf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKelime;
        private System.Windows.Forms.Button BtnTahminEt;
        private System.Windows.Forms.Button BtnHarfGir;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Button BtnYeniOyunBaslat;
        private System.Windows.Forms.Label LblKalanHak;
        private System.Windows.Forms.Label label2;
    }
}

