using _14_OOPConstructor.Models;

namespace _14_OOPConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constructor : Bir sinifin yapici olan metodudur. Ilk nesne ornegi uretildiginde bu metot calisir. Gorunur hale getirmesekte yapici metot aktiftir. Bir sinif ornegi olustururken tek bir ctor uzerinden ayaga kaldirilir.

            // this : Ilgili sinifi temsil eder. Icerisinde kullandiginizda ne var e yoksa gorebilirsiniz.

            //new Metro();
            //new Metro("Bu ikinci metromuz");

            //var metro = new Metro(-500);
            //Console.WriteLine(metro.PassengerCapacity);

            //for (int i = 0; ; i++)
            //{
            //    new Metro(i);
            //}

            // Kedi sinifi olusturarak icerisine Tur,Cinsiyet,YasamSuresi,Renk, TuyluMu, Ad, Mensei ozelliklirini olusturunuz. Her kedi ornegi olusturuldugunda bir kedi gordum sanki yazdirilsin. Ctor uzerinden kapsullemesiz ozelliklere deger atilabilsin. Encapsulation get set ile saglansin. Ad max 25 karakter,Ad min 2 karakter, Tur elimizde olanlardan degilse elimizden random olarak atansin, Renk elimizdekilerden degilse random atilsin, Yasam sureleri en az 10 yil olmalidir, Mensei belirlenen ulkelerden farkli ise random belirtilsin. Bos gelen tum ozellikler random olarak atansin. 

            //Kedi kedi = new Kedi("tekir","disi",15,"beyaz",true,"tigra","trabzon");

            //kedi.Ad = "T";
            //Console.WriteLine(kedi.Ad);
            //kedi.Turu = "sdfds";
            //Console.WriteLine(kedi.Turu);
            //kedi.Renk = "dffkjd";
            //Console.WriteLine(kedi.Renk);
            //kedi.YasamSuresi = 3;
            //Console.WriteLine(kedi.YasamSuresi);
            //kedi.Mensei = "dsfasgasd";
            //Console.WriteLine(kedi.Mensei);

            // Film adinda bir sinif olusturunuz. Icerisinde Id, filmadi,yonetmeni,cikis tarihi, imdb,konu,kategori,hasilat ozelliklerini kullanicidan alalim.
            // * Kullanici her veriyi dogru formatta girene kadar sorabilmeli ve hatalara engel olmaliyiz. Proje akisinda devam edebilmelidir.
            // * Film adi en fazla 25 karakterden olusabilir ve bos gecilemez olsun.
            // * Cikis yili gelecekten bir tarih olamaz en on bu gunun tarihi olmalidir.
            // * imdb max 10.0 olmali ve negatif olmamalidir.
            // * konu max 200 karakter olmalidir.
            // * Kategori bos gecilemez 3 karakterden az ve 25 karakterden fazla olamaz.
            // * Hasilat negatif ve 1 milyarin uzerinde olamaz.
            // * Istenirse deger atamalari ctor uzerinden gerceklestirilebilsin.
            // Idler otomatik olarak 1 den baslasin ve devam etsin.  

            Film film = new Film();
            bool devamMi = true;
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Lütfen Film adi giriniz");
            //        film.FilmAdi = Console.ReadLine();
            //        devamMi = false;
            //        Console.ReadLine();
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        devamMi = true;
            //    }
            //    catch(Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        devamMi = true;
            //    }
            //    Thread.Sleep(1000);
            //    Console.Clear();

            //} while (devamMi);
            //Console.Write("Film tarihini giriniz : ");
            //film.CikisTarihi = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine(film.CikisTarihi);

            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Lütfen Film Puanı giriniz");
            //        film.Rating = double.Parse(Console.ReadLine());
            //        devamMi = false;
            //        Console.ReadLine();
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        devamMi = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        devamMi = true;
            //    }
            //    Thread.Sleep(3000);
            //    Console.Clear();

            //} while (devamMi);

            // Konu
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("Lütfen bir film konusu giriniz");
            //        film.Konu = Console.ReadLine();
            //        devamMi = false;
            //        Console.ReadLine();
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        devamMi = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        devamMi = true;
            //    }
            //    Thread.Sleep(3000);
            //    Console.Clear();

            //} while (devamMi);
            /*
            do
            {
                try
                {
                    Console.WriteLine("kategori giriniz");
                    film.Kategori = Console.ReadLine();
                    devamMi = false;
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    devamMi = true;
                }
                Thread.Sleep(3000);
                Console.Clear();

            } while (devamMi);
            */
            Console.WriteLine("Hasılat giriniz: ");
            decimal hasilat = Convert.ToDecimal(Console.ReadLine());
            film.Hasilat = hasilat;
            Console.WriteLine($"Filmden kazandığınız hasılat: {film.Hasilat}");
        }
    }
}