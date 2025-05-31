using KelimeEzberleme.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KelimeEzberleme
{



    public partial class SoruFormu : Form
    {
        private List<Kelime> kelimeler;
        private int soruIndex = 0;
        private int puan = 0;
        private bool cevapVerildi = false;
        private Kelime aktifKelime;
        private List<Button> secenekButonlari;

        private Kelime aktifSoru;
        private Random rnd = new Random();

        private int dogruSayisi = 0;
        private int yanlisSayisi = 0;


        public SoruFormu(List<Kelime> gelenKelimeler)
        {
            InitializeComponent();
            kelimeler = gelenKelimeler;
            secenekButonlari = new List<Button> { btnSecenek1, btnSecenek2, btnSecenek3, btnSecenek4 };

            // Seçenek butonlarına tıklama olaylarını bağla
            foreach (var btn in secenekButonlari)
            {
                btn.Click += SecenekTiklandi;
            }

            SoruGoster();



        }

        private void SoruGoster()
        {
            if (soruIndex >= kelimeler.Count)
            {
                MessageBox.Show(
                    $"Tüm sorular bitti!\n\n" +
                    $"Toplam Puan: {puan}\n" +
                    $"Doğru Cevaplar: {dogruSayisi}\n" +
                    $"Yanlış Cevaplar: {yanlisSayisi}"
                );
                this.Close();
                return;
            }

            aktifSoru = kelimeler[soruIndex];
            lblSoru.Text = aktifSoru.Ingilizce;
            lblSoruNo.Text = $"Soru: {soruIndex + 1} / {kelimeler.Count}";
            lblPuan.Text = $"Puan: {puan}";

            List<string> secenekler = new List<string> { aktifSoru.Turkce };

            while (secenekler.Count < 4)
            {
                var rastgele = kelimeler[rnd.Next(kelimeler.Count)].Turkce;
                if (!secenekler.Contains(rastgele))
                {
                    secenekler.Add(rastgele);
                }
            }

            secenekler = secenekler.OrderBy(x => rnd.Next()).ToList();

            for (int i = 0; i < 4; i++)
            {
                secenekButonlari[i].Text = secenekler[i];
                secenekButonlari[i].Enabled = true;
                secenekButonlari[i].BackColor = SystemColors.Control;


            }

            cevapVerildi = false;

        }

        private async void SecenekTiklandi(object sender, EventArgs e)
        {
            if (cevapVerildi) return;

            Button tiklanan = sender as Button;
            cevapVerildi = true;

            if (tiklanan.Text == aktifSoru.Turkce)
            {

                tiklanan.BackColor = Color.Green;
                puan += 10;
                dogruSayisi++;
            }
            else
            {
                tiklanan.BackColor = Color.Red;
                yanlisSayisi++;
                //Doğru seçeneği yeşil yap
                foreach (var btn in secenekButonlari)
                {
                    if (btn.Text == aktifSoru.Turkce)
                    {
                        btn.BackColor = Color.Green;
                    }
                }
            }

            lblPuan.Text = $"Puan: {puan}";
            lblDogruYanlis.Text = $"D:{dogruSayisi} / Y:{yanlisSayisi}";

            //Tüm butonları pasifleştir
            foreach (var btn in secenekButonlari)
            {
                btn.Enabled = false;
            }

            // Bekle ve yeni soruya geç
            await Task.Delay(700);

            soruIndex++;
            SoruGoster();

        }





        private void lblSoruNo_Click(object sender, EventArgs e)
        {

        }

        private void lblPuan_Click(object sender, EventArgs e)
        {

        }

        private void lblSoru_Click(object sender, EventArgs e)
        {

        }

        private void btnSecenek1_Click(object sender, EventArgs e)
        {

        }

        private void btnSecenek2_Click(object sender, EventArgs e)
        {

        }

        private void btnSecenek3_Click(object sender, EventArgs e)
        {

        }

        private void btnSecenek4_Click(object sender, EventArgs e)
        {

        }

        private void lblDogruYanlis_Click(object sender, EventArgs e)
        {

        }

        private void SoruFormu_Load(object sender, EventArgs e)
        {

        }

        private void SoruFormu_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaForm anaForm = new AnaForm(); // Yeni AnaForm oluştur
            anaForm.Show(); // AnaForm'u aç
        }
    }
}
