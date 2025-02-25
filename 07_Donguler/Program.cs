namespace _07_Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        // durum true olduğu sürece döngü devam eder.false olursa döngü sonlanır

            //        //while (//Durum(true ya da false olur.))
            //        // {

            //        // }
            //        //int sayac = 0;
            //        //while (sayac<10)
            //        //{
            //        //    Console.WriteLine(sayac);      
            //        //    sayac++; //sayac=sayac+1   sayac +=1
            //        //}

            //        //kullanıcıdan 5 sayı al,topla ekrana yazdır. hata yönetimi de yap.
            //        int i = 0;
            //        int toplam=0;
            //        start:

            //        try
            //        {
            //            while (i < 5)
            //            {
            //                Console.WriteLine("sayi giriniz");
            //                toplam += int.Parse(Console.ReadLine());

            //                i++;

            //            }
            //            Console.WriteLine(toplam);

            //        }
            //        catch (Exception ex)
            //        {

            //            Console.WriteLine(ex.Message);
            //            goto start;
            //        }
            //        finally {
            //            Console.WriteLine(toplam);
            //                }

            //        while (i<5)
            //        {
            //            Console.WriteLine("sayi giriniz");
            //            toplam+=int.Parse(Console.ReadLine());

            //            i++;

            //        }
            //        Console.WriteLine(toplam);



            //        //kullanıcıdan 5 kelime al ve yazdır
            //        int y = 0;
            //        string sonuc = "";
            //        while (y<5)
            //        {
            //            y++;
            //            Console.WriteLine("kelime giriniz");

            //            sonuc += Console.ReadLine()+"\n";


            //        }
            //        Console.WriteLine("sonuç"+sonuc);




            //        //kullanıcıdan gelen 3 sayının ortalamasını al
            //        double sayi = 0;
            //        int sayac = 0;


            //        try
            //        {
            //            while (sayac < 3)
            //            {

            //                Console.WriteLine("sayi girin");
            //                sayi += double.Parse(Console.ReadLine());
            //                sayac++;

            //            }
            //            Console.WriteLine("ortalama =" + sayi / 3);
            //        }
            //        catch (FormatException ex)
            //        {

            //            Console.WriteLine("hata"+ex.Message);
            //        }
            //        finally { Console.WriteLine("ortalama"+ sayi/sayac); }



            //        //kullaniciya rastgele 3 sayı gösteriniz. Bu sayıların toplamını sorunuz. doğru ya da yalan söylediğini yazınız.
            //        Random  random = new Random();

            //        try
            //        {
            //            int x = 0;
            //            int toplamx = 0;
            //            int sayix;
            //            start2: 
            //            while (x < 3)
            //            {
            //                sayix = random.Next(1, 10);
            //                Console.WriteLine(sayix);
            //                toplamx += sayix;
            //                i++;


            //            }
            //            Console.WriteLine("sayiların değeri kaç");
            //            int cevap = int.Parse(Console.ReadLine());
            //            if (cevap == toplamx)
            //            {
            //                Console.WriteLine("dogru cevap verdin");
            //            }
            //            else
            //            {
            //                Console.WriteLine("yanlış cevap verdin");
            //            }

            //            Console.WriteLine($"sayilarin toplami{toplam}");
            //        }
            //        catch (FormatException ex)
            //        {

            //            Console.WriteLine("yanliş format");
            //            goto start2;
            //        }







            //        //kullanıcıdan gelen 3 sayidan hangisinin daha buyuk oldugunu sorunuz buna gore yalan mi dogru mu soyledigini yazdiriniz.
            //        int count=0;
            //        int num=int.MinValue;


            //        while (count<3)
            //        {
            //            Console.WriteLine("please enter a num");
            //            int input =Convert.ToInt32(Console.ReadLine());
            //            if (input > num)
            //            {
            //                num = input;

            //            }
            //            count++;
            //        }
            //        Console.WriteLine("greatest: ");
            //       int total= Convert.ToInt32(Console.ReadLine()); 
            //        if (total ==num)
            //        {
            //            Console.WriteLine("correct");
            //        }
            //        else
            //        {
            //            Console.WriteLine("wromg");
            //        }


            //        //Do while 
            //        //koşul sağlansa da sağlanmasa da 1 kere çalışır.


            //        //do
            //        //{
            //        //    //tekrar edilecek kodlar
            //        //} while (true);



            //        //baglanti saglanana kadar istek atiniz
            //        bool baglantiKurulduMu = false;
            //        do
            //        {
            //            Console.WriteLine("baglanti durumu"+ baglantiKurulduMu);
            //            baglantiKurulduMu = true;

            //        } while (baglantiKurulduMu);


            //FOR
            //for (iterasyonu saglayacak degisken; kosul; iterasyon)


            //0 100 aralıgında fizzbuzz oyununu oynatınız
            //for (int i = 0; i < 100; i++)
            //{
            //    if(i%3==0 && i%5==0)
            //    {
            //        Console.WriteLine(i+"fizzbuzz");
            //    }
            //    else if (i%3 ==0)
            //    {
            //        Console.WriteLine(i+"fizz");
            //    }
            //    else if (i%5 ==0)

            //    {
            //        Console.WriteLine("buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine("oyun dişi");
            //    }

            //}



            // kullanıcıdan bir aralık alarak bu aralıktaki sayıların toplamını yazdırınız
            //int toplam = 0;
            //Console.WriteLine("lutfen bir deger giriniz");
            //int deger1= int.Parse(Console.ReadLine());
            //Console.WriteLine("lutfen bir deger giriniz");
            //int deger2 = int.Parse(Console.ReadLine());
            //int toplam=0;

            //for (int i = deger1; i <= deger2+1; i++)
            //{
            //    toplam += i;
            //}
            //Console.WriteLine("toplam"+toplam);


            //kullanıcının verdiği aralıktaki çift sayıların toplamini ekrana yazdırınız
            //Console.WriteLine("lutfen bir deger giriniz");
            //int deger1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("lutfen bir deger giriniz");
            //int deger2 = int.Parse(Console.ReadLine());
            //int toplam = 0;
            //for (int i = deger1; i < deger2; i++)
            //{
            //    bool isEven =i %2 == 0;
            //    if(isEven)
            //    {
            //        toplam = toplam + 1;
            //    }
            //}
            //Console.WriteLine(toplam);


            //0 100 aralığındaki çift sayılar ile tek sayılar arasındaki fark nedir.
            //int ciftToplam = 0;
            //int tekToplam = 0;
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftToplam += i;
            //    }
            //    else
            //        tekToplam+= i;  
            //}
            //int fark = ciftToplam - tekToplam;
            //if (fark < 0)
            //    fark = fark * -1;
            //Console.WriteLine(fark);


            ////carpim tablosunu yazdiriniz 
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i}x{j}={i*j}");
            //    }
            //}


            //kullanicidan 5 adet metinsel ifade aliniz bunlardan kaç tanesi meyve karar veriniz
            //string a = "";
            //string b = "elma";
            //string c = "karpuz";
            //string d = "armut";
            //int sayac = 0;


            //for (int i = 0; i < 6; i++)
            //{

            //    Console.WriteLine("meyve yaz");
            //    a = Console.ReadLine();

            //    if (a ==b  || a ==c|| a== d)
            //    {
            //       sayac++;
            //    }


            //}
            //Console.WriteLine(sayac);

            //kullanıcının girdigi sayinin ussunu isteyerek cevaplandiriniz

            //Console.WriteLine("bir sayi giriniz");
            //int sayi =int.Parse(Console.ReadLine());
            //Console.WriteLine("üs değeri veriniz");
            //int us = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 0; i < us; i++)

            //{
            //    sonuc *= sayi;
            //}
            //Console.WriteLine(sonuc);


            //ekranda menu gosteriliyor ilk olarak menu alt kısmında ıcerikler.3 menu 3 içerik olacak menuleri de içerikleri de kullanıcılar verecek


            //string sonucbaslık = "";
            //string icerikbaslik = "";

            //string menuBaslık = "";
            //string menuIcerik = "";
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("menu gir");
            //    menuBaslık = Console.ReadLine();
            //    sonucbaslık = menuBaslık + sonucbaslık;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("içerik gir");
            //        menuIcerik = Console.ReadLine();
            //        icerikbaslik = icerikbaslik + "\n" + menuIcerik;
            //    }
            //    Console.WriteLine($"*{sonucbaslık} \n{icerikbaslik}");
            //}
            //Console.WriteLine(menuBaslık+menuIcerik );



            //2. çözüm
            //string menu= "";
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("menu içerigini giriniz");
            //    menu += Console.ReadLine() + "\n";
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("menu icerigini yazin");
            //        menu += Console.ReadLine() + "\n";
            //    }
            //    menu += "\n";
            }

            ////continue aşama atlatmak için kullanılır
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i >= 4 && i <= 6)
            //        continue;
            //    Console.WriteLine(i);
            //}

            //kullanıcıdan 5 ifade iste bu ifadelerden meyve olanlarını alt alta yazdırınız
            //string meyveler = "";
            //string meyve1 = "elma";
            //string meyve2 = "armut";
            //string meyve3 = "kavun";

            //for (int i = 0; i < 6; i++)
            //{
            //    string ifaede= Console.ReadLine();
            // 
            //    if (ifade == meyve1 || deger == meyve2 || deger == meyve3)
            //    {
            //        meyveler +=ifade+"\n";
            //        continue;
            //    }
            //    Console.WriteLine("bu bir meyve degildir");
            //}
            //Console.WriteLine(meyveler);

            //kullanıcıdan pozitif bir aralık aliniz 0 ile 100 arasında belirtilen aralık olmadan ekrana gelen sayiların toplamını yazdırınız

            //Console.WriteLine("sayi giriniz");
            //int ilkDeger = int.Parse(Console.ReadLine());

            //Console.WriteLine("sayi giriniz");
            //int sonDeger =int.Parse(Console.ReadLine());

            //int toplam = 0;
         
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (ilkDeger<=i && sonDeger<i)
            //    {
                
            //        continue;
            //    }

            //    toplam += i;

            //}
            //Console.WriteLine("");


            //3 kez kullanıcının girdiğ sayı çiftse karesini ekrana tekse bir fazlasını ekrana yazdırın




            //çarpım tablosunu 5ler olmayacak şekilde yazınız


            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (j == 5)
            //        {
            //            continue;

            //        }
            //        Console.WriteLine($"{i}x{j}={i * j}");
            //    }

            //break dongulerde kullanıldığında ilgili donguyu kırmak için kullanılır
            // 0 dan 10 a kadar giden bir döngü oluşturunuz döngü içerisinde 5 e denk gelindiğinde dongu sonlansın

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //        break;
            //}

            //kullanıcı sınırsız olarak sayı girebilsin gelen sayı tek ise toplama dahil edilmesin sadece ciftleri toplama dahil ederek kullanıcı e haricinde herhangi bir tuşa basana kadar sormaya devam edelim
            //işlem bitiminde ne kadar sayı girdiyse toplamını ekrana yazdıralım

            int toplam = 0;
            string cevap = "";
            int sayi=0;

            for (int i = 0; true ; i++)
            {
                Console.WriteLine("Devam edilsin mi e ya da h,");
                cevap = Console.ReadLine();

                if (cevap == "e")
                {

                    Console.WriteLine($"{i + 1}.seferde sonlandi");
                    break;
                }
                
                Console.WriteLine("bir sayi giriniz");
                 sayi = int.Parse(Console.ReadLine());
                if (sayi %2 ==0)
                {
                    toplam += sayi;
                }

                Console.WriteLine(toplam);
               
                
              

            }

            //min 0 max 10000000 arasında 3 basamaklı bir sayı gelene kadar ekranda sayiları  yazdiriniz.bu deger geldiği anda donguyu sonlandırınız kacıncı seferde geldigini ve hangisi oldugunu ekranda yazdiriniz
            Random rnd = new Random();
            bool devamMi = true;
            int istenilenSayi = 0;
            for (; devamMi;)
            {
                istenilenSayi =rnd.Next(1,10000001);
                Console.WriteLine(istenilenSayi);
                if (istenilenSayi>=100&& istenilenSayi <100)
                {
                    break;
                }
                Console.ReadLine();
            }



            //min 0 



        }
    }
}