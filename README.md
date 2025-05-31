# Kelime Ezberleme Uygulaması

Bu proje, **Nesneye Dayalı Programlama (NDP)** dersi kapsamında geliştirilmiş bir C# Windows Forms uygulamasıdır.  
Amacı, kullanıcıların yabancı dil kelimelerini eğlenceli ve etkili bir şekilde ezberlemesine yardımcı olmaktır.

## 📚 Uygulama Hakkında

Uygulama, çalışma dizininde (.exe dosyasının yanında) bulunan tüm `.txt` dosyalarını otomatik olarak tarar ve listeler.  
Kullanıcı listeden bir sözlük seçip yükledikten sonra, seçilen sözlük kullanılarak bir kelime ezberleme oturumu başlatılır.

### 📝 Sözlük Formatı
Sözlük dosyalarının her satırında bir kelime ve anlamı tab (`\t`) karakteri ile ayrılmış olarak yer alır.

Örnek:
computer bilgisayar
keyboard klavye
mobile phone cep telefonu
cable kablo
button düğme
assignment ödev

markdown
Kopyala
Düzenle

### 🧩 Uygulama Özellikleri

- 📄 Çalışma dizinindeki tüm `.txt` sözlük dosyalarını listeler.
- 📚 Sözlük seçimi ve yükleme işlemi.
- 🏁 "Başlat" butonu ile kelime ezberleme oturumu başlatma.
- 🎯 Çoktan seçmeli test formatında sorular:
  - 1 doğru + 3 yanlış seçenek.
  - Doğru cevapta 10 puan.
  - Yanlış cevap seçilirse buton kırmızıya döner.
  - Yanlış cevap sonrası doğru cevap seçilse bile puan verilmez.
- 🧠 Puan, toplam kelime sayısı ve oturum ilerleme takibi.
- 💡 Kullanıcı dostu grafik arayüz.

### 🖥️ Ekran Görüntüleri

(Açıklayıcı ekran görüntüleri eklersen çok daha iyi olur!)

### 🚀 Nasıl Çalıştırılır?

1. `.exe` dosyasının yanına sözlük `.txt` dosyalarını yerleştirin.
2. Uygulamayı çalıştırın.
3. Listelenen sözlüklerden birini seçin ve yükleyin.
4. "Başlat" butonuna tıklayarak kelime ezber oturumuna başlayın.

### 📦 Proje Dosya Yapısı
KelimeEzberleme/
├── AnaForm.cs
├── AnaForm.Designer.cs
├── Program.cs
├── SoruFormu.cs
├── Models/
│ └── Kelime.cs
├── KelimeEzberleme.sln
└── README.md

yaml
Kopyala
Düzenle

### 🧑‍💻 Geliştirici
- **Murat Balım**  
Bilgisayar Mühendisliği 2. sınıf öğrencisi.

### 🔒 Uyarılar
- 📜 Bu proje bireysel bir ödevdir. Kod paylaşımı ve kopya yasaktır.
- ⏳ Ödevlerin zamanında teslim edilmesi gerekmektedir.

---

> **Not**: Proje kapsamında kendi sözlük dosyalarınızı oluşturabilir ve uygulamayı daha ileri seviyeye taşıyacak modüller geliştirebilirsiniz.