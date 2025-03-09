using _16_StaticYapilar.Extensions;
using _16_StaticYapilar.Models;

namespace _16_StaticYapilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Static : Bu etiketi alan tum ozellikler yetenekler artik ne varsa ram uzerinde hayatta kalir. Yani isleri bitse dahi garbage collector statikleri temizleyemez. Statiklerin nesne ornegi uretilemez. Sistem ayaga kalkarken kendisi bir kez olusturur daha sonra o olusmus olan kullanilir. Sinif icerisindeki staticleri kullanmak istersek tip uzerinden gideriz. Eger static olmayanlari kullanmak istersek instance ureterek kullanmamiz gerekir.

            //Motor motor = new Motor();
            //Motor motor2 = new Motor();
            //Motor motor3 = new Motor();

            //Console.WriteLine(motor.Id);
            //Console.WriteLine(motor2.Id);
            //Console.WriteLine(motor3.Id);

            //Motor motor = new Motor();
            //motor.Info();
            //motor.Bilgi();
            //Motor.id = 0;

            // Futbolcu olarak bir  nesne uretiniz. Icerisinde ad,soyad,telefon,dogumTarihi,oyunAlani,maas,bonservis,takim,formaNumarasi gibi ozellikleri bulunsun.
            // * Hicbir bilgi bos gecilemez olsun
            // * Telefon 11 haneli olana kadar giris yapsin

            //Futbolcu futbolcu = new Futbolcu();
            //bool dogruMu = true;
            //while(dogruMu)
            //{

            //    try
            //    {
            //        Console.WriteLine("lütfen bir telefon numarası girin.");
            //        string telefonNumarası = Console.ReadLine();
            //        futbolcu.TelefonNumarası = telefonNumarası;
            //        break;
            //    }

            //    catch (Exception)
            //    {


            //    }
            //}

            //try
            //{
            //    Console.WriteLine("Lütfen doğum tarihi giriniz!");
            //    futbolcu.DogumTarihi = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine(futbolcu.DogumTarihi);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}



            // * Dogum tarihi resit degilse resit, 35 yas uzeriyde 35 e tamamlansin
            // * Maas negatif olamaz asgari ucret altinda kalamaz.
            //try
            //{
            //    Console.WriteLine("Lütfen maas giriniz!");
            //    futbolcu.Maas=decimal.Parse(Console.ReadLine());
            //    Console.WriteLine(futbolcu.Maas);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            // * Bonservis max 250 olsun
            //try
            //{
            //    Console.WriteLine("Lütfen bonservis bedeli giriniz!");
            //    futbolcu.Bonservis = int.Parse(Console.ReadLine());
            //    Console.WriteLine(futbolcu.Bonservis);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            // * Takim elimizdeki takimlardan degilse random verilsin

            //Futbolcu futbolcu1 = new Futbolcu();
            //futbolcu1.Takim = "F";
            //Console.WriteLine(futbolcu1.Takim);

            // * FormaNumarasi [1,100) arasinda olmalidir.


            //// * Rastgele forma numarasi ureten static uzantili metot uretiniz.

            //Futbolcu futbolcu1 = new Futbolcu();
            //futbolcu1.RastgeleFormaNumarasıÜret();
            //Console.WriteLine($"{futbolcu1.FormaNumarasi}");

            //// * Tum bilgileri veren bir static metot olsun.
            //futbolcu1.Takim = "b jk";
            //futbolcu1.FormaNumarasi = 7;
            //Console.WriteLine(futbolcu1.TumBilgiler()); ;

            //// * maas ile bonservis farkini donduren static bir metot tasarlayiniz.

            //Futbolcu futbolcu = new Futbolcu()
            //{
            //    Maas = 100000,
            //    Bonservis =250
            //};
            //decimal fark = futbolcu.MaasBonservisFarki();
            //Console.WriteLine($"Maaş ile bonservis farkı : {fark} " );



            // Futbolcu sinifi kullanildiginda ekranda 1 kez Futbolcu aktif yazisi ve olusum basladi yazisi yazdirilsin. Sonraki uretilen nesne orneklerinde ise sadece olusum basladi seklinde yazdirilsin

            //string message;
            //Futbolcu f1 = new Futbolcu(out message);
            //Console.WriteLine(message);

            //Futbolcu f2 = new Futbolcu(out message);
            //Console.WriteLine(message);

            //new Futbolcu();
            //new Futbolcu();
            //new Futbolcu();
        }
    }
}
