namespace Otomat_Makinesi_Odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Müşteri Daha önceden tanımlanmış bir ürün listesinden bir ürün seçecek. 
        Para girişi yapacak.Girilen para seçilen ürünün fiyatını karşılar ise ürün alındı, aksi durumda para ekle seçeneği ile tekrar para girmesi sağlanacak.

         // Admin => Ürün Ekleyecek, Ürün Silecek, Fiyat Güncelleyecek
         */


            string[] icecekler = new string[] { "Admin", "Su", "Soda", "Kola", "Fanta", "Ayran", "Meyve Suyu" };
            int[] fiyatlar = new int[] { 0, 10, 15, 30, 30, 20, 25 };

            while (true)
            {
                Console.WriteLine("Hoş Geldiniz. Lütfen Almak İstediğiniz Ürün İçin Tuşlama Yapınız.");
                int i = 1;
                while (i < icecekler.Length)
                {
                    Console.WriteLine($"{i} - {icecekler[i]} - {fiyatlar[i]} tl");
                    i++;
                }
                try
                {
                    int tuslama = Convert.ToInt32(Console.ReadLine());

                    if (tuslama >= 1 && tuslama < icecekler.Length)
                    {
                        int urunFiyati = fiyatlar[tuslama];
                        Console.WriteLine("Lütfen Parayı Yatırınız");
                        int para = Convert.ToInt32(Console.ReadLine());
                        while (para < urunFiyati)
                        {
                            Console.WriteLine("Yetersiz Bakiye. Para Eklemek İçin 1'i, Paranızı Geri Almak İçin 2'yi Tuşlayınız..");
                            int secenek = Convert.ToInt32(Console.ReadLine());
                            if (secenek == 1)
                            {
                                Console.WriteLine("Eklenecek Miktarı Girin");
                                int eklenenPara = Convert.ToInt32(Console.ReadLine());
                                para += eklenenPara;
                            }
                            else if (secenek == 2)
                            {
                                Console.WriteLine("Para İade Edildi.");
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                            }
                        }
                        if (para >= urunFiyati)
                        {
                            int paraUstu = para - urunFiyati;
                            Console.WriteLine("Ürününüz Hazır. Para Üstünüz:" + paraUstu);
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                        }



                    }

                    else if (tuslama == 0)
                    {
                        int sifre = 1234;
                        int hak = 3;
                        bool girisBasarili = false;
                        while (hak > 0)
                        {
                            Console.WriteLine("Şifre Giriniz:");
                            int girilenSifre = Convert.ToInt32(Console.ReadLine());

                            if (girilenSifre == sifre)
                            {
                                Console.WriteLine("Giriş Başarılı");
                                girisBasarili = true;
                                break;
                            }
                            else
                            {
                                hak--;
                                Console.WriteLine($"Hatalı Şifre Girdiniz.Kalan Hakkınız: {hak}");
                                if (hak == 0)
                                {
                                    Console.WriteLine("Şifre Deneme Hakkınız Kalmadı!");
                                    Environment.Exit(0);
                                }
                            }

                        }
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("1- Ürün Ekle \n 2- Ürün Sil \n 3-Fiyat Güncelle \n 4-Çıkış");
                            int secim = Convert.ToInt32(Console.ReadLine());
                            if (secim == 1)
                            {
                                Console.WriteLine("Eklenecek Ürün:");
                                string urun = Console.ReadLine();
                                Array.Resize(ref icecekler, icecekler.Length + 1);
                                icecekler[icecekler.Length - 1] = urun;
                                Console.WriteLine("Ürünün Fiyatı:");
                                int fiyat = Convert.ToInt32(Console.ReadLine());
                                Array.Resize(ref fiyatlar, fiyatlar.Length + 1);
                                fiyatlar[fiyatlar.Length - 1] = fiyat;
                                Console.WriteLine("Ürün Başarıyla Eklendi.");
                                Console.WriteLine("Yeni Ürün Listesi:");
                                i = 1;
                                while (i < icecekler.Length)
                                {
                                    Console.WriteLine($"{i} - {icecekler[i]} - {fiyatlar[i]} tl");
                                    i++;
                                }
                                Thread.Sleep(3000);
                                Console.Clear();

                            }
                            else if (secim == 2)
                            {
                                Console.WriteLine("Silmek İstediğiniz Ürünü Seçiniz");

                                i = 1;
                                while (i < icecekler.Length)
                                {
                                    Console.WriteLine($"{i} - {icecekler[i]} - {fiyatlar[i]} tl");
                                    i++;
                                }

                                int silinecekUrun = Convert.ToInt32(Console.ReadLine());
                                if (silinecekUrun >= 1 && silinecekUrun < icecekler.Length)
                                {
                                    List<string> yeniIcecekler = icecekler.ToList();
                                    List<int> yeniFiyatlar = fiyatlar.ToList();
                                    yeniIcecekler.RemoveAt(silinecekUrun);
                                    yeniFiyatlar.RemoveAt(silinecekUrun);
                                    icecekler = yeniIcecekler.ToArray();
                                    fiyatlar = yeniFiyatlar.ToArray();
                                    Console.WriteLine("Ürün Başarıyla Silindi.");
                                    Thread.Sleep(2000);
                                    Console.Clear();

                                    i = 1;
                                    Console.WriteLine("Güncellenmiş Ürün Listesi");
                                    while (i < icecekler.Length)
                                    {
                                        Console.WriteLine($"{i} - {icecekler[i]} - {fiyatlar[i]} tl");
                                        i++;
                                    }
                                    Thread.Sleep(3000);
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Ürün Numarası");
                                }

                            }
                            else if (secim == 3)
                            {
                                Console.WriteLine("Güncellemek İstediğiniz Ürünü Seçiniz.");
                                i = 1;
                                while (i < icecekler.Length)
                                {
                                    Console.WriteLine($"{i} - {icecekler[i]} - {fiyatlar[i]} tl");
                                    i++;
                                }
                                int urunGuncelleme = Convert.ToInt32(Console.ReadLine());
                                if (urunGuncelleme >= 1 && urunGuncelleme <= fiyatlar.Length)
                                {
                                    Console.WriteLine("Ürünün Yeni Fiyatını Girin.");
                                    int yeniFiyat = Convert.ToInt32(Console.ReadLine());
                                    fiyatlar[urunGuncelleme] = yeniFiyat;
                                    Console.WriteLine("Ürün Fiyatı Güncellendi.");
                                    Console.WriteLine("Güncellenmiş Fiyat Listesi");
                                    i = 1;
                                    while (i < icecekler.Length)
                                    {
                                        Console.WriteLine($"{i} - {icecekler[i]} - {fiyatlar[i]} tl");
                                        i++;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz Ürün Numarası!");
                                }
                            }
                            else if (secim == 4)
                            {
                                Console.WriteLine("Çıkış Yapılıyor.. ");
                                Environment.Exit(0);
                            }
                            else
                            { Console.WriteLine("Hatalı Tuşlama Yaptınız!"); }
                        }

                    }
                    else
                    {
                        Console.WriteLine("Hatalı Tuşlama Yaptınız!");

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lütfen Rakam Tuşlayınız.");
                }
            }
        }
    }
}
