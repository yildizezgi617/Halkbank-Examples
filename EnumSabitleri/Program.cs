using _17_EnumSabitleri.Enums;
using _17_EnumSabitleri.Models;
using System.Security.Cryptography.X509Certificates;

namespace _17_EnumSabitleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(  Gun.Pazar  );
            //Console.WriteLine(  (int)Gun.Pazar  );

            //MyClass myClass = new MyClass();
            //myClass.Gun = Gun.Cuma;
            //Console.WriteLine( myClass.Gun );

            //string[] gunler = Enum.GetNames(typeof(Gun));
            //foreach (string item in gunler)
            //{
            //    Console.WriteLine(item);
            //}


            //// Kulanicidan dogdugu ayi alarak burcunu yazdiran metot olusturunuz.
            //Console.WriteLine(  "doğduğun ay");
            //string girdi=Console.ReadLine();
            //string[] aylar = Enum.GetNames(typeof(Months));
            //string[] burclar = Enum.GetNames(typeof(Burclar));

            //for (int i = 0; i < aylar.Length; i++)
            //{
            //    if (aylar[i] ==girdi)
            //        Console.WriteLine($"Burç:{burclar[i]}");
            //}



            //// Burca gore dogdugu ayi yazdiran metot olusturunuz.

            //Console.WriteLine("Burcunuzu giriniz");
            //Burclar burclar = (Burclar)Enum.Parse(typeof(Burclar),Console.ReadLine(),true);

            //Console.WriteLine(DogduguAy(burclar));




            // Kullanicinin Adini,Soyadini ve dogum tarihini alarak burcunu bulan ve ekrana yazdiran metot olusturunuz.

            Console.Write("Adinizi giriniz : ");
            string ad = Console.ReadLine();

            Console.Write("Soyadinizi giriniz : ");
            string soyad = Console.ReadLine();

            Console.Write("Dogum tarihiniz giriniz : ");
            DateTime tarih = DateTime.Parse(Console.ReadLine());

            Kullanici kullanici = new Kullanici();
            Burclar burc = BurcBul(tarih);

            //Console.WriteLine($"Adi : {kullanici.Ad} Soyadi : {kullanici.Soyad} Burcu : {burc}");

            string cumle = $"{ad} {soyad} isimli kisi {burc} burcudur.";
            foreach (var item in cumle)
            {
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(item);
            }



        }

        public static Burclar BurcBul(DateTime tarih)
        {
            return tarih.Month switch
            {
                1 => Burclar.Oğlak,
                2 => Burclar.Yay,
                3 => Burclar.Başak,
                4 => Burclar.Koç,
                5 => Burclar.Kova,
                6 => Burclar.Akrep,
                7 => Burclar.Aslan,
                8 => Burclar.Terazi,
                9 => Burclar.İkizler,
                10 => Burclar.Boğa,
                11 => Burclar.Yengeç,
                12 => Burclar.Başak,
                _ => throw new Exception("Gecersiz ay ")
            };
        }

        static Aylar DogduguAy(Burclar burcum)
        {
            var result = burcum switch
            {
                Burclar.Oğlak => Aylar.Ocak,
                Burclar.Kova => Aylar.Subat,
                Burclar.Balık => Aylar.Mart,
                Burclar.Koç => Aylar.Nisan,
                Burclar.Boğa => Aylar.Mayis,
                Burclar.İkizler => Aylar.Haziran,
                Burclar.Yengeç => Aylar.Temmuz,
                Burclar.Aslan => Aylar.Agustos,
                Burclar.Başak => Aylar.Eylul,
                Burclar.Terazi => Aylar.Ekim,
                Burclar.Akrep => Aylar.Kasim,
                Burclar.Yay => Aylar.Aralik,
                _ => throw new Exception("Gecersiz Burc")


            }; return result;


        }

    }
}
