using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using KelimeEzberleme.Models;
using KelimeEzberleme.Services;


namespace KelimeEzberleme
{
    public partial class AnaForm : Form
    {
        private List<Kelime> yuklenenKelimeler = new List<Kelime>();

        public AnaForm()
        {
            InitializeComponent();
            DosyalariListele();
            btnBaslat.Enabled = false;
        }

        private void DosyalariListele()

        {
            string klasorYolu = Application.StartupPath;
            string[] dosyalar = Directory.GetFiles(klasorYolu, "*.txt");

            cmbSozlukler.Items.Clear();
            foreach (string dosya in dosyalar)
            {
                string dosyaAdi = Path.GetFileName(dosya);
                cmbSozlukler.Items.Add(dosyaAdi);
            }

            if (cmbSozlukler.Items.Count > 0)
            {
                cmbSozlukler.SelectedIndex = 0; //otomatik ilk .txt dosyasýný seçili yap..

            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if (cmbSozlukler.SelectedItem != null)
            {
                string secilenDosyaAdi = cmbSozlukler.SelectedItem.ToString();
                string tamYol = Path.Combine(Application.StartupPath, secilenDosyaAdi);

                yuklenenKelimeler = SozlukYukleyici.Yukle(tamYol);

                if (yuklenenKelimeler.Count > 0)
                {
                    MessageBox.Show($"{yuklenenKelimeler.Count} kelime yüklendi!");
                    btnBaslat.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Dosya boþ ya da uygun formatta deðil.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sözlük seçin.");
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            SoruFormu soruFormu = new SoruFormu(yuklenenKelimeler);
            soruFormu.Show();
            this.Hide();
        }

        // private void btnCikis_Click(object sender, EventArgs e)
        //{
        //    Application.Exit(); // Uygulamayý tamamen kapatýr
        //}
         
        private void listSozlukler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); // Uygulamayý tamamen kapatýr
        }
    }
}