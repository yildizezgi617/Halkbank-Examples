using System.Threading.Channels;

namespace _11_Metotlar
{
    internal class Program
    {
        // Metot : Belirli gorevleri yerine getiren islevsel parcalardir. Cagirilmadan kullanilmaz kesinlikle cagirilmalari gerekir.

        // Metotlar 2 ye ayrilir. Geriye deger donduren ve geriye deger dondurmeyen seklindedir. Bunlarda aralarinda 2 ye ayrilir parametre alan ve parametre almayan seklindedir.

        // void : Turke manasiyla hiclik yokluk gibi manalara denk gelir. Bu metot tipi geriye deger dondurulmeyecegini temsil eder.

        // Parametre : metotlara disaridan deger almak icin yapisinda olusturulan degiskenlerdir.

        // geriyeDonusTipi metotAdi(parametre)
        // {

        // }

        static void Main(string[] args)
        {
            karakter(new List<char> { 'a', 'b', 'c' }, 10, 3);
            //List<int> sayilar = new List<int> { 1, 2, 3 };
            //Liste(sayilar);
            //KarekterlerineBolen();
            //Cumle();
            //AdiSelamla("Hakan","Şahin");
            //sayiKaresi(5);
            /*KelimeBul("Her şey güzel olacak", "güzel");*/
            //AracMarka("Skoda",5456454);
            /*
            string[] meyveler = { "ELMA", "armut","Çilek"};
            MeyveDizisiAlan(meyveler);
            Console.ReadLine();*/
            /*
            int[] dizi1=new int[] { 1, 2, 3 };
            int[] dizi2=new int[] { 4,5,6 };
            CarpimIslem(dizi1 , dizi2);

            */
            /*   ZamliFiyat(25000,20,"tv ünitesi");*/

        }



        #region Geriye deger dondurmeyen parametre almayan metot
        // Sadece icerisinde islemleri yapar halleder fakat geriye bir cevap vermez.
        static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }

        // Kullanicinin girdigi adi karakterlerine bolerek alt alta yazdiran metot olusturunuz.

        static void KarekterlerineBolen()
        {
            Console.WriteLine("metin giriniz");
            string metin = Console.ReadLine();
            foreach (char karakter in metin)
            {
                Console.WriteLine(karakter);
            }
        }

        static void Cumle()
        {
            string cumle = "bir gun her şey daha güzel olacak";
            for (int i = 0; i < cumle.Length; i++)
            {
                Console.WriteLine(cumle);
            }
        }

        // Ekrana rastgele 5 tane sayi yazdiran metot olusturunuz.

        static void EkranaRastgele5SayiYazanMetot()
        {
            var random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(random.Next(1, 7));
            }
        }
        // 5 adet dairenin temizligini sirasiyla yapan metot olusturunuz.(1. kat temizligi yapildi)

        static void DaireTemizle()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i}. daire temizlendi");
            }
        }


        // Ekrana "bir gun her şey daha güzel olacak" cumlesinin karakter uzunlugu kadar  ekranda cumleyi yazdiriniz.




        #endregion

        #region Geriye deger dondurmeyen parametre alan metot

        static void AdiSelamla(string ad, string soyad)
        {
            Console.WriteLine($"Merhaba {ad} {soyad}");
        }

        // Gonderilen sayinin karesini ekrana yazdiriniz.

        static void sayiKaresi(int sayi)
        {

            int sayiKaresi = sayi * sayi;
            Console.WriteLine($"{sayi} in Karesi : {sayiKaresi}");
        }




        // Gonderilen metnin iceriginde gonderilen kelime geciyormu yazdiriniz.
        static void KelimeBul(string cumle, string kelime)
        {
            bool varMi = cumle.Contains(kelime);
            if (varMi == true)
                Console.WriteLine(" kelime cumlede geciyor");
            else
                Console.WriteLine("kelime cumlede gecmiyor");

        }
        // Marka ve fiyat alan icerisinde X marka arac T Tl'dir seklinde mesaj yazan metot olusturunuz.

        static void AracMarka(string marka, int tl)
        {
            Console.WriteLine($"{marka} marka arac {tl} tl'dir.");
        }
        // Bir tamsayi listesi alan ve bu tamsayilarin karelerini ekrana yazan metot olusturunuz.
        static void Liste(List<int> tamSayilar)
        {
            for (int i = 0; i < tamSayilar.Count; i++)
            {

                Console.WriteLine(tamSayilar[i] * tamSayilar[i]);
            }
        }


        // Bir meyve dizisi alan ve her meyveyi uzunlugu kadar tekrarli yazdiran metot olusturunuz.
        static void MeyveDizisiAlan(string[] meyveler)
        {
            for (int i = 0; i < meyveler.Length; i++)
            {
                for (int j = 0; j < meyveler[i].Length; j++)
                {
                    Console.WriteLine($"{i + 1}= {meyveler[i]}");
                }

            }
        }

        // Iki adet tamsayi dizisi alan ve tum elemanlari birbirleri ile carptirip ekrana yazdiran metot olusturunuz.
        static void CarpimIslem(int[] dizi1, int[] dizi2)
        {
            for (int i = 0; i < dizi1.Length; i++)
                for (int j = 0; j < dizi2.Length; j++)
                    Console.WriteLine($"{dizi1[i]}*{dizi2[j]}={dizi1[i] * dizi2[j]}");
        }

        // Disaridan alinan bir urunun eski fiyatini ve zam oranina gore yeni fiyatini ekranda yazdiran metot olusturunuz.
        static void ZamliFiyat(double eskiFiyat, double zamOrani, string urunAdi)
        {
            double yeniFiyat = eskiFiyat + (eskiFiyat * (zamOrani / 100));
            Console.WriteLine($"{eskiFiyat} ı olan {urunAdi} 'ün zamlı fiyatı {yeniFiyat} TL'dir ");
        }
        // Disaridan alinan karakterler,adet,uzunluk bilgisine gore ekranda rastgele ilgili uzunlukta ilgili adet kadar ifadeyi yazan metot olusturunuz.   

        static void karakter(List<char> charList, int adet, int uzunluk)
        {
            string result = "";
            Random random = new Random();
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < uzunluk; j++)
                {
                    int rnd = random.Next(0, 2);
                    string cikti = charList[rnd].ToString();
                    result = result + cikti;

                }
                Console.WriteLine(result);
                result = "";
            }
        }
        #endregion



    }
}
