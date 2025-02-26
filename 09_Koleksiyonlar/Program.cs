using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _09_Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //koleksiyonlar : biz değişken kullanırken tek bir değer saklayabiliyorken koleksiyonlar ile birden fazla değer saklyayabiliriz. ve indexleme mantığı ile içersinde gezinebiliyoruz. çoğul isimlendirilir.

            //dizi(array): diziler aynı tipteki birden fazla değeri saklayabilirlerç index nolarına göre yerlerini belirtir. bir dizi oluşturulduğunda boyutu kadar alan açılır.içine değer atılsa da atılmasa da default olarak o alan açılır. dizi oluşt. için belirtilen tipin önhüne koşeli parantez açılır. dizilerin boyutları belirtilmek zorundadır. belirtirilmezse default olarak değer girilmiş ve ona hitaben boyutlandırılmış demektir.

            //double[] ondalikliSayilar = { 0.5, 5.5, 1.5, 2.5 };
            //int[] tamSayilar = new int[] { 1, 2, 3, 4, };
            //string[] meyveler = new string[5] { "elma", "armut", "limon", "karpuz", "papaya" };

            //char[] karakterler = new char[5];
            //karakterler[0] = 'a';
            //karakterler[1] = 'b';
            //karakterler[2] = 'c';
            //karakterler[3] = 'd';
            //karakterler[4] = 'e';
            ////karakterler [5] = f dizi boyutları dışına çıkar hata verir
            //Console.WriteLine(karakterler[0]);


            ////meyveleri ekrana yazdır
            //for (int i = 0; i < meyveler.Length; i++)
            //{
            //    Console.WriteLine(meyveler[i]);
            //}


            // kullanıcıdan gelen dizi boyutunu alınız ve o kadar adet eleman girmesini isteyiniz.En son girilen sayıların 1 fazlasını ekranda yazdırınız
            //int sayi = 0;
            //Console.WriteLine("dizi boyutu veriniz");
            //int boyut = int.Parse(Console.ReadLine());
            //int[] sayilar = new int[boyut];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine("sayi yaziniz");    //bunu try catche de atabiliriz bir tane format exc bir de genel exc 
            //    sayi = int.Parse(Console.ReadLine());   //once birinci for biter sonra ikinci fora gecer
            //    sayilar[i] = sayi;


            //  }
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine($"{sayilar[i]+1}");
            //}






            //kullanıcıdan gelen alana göre belirtilen boyutlardaki kutulardan kaç adet aliniyorsa o kadar adet kutu adi alınız ve ekranda tüm elemanları yazdırınız


            //  Console.WriteLine("alan veriniz");
            // int alan= int.Parse(Console.ReadLine());

            // Console.WriteLine("kutu alanı veriniz");
            // int kutuAlanı = int.Parse(Console.ReadLine());
            //string[] kutuAdlari  = new string[alan/kutuAlanı];


            // for (int i = 0; i < kutuAdlari.Length; i++)
            // {
            //     Console.WriteLine("kutu adi:");
            //     kutuAdlari[i] = Console.ReadLine();
            // }
            // for (int i = 0; i < kutuAdlari.Length; i++)
            // {
            //     Console.WriteLine(kutuAdlari[i]);
            // }



            //5 karakterden oluşan 10 adet rastgele kelime dizisi oluşturarak bu dizinin elemanlarını yazdiriniz
            //char[] karakter = { 'a', 'b', 'c', 'd', 'e' };
            //string[] kelimeler = new string[10];

            //Random rnd = new Random();
            //string sonKelime = "";

            //for (int i = 0; i < 10; i++) //rastgele 10 kelime dizisi
            //{
            //    for (int j = 0; j < karakter.Length; j++)  //rastgele indexi ver, rastgele gelen indexle birleştir.
            //    {
            //        int rastgele = rnd.Next(0, 5);
            //        sonKelime += karakter[rastgele];

            //    }
            //    kelimeler[i] = sonKelime;
            //    sonKelime = "";
            //}
            //foreach ( string kelime in kelimeler)
            //{
            //    Console.WriteLine(kelime);
            //}



            //kullanıcının verdiği ismi büyüklü küçüklü ekranda yazdırınız her karakter random renk ile yazılsın


            //Console.WriteLine("isim giriniz");
            //string isimGir =Console.ReadLine();
            //Random rnd = new Random();

            //ConsoleColor[] renkler = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.DarkCyan, ConsoleColor.DarkYellow, ConsoleColor.DarkMagenta, ConsoleColor.White };

            //bool kontrol = true;
            //char harf = ' ';
            //for (int i = 0; i < isimGir.Length; i++)
            //{
            //    harf = isimGir[i];

            //    Console.ForegroundColor = renkler [rnd.Next(renkler.Length)];
            //    if (kontrol)
            //    {
            //        Console.Write(char.ToUpper(isimGir[i]));
            //    }
            //    else
            //    {
            //        Console.Write(char.ToLower(isimGir[i]));
            //    }
            //    kontrol = !kontrol;

            //}


            //Ekranda random renklerle 01 yazdiriniz

                Random random= new Random();

            ConsoleColor[] renkler = {ConsoleColor.Red, ConsoleColor.Green,ConsoleColor.Blue,ConsoleColor.Magenta,ConsoleColor.Red};

            //string hacker = "";

            //for (; ; )
            //{
            //    Console.ForegroundColor = renkler[random.Next(renkler.Length)];


            //    Console.Write(random.Next(2) );


            //}






            //Foreach diziler içinde gezinme yapmamızı sağlar

            //int[] sayilar = { 0, 1, 2, };

            //foreach ( int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}



            //Kuyruk
            //Queue(first in first out)
            Queue<string> siparisler = new Queue<string>();
            //siparisler.Enqueue("siparis1");    //eleman ekleniyor enqueue ile
            //siparisler.Enqueue("siparis2");
            //siparisler.Enqueue("siparis3");

            //int sayac =siparisler.Count;

            ////siparişleri ekrana yazdır
            //Console.WriteLine("siparisler");

            //for (int i = 0; i < sayac; i++)
            //{
            //    Console.WriteLine($"siparis goruntusu:{siparisler.Peek()}");    //kuyruktan çıkarmadan gösterir
            //    Console.WriteLine(siparisler.Dequeue());   //kuyruktaki elemanları çıkartıp getirir
            //}

            //banka işlemleri için gelen sırada ilgili isimleri alıp bir kuyrukta saklayiniz ve sirasıyla gelenin işlemini yapınız. 10 musteri için

            //Queue<string>  musteriler = new Queue<string>();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("musteri ismi girin");
            //    musteriler.Enqueue(Console.ReadLine());

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("tamamlandı: " +musteriler.Dequeue());
            //}



            ////Stack(Yığınn) Last in first out
            //Stack<string> sarjor = new Stack<string>();
            //sarjor.Push("Mermi1");
            //sarjor.Push("Mermi2");
            //sarjor.Push("Mermi3");

            //Console.WriteLine("Mermiler Peek");
            //Console.WriteLine(sarjor.Peek());
            //Console.WriteLine(sarjor.Peek());
            //Console.WriteLine(sarjor.Peek());



            //Console.WriteLine("Mermiler Foreach");
            //foreach (var item in sarjor)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine("işi biten elmanlar");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(sarjor.Pop());  //yıgından elemanı getirir ve çıkartır digerleri sadece getirir
            //}

            // bir kullanıcıdan bir dosya yolunun tum elemanlarını alarak en son bir string ifade birleştiriniz
            //Stack<string> dosyaYolu = new Stack<string>();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(" Yolu giriniz ");
            //    dosyaYolu.Push(Console.ReadLine());


            //}

            //Console.WriteLine("Dosya yolunuz şudur:");
            //foreach (var item in dosyaYolu)
            //{
            //    Console.Write(item);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(dosyaYolu.Pop());
            //}


            //Dictionary(sozluk) key value (anahtar-deger) ile beraber hareket eder. bu sayede  istenilen anahtardaaki degeri cekebiliriz

            //ip adreslerini ve hangi siteye ait olduğunuu tutan bir sözlük tasarlayiniz

            //Dictionary<string,string> ipler = new Dictionary<string,string>();
            // ipler.Add("google", "142.251.141.36");
            // ipler.Add("facebook", "157.240.238.35");
            // ipler.Add("hotmail", "204,79,197,212");

            // string ip = ipler["google"];
            // Console.WriteLine("istenilen ip:"+ip);

            // //Tüm keyleri yazdıralım
            // Console.WriteLine("\n Keys");
            // foreach (var item in ipler.Keys)
            // {
            //     Console.WriteLine(item);
            // }

            // //Degerleri yazdiralim
            // foreach (var item in ipler.Values )
            // {
            //     Console.WriteLine(item);
            // }

            // //Deger sil
            // bool silindiMi = ipler.Remove("hotmail");
            // Console.WriteLine("silindi mi: "+ silindiMi);

            //5 adet kelime girilen ingilizce keylere karşılık türkçe kelime karşılığını deger olarak verelim.son ekranda kullanıcıdan bir key (string kelime) alarak turkce karş yazdıralım
            //string ing = "";
            //string tr = "";
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("ing kelime gir");
            //    ing = Console.ReadLine();
            //    Console.WriteLine( "turkce kelime gir");
            //    tr = Console.ReadLine();
            //    dic.Add(ing, tr);
            //}
            //Console.WriteLine("çevirmek istediğiniz kelimeyi girin");
            //var girdi = Console.ReadLine();
            //Console.WriteLine("sonuc");
            //Console.WriteLine(dic[girdi]);


            //plakaları ve sehirlerini kullanıcıdan alarak sozluge ekleyelim ekranda tek tek yazdiralım
            //Dictionary<string, string> sehirler = new Dictionary<string, string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("plaka girin");
            //    string plaka = Console.ReadLine();
            //    Console.WriteLine("sehir ismi girin");
            //    string sehir = Console.ReadLine();
            //    sehirler.Add(sehir, plaka);

            //}
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine($"{ item.Key} : { item.Value}");
            //}



            //urun ozellik ve degerlerini kullanıcıdan alarak ekranda son haliyle yazdıralım

            //Dictionary<string,string> urunOzellik = new Dictionary<string,string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("urun ismi girin");
            //    string urun = Console.ReadLine();
            //    Console.WriteLine("ozellik girin");
            //    string ozellik =Console.ReadLine();
            //    urunOzellik.Add(urun, ozellik);
            //}
            //foreach (var item in urunOzellik)
            //{
            //    Console.WriteLine($"ürün {item.Key}  deger: {item.Value} ");
            //}



            ////kullanıcıya 3 tip gostererek bu tipte 5er adet deger alip sozlukte saklayiniz
            //Dictionary<string,object> dictionary= new Dictionary<string,object>();
            ////int[] ints = new int[5];
            //string[] strings= new string[5];
            //string[] tipler= {"int","deger"};

            //for (int i = 0; i < tipler.Length; i++)
            //{
            //    if(i==0) {
            //        for (int j = 0; i < ints.Length; i++)
            //        {
            //            Console.WriteLine("lutfen bir deger giriniz");
            //            int intDeger = int.Parse(Console.ReadLine());
            //            ints[j] = intDeger;

            //        }
            //        dictionary.Add(tipler[i], ints);

            //    }
            //    else
            //    {
            //        for (int k= 0; k < strings.Length; k++)
            //        {
            //            Console.WriteLine($"lutfen {tipler[i]} bir deger giriniz");
            //            string strDeger = Console.ReadLine();
            //            strings[k] = strDeger;
            //        }
            //        dictionary.Add(tipler[i], strings);
            //    }


            //}
            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine($"******{item.Key}*******");
            //    if (item.Value is int[])
            //    {
            //        foreach (var item1 in item.Value as int[])
            //            Console.WriteLine(item1);
            //    }

            //    else
            //    {
            //        foreach (var item1 in item.Value as int[])
            //            Console.WriteLine(item1);
            //    }

            //}

            //}





            //List bu yapı indexleme mantığıyla çalışır. dizilerden farklı olarak boyut belirtilmez dinamik olarak arttırılır.
            //List<int> tamSayilar = new List<int>()
            // {
            //     4,
            //     5,
            //     6
            // };
            //tamSayilar.Add(1);
            //tamSayilar.Add(2);
            //tamSayilar.Add(3);

            //Console.WriteLine($"liste eleman sayısı : {tamSayilar.Count}");
            //Console.WriteLine("tum elemanlar");
            //foreach (int sayi in tamSayilar)
            //{
            //    Console.WriteLine(sayi);
            //}

            //bool silindiMi =tamSayilar.Remove(2);
            //Console.WriteLine($"2 silindi mi {silindiMi}");


            //liste içersinde meyveleri saklayiniz. bu meyvelerden her gelenin  uzunluğu kadar alt tarafında meyveyi yanına * ekleyerek yazdırınız

            //List<string> meyveler = new List<string>()
            //{
            //   "elma",
            //   "armut",
            //   "kiraz"
            //};


            // foreach (string meyve in meyveler)
            //{
            //    for (int i = 0; i < meyve.Length; i++)
            //        Console.WriteLine(meyve);

            //}








            //kullanicidan alinan 5 adet sayiyi liste icersinde saklayiniz ve bu elemanların karelerini ekranda yazdiriniz
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("sayi veriniz");
                sayilar.Add(int.Parse(Console.ReadLine()));


            }
            foreach (int sayi in sayilar)
            {

                Console.WriteLine(sayi * sayi);
            }















        }
    }
}