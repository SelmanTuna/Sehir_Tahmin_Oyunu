namespace Şehir_Tahmin_Oyunu
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
            this.GrpOyunAlani = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblKalanHak = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblGirilenHarfler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKelime = new System.Windows.Forms.TextBox();
            this.BtnTahminEt = new System.Windows.Forms.Button();
            this.BtnHarfGir = new System.Windows.Forms.Button();
            this.TxtHarf = new System.Windows.Forms.TextBox();
            this.BtnYeniOyunBaslat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpOyunAlani
            // 
            this.GrpOyunAlani.Location = new System.Drawing.Point(177, 75);
            this.GrpOyunAlani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpOyunAlani.Name = "GrpOyunAlani";
            this.GrpOyunAlani.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GrpOyunAlani.Size = new System.Drawing.Size(543, 172);
            this.GrpOyunAlani.TabIndex = 0;
            this.GrpOyunAlani.TabStop = false;
            this.GrpOyunAlani.Text = "Soru Alanı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblKalanHak);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblGirilenHarfler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtKelime);
            this.groupBox1.Controls.Add(this.BtnTahminEt);
            this.groupBox1.Controls.Add(this.BtnHarfGir);
            this.groupBox1.Controls.Add(this.TxtHarf);
            this.groupBox1.Location = new System.Drawing.Point(177, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(543, 172);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cevap Alanı";
            // 
            // LblKalanHak
            // 
            this.LblKalanHak.AutoSize = true;
            this.LblKalanHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKalanHak.Location = new System.Drawing.Point(101, 122);
            this.LblKalanHak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblKalanHak.Name = "LblKalanHak";
            this.LblKalanHak.Size = new System.Drawing.Size(18, 20);
            this.LblKalanHak.TabIndex = 5;
            this.LblKalanHak.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(8, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kalan Hak:";
            // 
            // LblGirilenHarfler
            // 
            this.LblGirilenHarfler.AutoSize = true;
            this.LblGirilenHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblGirilenHarfler.Location = new System.Drawing.Point(139, 87);
            this.LblGirilenHarfler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblGirilenHarfler.Name = "LblGirilenHarfler";
            this.LblGirilenHarfler.Size = new System.Drawing.Size(0, 20);
            this.LblGirilenHarfler.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Girilen Harfler:";
            // 
            // TxtKelime
            // 
            this.TxtKelime.Location = new System.Drawing.Point(260, 39);
            this.TxtKelime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtKelime.Name = "TxtKelime";
            this.TxtKelime.Size = new System.Drawing.Size(141, 22);
            this.TxtKelime.TabIndex = 3;
            // 
            // BtnTahminEt
            // 
            this.BtnTahminEt.Location = new System.Drawing.Point(411, 38);
            this.BtnTahminEt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnTahminEt.Name = "BtnTahminEt";
            this.BtnTahminEt.Size = new System.Drawing.Size(124, 28);
            this.BtnTahminEt.TabIndex = 2;
            this.BtnTahminEt.Text = "Tahmin Et";
            this.BtnTahminEt.UseVisualStyleBackColor = true;
            this.BtnTahminEt.Click += new System.EventHandler(this.BtnTahminEt_Click);
            // 
            // BtnHarfGir
            // 
            this.BtnHarfGir.Location = new System.Drawing.Point(136, 39);
            this.BtnHarfGir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnHarfGir.Name = "BtnHarfGir";
            this.BtnHarfGir.Size = new System.Drawing.Size(116, 28);
            this.BtnHarfGir.TabIndex = 1;
            this.BtnHarfGir.Text = "Harf Gir";
            this.BtnHarfGir.UseVisualStyleBackColor = true;
            this.BtnHarfGir.Click += new System.EventHandler(this.BtnHarfGir_Click);
            // 
            // TxtHarf
            // 
            this.TxtHarf.Location = new System.Drawing.Point(8, 42);
            this.TxtHarf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtHarf.Name = "TxtHarf";
            this.TxtHarf.Size = new System.Drawing.Size(119, 22);
            this.TxtHarf.TabIndex = 0;
            // 
            // BtnYeniOyunBaslat
            // 
            this.BtnYeniOyunBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniOyunBaslat.Location = new System.Drawing.Point(177, 32);
            this.BtnYeniOyunBaslat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnYeniOyunBaslat.Name = "BtnYeniOyunBaslat";
            this.BtnYeniOyunBaslat.Size = new System.Drawing.Size(543, 36);
            this.BtnYeniOyunBaslat.TabIndex = 2;
            this.BtnYeniOyunBaslat.Text = "Yeni Oyun Baslat";
            this.BtnYeniOyunBaslat.UseVisualStyleBackColor = true;
            this.BtnYeniOyunBaslat.Click += new System.EventHandler(this.BtnYeniOyunBaslat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(888, 502);
            this.Controls.Add(this.BtnYeniOyunBaslat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrpOyunAlani);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Oyun Sayfasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpOyunAlani;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblKalanHak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblGirilenHarfler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtKelime;
        private System.Windows.Forms.Button BtnTahminEt;
        private System.Windows.Forms.Button BtnHarfGir;
        private System.Windows.Forms.TextBox TxtHarf;
        private System.Windows.Forms.Button BtnYeniOyunBaslat;
    }
}

