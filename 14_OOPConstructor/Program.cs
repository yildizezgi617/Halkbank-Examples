using _14_OOPConstructor.Models;

namespace _14_OOPConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constructor:Bir sınıfın yapıcı olan methodudur. İlk nesne üretildiğinde bu method çalışır.Görünür hale getirmesekte yapıcı method aktiftir. Bir sınıf orneği oluşturulurken tek bir ctor üzerinden ayağa kaldırılır.
            //This sınıfı ilgili methodu temsil eder. içinde ne var ne yoksa görebilirsiniz.

            //Metro kadikoySabihaGokcen = new Metro();
            //new Metro();
            //new Metro("BU İKİNCİ CTORUN MESAJI");

            //var metro = new Metro(-500);
            //Console.WriteLine(metro.PassengerCapacity);

            //Kedi sınıfı oluşturarak içerisine Tur,Cinsiyet,YasamSuresi,Renk,TuyluMu,Ad,Mensei özelliklerini oluşturunuz. Her kedi örneği oluşturulduğunda bir kedi gordum sanki yazdırınız. Ctor üzerinden kapsüllemesiz ozelliklere deger atılabilsin. encapsulation get set ile sağlansın. ad max 25 min 2 karakter olsun. tür elimizde olanlardan degilse elimizden random olarak atansın. Renk elimizdekilerden degilse random atilsin. Yasam süreleri en az 10 yil olmalidir. Mensei belirlenen ülkelerden farkli ise random belirtilsin.Bos gelen tüm özellikler random olarak atansin.


            //Kedi kedi = new Kedi();
            //kedi.Ad = "T";
            //Console.WriteLine(kedi.Ad);
            //kedi.Tur = "flfdş";
            //Console.WriteLine(kedi.Tur);
            //kedi.Mensei = "Turkiye";
            //Console.WriteLine(kedi.Mensei);

            //Kedi kedi3 = new Kedi("tekir", "disi", 15, "beyaz", true, "tigra,", "trabzon");

            //Film adında bir sınıf oluşturun içersinde filmadı yönetmeni cikis yili, imdb, konu, katgeori,hasilat, ozelliklerini kullanıcıdan alalım

            //kullanıcı her veriyi dogru formatta girene kadar sorabilmeli ve hatalara engel olmaliyiz.Proje akısında devam edebilmelidir.

            //film adi en fazla 25 karakterden olusabilir ve bos gecilemez olmalıdır,

            //çıkış yılı gelecekten bir tarih olamaz en son bu günün tarihi olmalıdır.

            //imdb max 10.0 olmalı ve negtaif olmamalıdır.

            //konu max 200 karakter olmalıdır 

            // kategori bos gecilemez 3 karekterden az 25 karakterden fazla olamaz

            //hasilat negatif ve 1 milyarın üzerinde olamaz

            //Istenirse deger atamaları ctor üzerinden gerçekleştirilebilsin

            // Idler otomatik olarak 1 den başlasın ve devam etsin.


            //Console.WriteLine("Lütfen film adını giriniz");

            //Film film = new Film();


            //film.FilmAdi = Console.ReadLine();
            //Console.WriteLine(film.FilmAdi);

            Film film = new Film();
            bool devamMi = true;
            do
            {
                try
                {
                    Console.WriteLine("Lütfen film adını giriniz:");
                    film.FilmAdi = Console.ReadLine();
                    devamMi = false;

                    Console.WriteLine("Lütfen yönetmen adını giriniz:");
                    string yonetmen = Console.ReadLine();

                    Console.WriteLine("Lütfen çıkış yılını giriniz:");
                    int cikisYili = int.Parse(Console.ReadLine());

                    Console.WriteLine("Lütfen IMDB puanını giriniz:");
                    double imdb = double.Parse(Console.ReadLine());

                    Console.WriteLine("Lütfen konuyu giriniz:");
                    string konu = Console.ReadLine();

                    Console.WriteLine("Lütfen kategoriyi giriniz:");
                    string kategori = Console.ReadLine();

                    Console.WriteLine("Lütfen hasılatı giriniz:");
                    decimal hasilat = decimal.Parse(Console.ReadLine());

                    film = new Film(filmadi, yonetmen, cikisYili, imdb, konu, kategori, hasilat);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                }


            }
        }
    }
}



