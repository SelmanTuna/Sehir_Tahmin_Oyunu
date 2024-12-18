﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_92_şehir_tahmin_oyunu_
{
    public partial class Form1 : Form
    {
        string[] sehirlistesi = {      "İstanbul", "Ankara", "İzmir", "Adana", "Adıyaman",
                                       "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Antalya",
                                       "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman",
                                       "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur",
                                       "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli",
                                       "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan",
                                       "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane",
                                       "Hakkari", "Hatay", "Iğdır", "Isparta", "Kahramanmaraş",
                                       "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri",
                                       "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli",
                                       "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin",
                                       "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize",
                                       "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şırnak",
                                       "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak",
                                       "Van", "Yalova", "Yozgat", "Zonguldak" };
        string bulunacaksehirismi = "";
        int bulunanharfsayisi = 0;
        int kalanhak = 4;
        Random rastgele;


        public Form1()
        {
            InitializeComponent();
        }

        private void BtnYeniOyunBaslat_Click(object sender, EventArgs e)
        {
            bulunanharfsayisi = 0;
            BtnHarfGir.Enabled = true;
            BtnTahminEt.Enabled = true;
            LblGirilenHarf.Text = "";
            kalanhak = 4;
            YeniSehirSec();

            GrpSoruAlanı.Controls.Clear();

            for(int i = 0; i < bulunacaksehirismi.Length; i++)
            {
                Label label = new Label();
                label.Location = new Point(20 * i + 30, 20);
                label.Text = bulunacaksehirismi[i].ToString();
                label.Font = new System.Drawing.Font("Calibri", 8.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label.Size = new System.Drawing.Size(15, 20);
                label.BackColor = Color.Red;
                label.ForeColor = Color.Red;
                GrpSoruAlanı.Controls.Add(label);

            }
        }

        private void BtnHarfGir_Click(object sender, EventArgs e)
        {
            bool harfVarmi = false;
            if(txtHarf.Text.Length != 1)
            {
                MessageBox.Show("Lütfen Tek Harf Giriniz");
            }
            else
            {
                if (LblGirilenHarf.Text.Contains(txtHarf.Text))
                {
                    MessageBox.Show("Bu harfi daha önce girmiştiniz");
                    txtHarf.Text = "";
                    txtHarf.Focus();

                    return;
                }
                foreach(Control item in GrpSoruAlanı.Controls)
                {
                    if(item is Label)
                    {
                        Label label = item as Label;
                        if (label.Text.ToUpper() == txtHarf.Text.ToUpper())
                        {
                            label.ForeColor = Color.Black;
                            label.BackColor = Color.Lime;
                            harfVarmi = true;
                            bulunanharfsayisi++;

                        }
                    }
                }
            }
            if (!harfVarmi)
            {
                kalanhak--;
                LblKalanHak.Text = kalanhak.ToString();
                if (kalanhak == 0)
                {
                    BtnHarfGir.Enabled = false;
                    BtnTahminEt.Enabled = false;
                    MessageBox.Show("Oyun Bitti.Yeni Oyun Butonuna Tıklayın " + bulunacaksehirismi);
                }
            }
            LblGirilenHarf.Text += txtHarf.Text + "";
            if (bulunanharfsayisi == bulunacaksehirismi.Length)
            {
                BtnHarfGir.Enabled = false;
                BtnTahminEt.Enabled = false;
                MessageBox.Show("Oyun Bitti.Tebrikler Oyunu Kazandınız");
            }
            txtHarf.Text = "";
            txtHarf.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnHarfGir.Enabled = false;
            BtnTahminEt.Enabled = false;
            rastgele = new Random();

            this.AcceptButton = BtnHarfGir;

        }
        private void YeniSehirSec()
        {
            int rastgelesayi = rastgele.Next(0, sehirlistesi.Length);
            bulunacaksehirismi = sehirlistesi[rastgelesayi];

        }

        private void BtnTahminEt_Click(object sender, EventArgs e)
        {
            if (bulunacaksehirismi.ToUpper() == TxtKelime.Text.ToUpper())
            {
                foreach(Control item in GrpSoruAlanı.Controls)
                {
                    if(item is Label)
                    {
                        Label label = item as Label;
                        label.ForeColor = Color.Black;
                        label.BackColor = Color.Lime;

                    }

                }
                MessageBox.Show("Oyun Bitti Tebrikler Kazandınız");
            }
            else
            {
                MessageBox.Show("Oyun Bitti Malesef Kaybettiniz    "+bulunacaksehirismi);
            }
            BtnHarfGir.Enabled = false;
            BtnTahminEt.Enabled = false;

        }
    }
}
