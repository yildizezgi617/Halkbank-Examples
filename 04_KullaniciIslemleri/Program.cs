namespace _04_KullaniciIslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Console.ReadLine() : Console uzerinden yazilan satiri alip bize metinsel olarak getirir.
            //Console.Write("Bir ifade gir : ");
            //string kullaniciGirdisi = Console.ReadLine();
            //Console.WriteLine($"Girilen ifade : {kullaniciGirdisi}");

            // Kullanicidan gelen sayinin karesini aliniz.
            //Console.Write("Bir sayı girin:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int kare = sayi * sayi;
            //Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");

            //Console.Write("Bir sayı girin:");
            //int sayi = int.Parse(Console.ReadLine());
            //int kare = sayi * sayi;
            //Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");


            //// Kullanicidan gelen sayi ciftmi ekrana yazdiriniz.
            //Console.WriteLine(  "sayi giriniz:");
            //int sayi =Convert.ToInt32(Console.ReadLine());
            //int kalan = sayi % 2; 
            //Console.WriteLine( $"Ciftmi {kalan == 0}");


            //// Kullanicidan adini ve dogum yilini alarak ekranda X y-1 yasindadir seklinde yazdiriniz.
            //Console.Write("Adınızı giriniz: ");
            //string name = Console.ReadLine();

            //Console.Write("Doğum yılınızı giriniz: ");
            //int birthYear = int.Parse(Console.ReadLine());

            //int age = 2025 - birthYear;
            //Console.WriteLine($"{name} kişisi {age - 1} yaşındadır.");


            //// 3 Gunluk kar yagis miktari 45 saatin uzerinde olursa kar tutma durumu true, 45 saatin altinda kalirsa tutma durumu false seklinde olsun.
            //Console.Write("First day amount: ");
            //int firstDayAmount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Second day amount: ");
            //int secondDayAmount = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Third day amount: ");
            //int thirdDayAmount = Convert.ToInt32(Console.ReadLine());

            //int totalAmount = firstDayAmount + secondDayAmount + thirdDayAmount;
            //bool isSnowHolding = totalAmount > 45;

            //Console.WriteLine($"Total Amount: {totalAmount}");
            //Console.WriteLine($"Snow holding status: {isSnowHolding}");

            // // Kullanicidan marka,model,fiyat alarak fiyata ne kadar zam yapmak istedigini sorunuz ve zam oranina gore ekrana marka model ve yeni fiyatla yazdiriniz.
            // Console.Write("Marka giriniz: ");  // Kullaniciya cikti veriyoruz
            // string marka = Console.ReadLine(); // Kullanicinin girdigi degeri aliyoruz(string)
            // Console.Write("Model giriniz: ");  // Cikti gosteriyoruz
            // string model = Console.ReadLine(); // Model icin girilen veriyi aliyoruz
            // Console.Write("Fiyat giriniz: ");  // Fiyati girmesi icin cikti gosteriyoruz
            // string fiyatGirdisi = Console.ReadLine(); // Metinsel olark fiyat bilgini cekiyoruz
            //decimal fiyat =  Convert.ToDecimal(fiyatGirdisi); // Metinsel olarak girilen fiyati sayisal degere donusturuyoruz

            // Console.Write("Ne kadar zam yapmak istersiniz: "); // Zam oranini girmesi icin cikti veriyoruz
            // string zamOrani = Console.ReadLine(); // Kullanicinin girdigi metinsel orani alip getiriyor 
            // decimal uygulananZamOrani = Convert.ToDecimal(zamOrani); // Metinsel zam oranini sayisala ceviriyor
            // decimal yeniFiyat = (1+uygulananZamOrani) * fiyat; // Fiyata zam oranini uygulayarak yeni bir fiyat olusturuyoruz.   
            // Console.WriteLine($"{marka} {model} ' in yeni fiyati: {yeniFiyat}' dir."); // Toplanan tum bilgilere gore ekrana rapor mahiyetinde cikti veriyoruz.

            //// Ortalama 65 yil omru bulunan bir kisinin yasini alarak geride yaklasik kac gunu kaldigini yazdiriniz.
            //Console.Write("Yasinizi Giriniz:  ");
            //string girdiYas = Console.ReadLine();
            //int yas = int.Parse(girdiYas);
            //int kalanYil = 65 - yas;
            //Console.WriteLine($"Ölmenize {kalanYil * 365} Gün Kaldi");

            //// Kullanici gunluk calisma saatlerini, yol suresini, yemek surelerini ve diger aktivitelerinin surelerini soyluyor. Buna gore uyku icin ayirdigi sureyi yazdiriniz.

            //int toplamGunlukSaat = 24;
            //Console.Write("Günlük çalışma süresi :");
            //int calismaSaati = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Günlük yol süresi :");
            //int yolSaati = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Günlük yemek süresi : ");
            //int yemekSaati = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Günlük aktiviteler için ayırdığınız süre : ");
            //int digerAktiviteler = Convert.ToInt32(Console.ReadLine()); 

            //int uykuSuresi = toplamGunlukSaat - (calismaSaati + yolSaati + digerAktiviteler +yemekSaati);
            //Console.WriteLine($"Uyku için kalan süreniz : {uykuSuresi} saat");

            //// Kullaniciya iki sayi soyleyip bu sayilardan ilki buyukmu sorusuna karsilik true veya false cevabini alarak Yalan soyleme durumunu ekrana yazdiriniz.
            //int sayi1 = 5, sayi2 = 10;
            //Console.WriteLine($"[{sayi1},{sayi2}]\n1. Sayi buyukmu? [true/false]");
            //bool cevap = bool.Parse(Console.ReadLine());
            //bool karsilastirma = sayi1 > sayi2;
            //bool sonuc = !(karsilastirma == cevap);
            //Console.WriteLine($"yalan söyleme durumu: {sonuc}");    

            //// Belirtilen saat ve dakikada alarm kuran bir kisinin alarm kurdugu vakite kadar kac dakikasi oldugunu yazdiriniz.
            //Console.WriteLine("lütfen bir saat giriniz:");
            //int saat = int.Parse(Console.ReadLine())+1;    
            //Console.WriteLine("lütfen dakika giriniz:");
            //int dakika=int.Parse(Console.ReadLine());      
            //Console.WriteLine("lütfen alarm kurmak istediğiniz saati giriniz:");
            //int ayarlananSaat=int.Parse(Console.ReadLine());

            //int saatFarki = ayarlananSaat-saat;
            //int dakikaFarki = (saatFarki * 60) + (60 - dakika);
            //Console.WriteLine($"{saatFarki} saatiniz kaldı ve dakika olarak {dakikaFarki} dk kaldı");

            //// Bir odayi 60 dakikada isitan bir dogalgaz sistemi icin. Kullanicidan dogalgazi kac dakika once actigini sorarak, kac dk icerisinde tamamen isinacagini soyleyiniz.
            //Console.WriteLine(  "doğalgazı kaç dakika önce açtınız");
            //int acmaDakikasi = Convert.ToInt32( Console.ReadLine() );
            //int kalanSure = 60 - acmaDakikasi;
            //Console.WriteLine(  $"odanız {kalanSure} dakika sonra ısınacaktır");

            //// 25 yil calisarak ve 60 yasini doldurarak emekli olan birisine kac gundur calistigi ve yasi soruluyor. Buna gore emekli olmasi icin gereken prim gunu ve yasi icin kac gunu kaldigini ayni zamanda emekli olabilirlik durumunu ekranda yazdiriniz.
            //Console.Write("Kaç gündür çalışıyorsunuz? : ");
            //int calismaGunu = int.Parse(Console.ReadLine());
            //Console.Write("Kaç yaşındasınız? : ");
            //int yas = int.Parse(Console.ReadLine());
            //bool emekliOlabilirMi = yas >= 60 && calismaGunu / 365 > 25;
            //Console.WriteLine($"Emekli olabilir misiniz? {emekliOlabilirMi}");
            //int kalanGun = 25 * 365 - calismaGunu;
            //int kalanYas = 60 - yas;
            //Console.WriteLine($"Emekliliğe kalan gününüz: {kalanGun}\nKalan yaş: {kalanYas}.\nSayılı gün çabuk geçer. Çalışmaya devam... :)");

            //// Bir termus 5lt kapasitededir. Bu termusun icindeki sivi miktarini(lt) sorarak devaminda ne kadar daha doldurmak istegini sorunuz. Gonderilen miktara gore termusun tasma durumunu ekranda yazdiriniz.
            //int kapasite = 5;
            //Console.WriteLine("Termosun içindeki sıvı miktarını(lt) giriniz: ");
            //int mevcutSivi=int.Parse(Console.ReadLine());
            //Console.WriteLine("Ne kadar sıvı eklemek istersiniz? ");
            //int eklenecekSivi=int.Parse(Console.ReadLine());    
            //int toplamSivi=mevcutSivi+eklenecekSivi;
            //bool tasmaDurumu = toplamSivi > kapasite;
            //Console.WriteLine("Termos taştı mı? "+ tasmaDurumu);

            //// Bir fabrika bu yilki kazancini ve yillik buyume oranini paylasiyor. Buna gore 5 yil sonra bu fabrikanin maddi buyuklugu ne kadar olur?
            //Console.Write("Bu yilki kazanc? :");
            //decimal buYilkiKazanc = decimal.Parse(Console.ReadLine());
            //Console.Write("Yillik buyume orani ? :");
            //float yillikBuyumeOrani=float.Parse(Console.ReadLine());

            //decimal ilkYil = (decimal)(1+yillikBuyumeOrani)* buYilkiKazanc;
            //decimal ikinciYil= (decimal)(1 + yillikBuyumeOrani) * ilkYil;
            //decimal ucuncuYil= (decimal)(1 + yillikBuyumeOrani) * ikinciYil;
            //decimal dorduncuYil= (decimal)(1 + yillikBuyumeOrani) * ucuncuYil;
            //decimal besinciYil= (decimal)(1 + yillikBuyumeOrani) * dorduncuYil;

            //Console.WriteLine($"Sirketin 5 yil sonra son maddi durumu : {besinciYil}");

            // Bir kisi yol mesafesini ve hizini belirtiyor buna gore ne kadar surede varmak istedigi yere varir.
            Console.WriteLine("yol mesafesini girin(km)");
            double mesafe = double.Parse(Console.ReadLine());

            Console.WriteLine("Hızınızı girin(km/saat)");
            double hiz = double.Parse(Console.ReadLine());
            double sure = mesafe / hiz;
            Console.WriteLine($"varış süresi:{sure}saat");



        }
    }
}