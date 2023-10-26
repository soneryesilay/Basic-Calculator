using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeHesapMakinesi
{
    public partial class FrmHesapMakinesi : Form
    {
        int secim = 0;
        double sayi1,sayi2,sonuc;


        public FrmHesapMakinesi()
        {
            InitializeComponent();
        }

        private void FrmHesapMakinesi_Load(object sender, EventArgs e)
        {

        }


        private void Butonlar(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == "0")
            {
                TxtDisplay.Text = "";
            }

            TxtDisplay.Text = TxtDisplay.Text + ((Button)sender).Text;

        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(TxtDisplay.Text);
            secim = 1;
            TxtDisplay.Text = "0";
        }

        private void BtnCıkar_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(TxtDisplay.Text);
            secim = 2;
            TxtDisplay.Text = "0";
        }

        private void BtnCarp_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(TxtDisplay.Text);
            secim = 3;
            TxtDisplay.Text = "0";
        }

        private void BtnBol_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(TxtDisplay.Text);
            secim = 4;
            TxtDisplay.Text = "0";
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(TxtDisplay.Text);

            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
            }
            else if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
            }
            else if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
            }
            else if (secim == 4)
            {
                // 0 a bölünme hatası
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    MessageBox.Show("Sıfıra Bölünemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtDisplay.Text = "0";
                    return;
                }
            }

            TxtDisplay.Text = sonuc.ToString();
        }


        private void BtnVirgul_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.IndexOf(",")<1)
            {
                TxtDisplay.Text += ",";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text != "0")
            {
                if (TxtDisplay.Text.StartsWith("-"))
                {
                    TxtDisplay.Text = TxtDisplay.Text.Replace("-", "");
                }
                else
                {
                    TxtDisplay.Text = "-" + TxtDisplay.Text;
                }
            }
        }


        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text.Substring(0, TxtDisplay.Text.Length-1);
           
            if(TxtDisplay.Text == "")
            {
                TxtDisplay.Text = "0";
            }
        }
    }
}
