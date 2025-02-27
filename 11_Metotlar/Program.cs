using System.Data;
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
            //karakter(new List<char> { 'a', 'b', 'c' }, 10, 3);
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

            //string ad = AdVer();
            //List<int> sayilar = RastgeleSayilardanOlusanListe();
            //foreach (var item in sayilar)
            //    Console.WriteLine(item);

            //foreach (var item in RandomCharList())
            //    Console.WriteLine(item);

            //char karakter = (char)65;
            //Console.WriteLine(karakter);
            //int sayi = RastgeleCiftSayi();
            //Console.WriteLine("Çift Sayi: "+sayi);
            //string randomnamee = RandomName();
            //Console.WriteLine(randomnamee);
            //int enBuyukDeger = BesSayidanEnBuyugunuDonenMethod();
            //Console.WriteLine(enBuyukDeger);

            //Console.WriteLine( AdSoyadBirlesimi("hakan", "şahin") );

            //string bilgi = Info("hakan",2010);
            //Console.WriteLine(bilgi);

            //Console.WriteLine(Kontrolcu("alihan", "123qwe"));
            //Console.ReadLine();

            //int diff = ThreeNumber(15, 55, 72);
            //Console.WriteLine(diff);
            //Console.WriteLine(IsPossible("2f5f"));


            //int x =  Faktoriyel(3);
            //Console.WriteLine(x);

            //List<int[]> ints = new List<int[]>()
            //{
            //    new int[]
            //    {
            //        1,2,3
            //    },
            //    new int[]
            //    {
            //        5
            //    },
            //    new int[]
            //    {
            //        12,54,2,452,4
            //    }
            //};
            //Listele(ints);



            //Console.WriteLine(Toplamaİslemi()); 

            //int sayi = FazlasiylaToplaBelirtilenKatiAl(2,10,20);
            //sayi = FazlasiylaToplaBelirtilenKatiAl(2,new int[] {1,2,3,4});
            //Console.WriteLine(sayi);
            //Console.WriteLine(MetinselIfade("selam","naber"));

            //Selamliyorum();
            //Selamliyorum("Hakan");
            //Selamliyorum("Hakan", "Şahin");

            int sayi1 = 2;
            int sayi2;
            YerDegistir(ref sayi1, out sayi2);

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);
        }

        #region Ref, Out
        // Ref : Bu anahtar kelime kullanildigi alanda gonderilen degiskenin icerisinde degerinin olmasini bekler eger deger yoksa bu metoda kabul etmez.

        // Out : Bu kelimeyi kullanirken yine adres kopyalamasi yaparsiniz fakat aralarindaki far, ref kullanildigi yerde tanimlanmis olmasi gerekirken, outta kullanildigi yerde tanimlanmis olmasi gerekmez. Out tametot icerisinde mutlaka deger atamasi gerceklestirilmelidir.
        static void YerDegistir(ref int sayi1, out int sayi2)
        {
            sayi2 = 0;
            int sakla = sayi2;

            if (sayi1 > sayi2)
            {
                sayi2 = sayi1;
            }
            sayi1 = sakla;
        }




        #endregion



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

        #region Geriye deger donduren parametre almayan metot

        // return  : Geriye deger dondurmeyen metotlardada kullanilan amaci metodu kesmek olan bu anahtar kelime geriye deger dondurenlerde onune yazilan degeri donmektedir.

        static string AdVer()
        {
            string ad = "hakan";
            return ad;
        }

        static List<int> RastgeleSayilardanOlusanListe()
        {
            Random random = new Random();
            List<int> ints = new List<int>();

            for (int i = 0; i < 10; i++)
                ints.Add(random.Next(10));

            return ints;
        }


        // Rastgele karakterlerden olusan bir Liste olusturunuz. Olusan bu listeyi geriye donunuz.

        //static List<char> RandomCharList()
        //{
        //    var random = new Random();
        //    var charList = new List<char>();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        charList.Add((char)random.Next(65, 90));
        //    }
        //    return charList;
        //}
        // Kullaniciya [0-100] arasinda rastgele cift bir sayi donen metot olusturunuz.
        //static int RastgeleCiftSayi()
        //{
        //    Random rnd = new Random();

        //    while (true)
        //    {
        //        int sayi = rnd.Next(0, 100);
        //        if (sayi%2==0)
        //        {
        //            return sayi;
        //        }
        //    }
        //}


        // Rastgele bir isim donduren metot olusturunuz.
        static string RandomName()
        {
            string[] names = { "emre", "alperen", "hasan", "canberk", "osman", "samet", "kadir" };
            Random random = new Random();
            int index = random.Next(names.Length);
            return names[index];
        }
        // Rastgele uretilen 5 sayidan en buyugunu donen metot olusturunuz.

        static int BesSayidanEnBuyugunuDonenMethod()
        {
            List<int> integerlar = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                integerlar.Add(random.Next(100));
            }

            int enBuyuk = integerlar[0];

            foreach (var item in integerlar)
            {
                enBuyuk = Math.Max(item, enBuyuk);
            }

            return enBuyuk;

        }





        #endregion

        #region Geriye deger donduren parametre alan metot

        // Ad soyad alip geriye tek bir string ifade olarak donen metot olusturunuz.

        static string AdSoyadBirlesimi(string ad, string soyad)
        {
            return $"{ad} {soyad}";
        }

        // Adini ve dogum tarihini alarak adinin yaninda yasini yazip gonderen metot olusturunuz.

        // default parametre : Eger disaridan birsey gelmez ise defaultta verilen parametre degerleri kullanilir ve default verilen parametreler sonda yazilmalidir.
        static string Info(string ad = "Misafir", int dogumYili = 2000)
        {
            int yas = 2025 - dogumYili;
            return $"{ad} {yas} yasindadir.";
        }

        // Disaridan iki  pozitif sayi alip buyugu kucuge bolen metot olusturunuz. Deger gelmezse default degeler 1 olsun

        static int SayiBol(int sayi1 = 1, int sayi2 = 1)
        {
            int buyuk = Math.Max(sayi1, sayi2);
            int kucuk = Math.Min(sayi1, sayi2);

            int bolme = buyuk / kucuk;
            return bolme;
        }

        // Kullanici adi ve parola kontrolu yapip geriye true veya false olarak donen metot olusturunuz.

        static bool Kontrolcu(string kAdi, string parola)
        {

            return kAdi == "alihan" && parola == "123qwe";


        }

        // Gonderilen 3 adet sayidan en buyugu ile en kucugu arasindaki mesafeyi donen metot olusturunuz.
        static int ThreeNumber(int number1, int number2, int number3)
        {
            int longest = Math.Max(number1, (Math.Max(number2, number3)));
            int shortest = Math.Min(number1, (Math.Min(number2, number3)));
            int diff = longest - shortest;
            return diff;
        }

        // Gonderilen metinsel ifade tam sayiya donusturelebiliyormu donusturulemiyormu cevabini donen metot olusturunuz.

        static bool IsPossible(string input)
        {

            try
            {
                Convert.ToInt32(input);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            //return int.TryParse(input, out int number) ;
        }

        #endregion

        #region Recursive
        // Metodun kendi icerisinde kendisini cagirarak kullanma seklidir.

        // Faktoriyel hesaplayan recursive function.

        static int Faktoriyel(int sayi)
        {
            if (sayi == 1)
                return 1;
            return sayi * Faktoriyel(sayi - 1);
        }

        // Gonderilen dizi icerisinde dizinin tum elemanlarini yazdiran metot olusturunuz.
        static void Listele(List<int[]> sayilar)
        {
            if (sayilar.Count == 0)
                return;

            for (int i = 0; i < sayilar.Count; i++)
            {
                Console.WriteLine($"***{sayilar.Count}***");
                foreach (var diziElemani in sayilar[i])
                {
                    Console.WriteLine(diziElemani);
                }

                sayilar.Remove(sayilar[i]);
                Listele(sayilar);
            }
        }

        // Sifirdan gonderilen sayiya kadar toplama islemi yapan ve sonucu donduren metot olusturunuz.
        static int Toplamaİslemi(int a = 10)
        {
            if (a == 1)
            {
                return 1;
            }
            return a + Toplamaİslemi(a - 1);
        }


        #endregion

        #region Params
        // Params : Sinirsiz olarak parametre almayi saglayan anahtar kelimedir. Parametre belirtirken params ile belirlenen parametre sona yazilmalidir.

        static int FazlasiylaToplaBelirtilenKatiAl(int kat, params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam * kat;
        }

        // Sinirsiz olarak metinsel ifade alan ve bunlarin her birinin eleman sayisi miktarini toplayan ve geriye donen metot olusturunuz. 

        static int MetinselIfade(params string[] ifadeler)
        {
            int total = 0;
            foreach (var item in ifadeler)
            {
                total += item.Length;
            }
            return total;
        }

        #endregion
        #region Method Overload

        // Method Overload : Metot asiri yuklemesi durumu ayni isimde birden fazla metodun bulunmasi ama hepsinin parametrelerinin farkli olmasi ile olusur.

        static void Selamliyorum()
        {
            Console.WriteLine("Merhaba");
        }
        static void Selamliyorum(string ad)
        {
            Console.WriteLine($"Merhaba {ad}");
        }
        static void Selamliyorum(string ad, string soyad = "şahin")
        {
            Console.WriteLine($"Merhaba {ad} {soyad}");
        }

        #endregion


    }
}
