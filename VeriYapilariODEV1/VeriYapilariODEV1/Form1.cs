using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariODEV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public int DizilimYazdir(object[,] cubuklar, int durum)
        {
            string TotalDizilim = "";

            for (int i = 0; i < 8; i++)
            {
                string dizilim = "";

                for (int j = 0; j < 4; j++)
                {
                    dizilim += (string)cubuklar[i, j];
                }

                TotalDizilim += "S" + (i+1).ToString() + " ---> " +
                                 dizilim + Environment.NewLine;

                if (dizilim == "WWWW")
                {
                    durum = 1;
                }
                else if (dizilim == "GGGG")
                {
                    durum = 2;
                }
            }
            
            rtbAdimlar.Text += "-----------------------" +
                                Environment.NewLine +  TotalDizilim;
            return durum;
        }

        public void KazananKontrol(RichTextBox Adimlar, int durum)
        {
            if (durum == 1)
            {
                Adimlar.Text += Environment.NewLine +
                                   "Kazanan: Beyaz (W)." +
                                   Environment.NewLine;
            }
            else if (durum == 2)
            {
                Adimlar.Text += Environment.NewLine +
                                   "Kazanan: Yeşil (G)." +
                                   Environment.NewLine;
            }
        }

        public void EternasOyununuBaslat()
        {
            Boncuk Beyaz = new Boncuk
            {
                Renk = "W"
            };

            Boncuk Yesil = new Boncuk
            {
                Renk = "G"
            };

            StackEternas Eternas = new StackEternas();

            rtbAdimlar.Clear();
            int durum = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (Eternas.TotalCount < 32 && durum == 0)
                    {
                        Eternas.Push(Beyaz);

                        durum = DizilimYazdir(Eternas.Cubuklar, durum);

                        if (durum != 1)
                        {
                            Eternas.Push(Yesil);

                            durum = DizilimYazdir(Eternas.Cubuklar, durum);
                        }

                        KazananKontrol(rtbAdimlar, durum);
                    }

                    if (Eternas.TotalCount == 32 && durum == 0)
                    {
                        rtbAdimlar.Text += Environment.NewLine +
                                           "Oyun Berabere Sonlandı." +
                                           Environment.NewLine;
                    }
                }
            }
        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            EternasOyununuBaslat();
        }
    }
}
