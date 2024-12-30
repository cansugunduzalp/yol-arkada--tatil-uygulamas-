using System;

class TatilPlanlama
{
    static void Main()
    {
        bool devamEt = true;

        while (devamEt)
        {
            // 1. Lokasyon Seçimi
            Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu giriniz (Bodrum, Marmaris, Çeşme):");
            string lokasyon = Console.ReadLine().ToLower(); // Kullanıcıdan gelen veriyi küçük harfe dönüştürerek alıyoruz.

            // Lokasyon kontrolü
            while (lokasyon != "bodrum" && lokasyon != "marmaris" && lokasyon != "çeşme")
            {
                Console.WriteLine("Geçersiz bir lokasyon girdiniz. Lütfen Bodrum, Marmaris ya da Çeşme'den birini giriniz.");
                lokasyon = Console.ReadLine().ToLower(); // Tekrar kullanıcıdan veri alıyoruz.
            }

            // 2. Kişi Sayısını Alma
            Console.WriteLine("Kaç kişi için tatil planlıyorsunuz?");
            int kisiSayisi;
            while (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir kişi sayısı giriniz (pozitif sayı).");
            }

            // 3. Lokasyon Özeti
            int paketFiyati = 0;
            string lokasyonOzeti = "";

            if (lokasyon == "bodrum")
            {
                paketFiyati = 4000;
                lokasyonOzeti = "Bodrum'da deniz, plaj, gece hayatı ve tarihi mekanları keşfedin.";
            }
            else if (lokasyon == "marmaris")
            {
                paketFiyati = 3000;
                lokasyonOzeti = "Marmaris'te doğal güzellikler, yat turları ve eğlenceli aktiviteler sizi bekliyor.";
            }
            else if (lokasyon == "çeşme")
            {
                paketFiyati = 5000;
                lokasyonOzeti = "Çeşme'de plajlar, termal oteller ve eşsiz Akdeniz manzarası keyifli bir tatil sunuyor.";
            }

            Console.WriteLine($"Seçtiğiniz lokasyon: {lokasyon} - {lokasyonOzeti}");

            // 4. Ulaşım Aracı Seçimi
            Console.WriteLine("Ulaşım şeklinizi seçiniz:");
            Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
            Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)");

            int ulasimSecimi;
            while (!int.TryParse(Console.ReadLine(), out ulasimSecimi) || (ulasimSecimi != 1 && ulasimSecimi != 2))
            {
                Console.WriteLine("Geçersiz bir seçenek girdiniz. Lütfen 1 ya da 2'yi seçiniz.");
            }

            int ulasimFiyati = (ulasimSecimi == 1) ? 1500 : 4000;

            // 5. Toplam Fiyat Hesaplama
            int toplamFiyat = paketFiyati + (ulasimFiyati * kisiSayisi);

            Console.WriteLine($"Toplam Tatil Fiyatı: {toplamFiyat} TL ({kisiSayisi} kişi için, {lokasyon} lokasyonunda, {ulasimSecimi == 1 ? "kara yolu" : "hava yolu"} ulaşımıyla).");

            // 6. Yeni bir tatil planı yapmak isteyip istemediğini sorma
            Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet için 'E', Hayır için 'H' tuşlayın):");
            string devam = Console.ReadLine().ToUpper();

            if (devam != "E")
            {
                devamEt = false;
                Console.WriteLine("İyi günler dileriz!");
            }
        }
    }
}
