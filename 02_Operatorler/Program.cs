

namespace _02_Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Mantiksal Operatorler (ve : && veya : ||)

            //// VE ( && )
            //Console.WriteLine(true && true);   // True
            //Console.WriteLine(false && true);  // False
            //Console.WriteLine(true && false);  // False
            //Console.WriteLine(false && false); // False

            //// VEYA ( || )
            //Console.WriteLine(true || true);  // True
            //Console.WriteLine(true || false);  // True
            //Console.WriteLine(false || true);  // True
            //Console.WriteLine(false || false);  // True

            //// Karsilastirma Operatorleri (  <,>,==,!=,<=,>=  )
            //// Karsilastirmlar true veya false cevabini getirir.
            //Console.WriteLine( 1 < 5 );      // True  
            //Console.WriteLine( 1 > 5 );      // False
            //Console.WriteLine( 5 <= 5 );     // True
            //Console.WriteLine( 5 >= 5 );     // True
            //Console.WriteLine( "a" == "b" ); // False
            //Console.WriteLine( "a" != "b" ); // True

            //// Aritmetik Operatorler
            //Console.WriteLine("a"+"b");  // ab
            //Console.WriteLine(1  + 2);   // 3
            //Console.WriteLine( "1" + 2 + 3  );// 15
            //Console.WriteLine( 1+2+"3"+5 );   // 335 

            //Console.WriteLine(5 - 5); // 0
            //Console.WriteLine(5 / 5); // 1
            //Console.WriteLine(5 * 5); // 25
            //Console.WriteLine(5 % 3); // 2


            //int sayi = 5;
            //sayi = sayi + 1; // 6 
            //sayi++;          // 7
            //++sayi;          // 8
            //sayi += 1;       // 9
            //Console.WriteLine(sayi);

            //int eskiSayi = 0;
            //int yeniSayi = eskiSayi++;
            //Console.WriteLine(yeniSayi);

            //// Kullanici adi ve parolayi bir degisken uzerinde saklayiniz. Kullanici giris yapabilirmi kontrol ediniz.
            //string kullaniciAdi = "admin";
            //string parola = "admin";
            //bool girisYapabilirMi = kullaniciAdi == "admin" && parola == "admin";
            //Console.WriteLine("Giris yyapabilirmi : "+girisYapabilirMi);


            //// Iki sayidan ilki buyukmu sorusuna cevabi bir degiskende saklayiniz. Buna gore dogru soyleme durumunuzu ekranda yazdiriniz.
            //int sayi1 = 5;
            //int sayi2 = 10;
            //bool ilkSayiBuyukMu = sayi1 > sayi2;
            //Console.WriteLine($"{sayi1} > {sayi2} : {ilkSayiBuyukMu}");

            //// Iki adet meyveyi degiskenlerde saklayiniz bu meyveleri, birbiri ile ayni mi yazdiriniz.
            //string meyve1 = "Ejder Meyvesi";
            //string meyve2 = "Papaya";
            //Console.WriteLine( meyve2 == meyve1 );

            //// 3 gunluk cay miktari 15 bardak olmasi bekleniyor. Degiskenler gun gun cay miktarlarini yazdiriniz. Bu miktar ortalama altinda kaliyormu kontrol ediniz.
            //int miktar1 = 3;
            //int miktar2 = 2;
            //int miktar3 = 28;
            //int toplam = miktar1 + miktar2 + miktar3;
            //int ortalama = toplam / 3;
            //Console.WriteLine($"Ortalama Altindami : {ortalama < 15}");

            //// Kalem 5 tl, defter 10 tl ve satin alacak kisinin 30 tl si var. 5 adet kalem yada 3 adet defter almak istiyor. 5 kalem ve 3 defteri ayni anda alabilirmi.
            //int param = 30, kalem = 5,defter = 10;
            //bool alabilirMi = (kalem * 5 + defter * 3) <= param;
            //Console.WriteLine($"Alabilirmiyim : {alabilirMi}");

            //// Arac yili 2010 uzerinde ve km 200000 de olan araci kabul goruyoruz. Eger yil daha dusukse veya km daha fazlaysa almiyoruz. Buna gore bu araci alabilirmisiyiz kontrol ediniz.
            //int aracYili = 2010;
            //int km = 200000;

            //Console.WriteLine("Alirmiyim bu araci : "+(aracYili > 2010 && km <= 200000));

            //// Kullanici adi,parola,ad,soyad,dogumyili,telefon numarasi,tc kimlik numarasini degiskende saklayiniz. İlgili kullanicinin bilgilerini ekranda alt alta yazdiriniz. Girilen parola telefon numarasi veya tc kimlik numarasina denkse uyeligi kabul durumu false, denk degilse farkliysa true olsun.
            //string kullaniciAdi = "busracelik";
            //string ad = "Büşra";
            //string soyad = "Celik";
            //string parola = "1234";
            //int dogumyili = 2000;
            //string telefon = "123456";
            //string tcno = "456789";

            //string kullaniciBilgileri = $"Kullanici Adi : {kullaniciAdi}\nad:{ad}\nsoyad:{soyad}\nparola:{parola}\ndogumyili:{dogumyili}\ntelefon:{telefon}\ntcno:{tcno}";
            //Console.WriteLine(kullaniciBilgileri);

            //bool uyelikkabul = !(parola == telefon || parola == tcno); // false || false = false => !false = true
            //Console.WriteLine($"üyelik kabul:{uyelikkabul}");

            //// Kitabin adi, yazari, cikisyili,yayincisini ve konularini degiskenlerde saklayarak ekranda alt alta yazdiriniz. Konularin basinda * olsun.
            //string kitapAdi = "Kuyucaklı Yusuf";
            //string yazarAdi = "Sebahattin Ali";
            //int cikisYili = 1937;
            //string yayinci = "Yapı Kredi Yayınları";
            //string konular = "*Toplumsal sınıf farkları\n*Aşk\n*Bireyin Yalnızlığı\n*Toplumsal Adaletsizlik";
            //string kitapBilgileri = $"Kitap Adı : {kitapAdi} \nYazar: {yazarAdi}\nÇıkış Yılı: {cikisYili}\nYayıncı: {yayinci}\nKonular\n{konular}";
            //Console.WriteLine(  kitapBilgileri);

            //// 3 gunluk hava durumu sicaklik bilgisini degiskende saklayiniz. Bu hava durumunun 3 gunde toplam 60 derece ve ustu olursa Kar tuttumu durumu false, eger altinda olursa kar tuttu durumu :true olsun.
            //int gun1 = 15, gun2 = 10, gun3 = 5;
            //int toplam = gun1 + gun2 + gun3;
            //bool karliMi = toplam < 60;
            //Console.WriteLine(  "Kar Tuttu Mu ? : " +karliMi);

            //// 2 adet tam sayidan ilkinin 3 e gore , 2. sinin 5 e gore modu birbirine esitmi kontrol ediniz.
            //int sayi1 = 10;
            //int sayi2 = 20;
            //int sayi1Mod = (sayi1 % 3); 
            //int sayi2Mod= (sayi2 % 5);
            //bool esitMi = sayi1Mod == sayi2Mod;
            //Console.WriteLine($"{sayi1} % 3 = {sayi1Mod} \n{sayi2} % 5 = {sayi2Mod}\n{sayi1Mod} == {sayi2Mod} : {esitMi}");

            //// 3 adet metinsel ifadeyi degiskenlerde saklayiniz. Bunlari ekranda yazdirip yazilim dilimi kontrolu yapiniz.
            //string dil1 = "C#";
            //string dil2 = "Java";
            //string dil3 = "Dart";

            //string kullaniciDegeri = "C#";

            //bool teyit = (dil1 == kullaniciDegeri || dil2 == kullaniciDegeri || dil3 == kullaniciDegeri);
            //Console.WriteLine(  $"doğruluk değeri: {teyit}");

            //Console.WriteLine($"Teyit:{dil1==kullaniciDegeri}|| ");

            //// 5 Gunde toplam 15lt su icmesi gereken bir insanin 5 gun boyunca ictigi sular degiskenlerde saklaniyor. Bu 5 gun sonunda tam olarak su icebildimi?
            //int gun1 = 4; 
            //int gun2 = 3; 
            //int gun3 = 1;
            //int gun4 = 4;
            //int gun5 = 2;
            //int acikKalanMiktar;

            //int gunToplam = gun1+ gun2 + gun3 +gun4 + gun5;
            //int toplamGerekenSu = 15;
            //bool tamOlarakSuIctiMi = (gunToplam >= toplamGerekenSu);
            //acikKalanMiktar = toplamGerekenSu - gunToplam;
            //Console.WriteLine("5 gunde yeterli su icti mi: "+ tamOlarakSuIctiMi +"\nGereken su miktarı: "+ acikKalanMiktar);

            //// Bir adet meyveyi degiskende saklayiniz. Bu meyvenin meyvemi oldunu aliniz. Kullanici cevabina gore yalan soyleme durumunu ekrana yazdiriniz.
            //string meyve = "Elma";

            //Console.WriteLine($"{meyve} bir meyve mi?");
            //string cevap = "Evet";
            //bool meyvemMi = cevap == "Evet";
            //Console.WriteLine(meyvemMi);

            //// 10 * 15 = 140 ifadesi dogrumu yanlismi ekranda yazdiriniz.
            //byte numberOne = 10;
            //byte numberTwo = 15;
            //int result = numberOne * numberTwo;
            //bool isSucces = result == 140;
            //Console.WriteLine($"{numberOne} * {numberTwo}  = 140 : Sonuç doğru mu?: {isSucces} ");

            //// Sanatci Sezen Aksu, sarkisi Biliyorsun olarak dogru kabul ediliyor. Eger soylenen sarki ve sanatci bu kisiler degilse ekranda Sarkici durumu : false, sanatciysa Sarkici durumu : true seklinde ekranda yazilsin.
            //string sanatci = "Sezen AKSU";
            //string sarki = "Biliyorsun";

            //string girilenSanatci = "Sezen AKSU";
            //string girilenSarki = "Biliyorsun";

            //bool sarkiciDurumu = (girilenSanatci == sanatci && girilenSarki == sarki);
            //Console.WriteLine($"Şarkıcı durumu:{sarkiciDurumu}");


            //// 3 oyuncu skoru alinsin bu skorlar uzerinden ilk skora sahip oyuncu birincimi kontrol edilsin.
            //int player1 = 50;
            //int player2 = 40;
            //int player3 = 30;

            //bool isLeading = player1 > player2 && player1 > player3;

            //Console.WriteLine($"player1 is leading: {isLeading}");

            //// Kullanici notuna gore dersi gecebilme durumunu ekranda yazdiriniz. 50 ve uzeri geçer not. Not sistemi 0-100 arasinda olmalidir.
            //int sinavNotu = 75;
            //int gecmeNotu = 50;
            //bool gectiMi = sinavNotu >= gecmeNotu && sinavNotu>=0 && sinavNotu<=100;
            //Console.WriteLine("Dersten geçti mi? "+gectiMi);

            //// Girilen sayinin ciftmi oldugunu soyleyiniz.
            //int sayi1 = 3;
            //bool ciftMi = sayi1 % 2 == 0;
            //Console.WriteLine($"{sayi1} Çift Mi : {ciftMi}");

            //// Bir bankanin yillik cirosu 1000000000 Tl dir. Bu banka 4 aylik toplam cirosunu paylasiyor yil bazinda kar yapildimi kontrol ediniz.
            //decimal bankaCiro = 1000000000m;
            //decimal ilkDortAylikCiro = 300000000m;

            //decimal ikinciDortAylikCiro = 200000000m;
            //decimal ucuncuDortAylikCiro = 800000000m;

            //decimal buYilkiToplamKazanc = ilkDortAylikCiro + ikinciDortAylikCiro + ucuncuDortAylikCiro;

            //bool kardaMi = buYilkiToplamKazanc > bankaCiro;
            //Console.WriteLine("Bankanın yıllık cirosu karda mı:" +kardaMi);
            //decimal karMiktari = buYilkiToplamKazanc - bankaCiro;
            //Console.WriteLine("ne kadar kardayız:"+karMiktari);



            //// 5 sesli 3 sessiz harfi degiskenlerde saklayip yan yana sesli sessiz gelecek sekilde ekranda yazdiriniz.

            //char vowel1 = 'a';
            //char vowel2 = 'e';
            //char vowel3 = 'i';
            //char vowel4 = 'o';
            //char vowel5 = 'u';

            //char consonant1 = 'k';
            //char consonant2 = 'd';
            //char consonant3 = 'r';

            //string result = $"{consonant1}{vowel1}{consonant2}{vowel3}{consonant3}";

            //Console.WriteLine( result );

            //// Girilen sayinin 3 e gore modunun karesi sayinin kendisine esit mi kontrolu yapiniz.
            //int sayi = 8;
            //int sayiMod = sayi % 3;
            //int sayiModKare = sayiMod * sayiMod;
            //bool esitMi = sayi == sayiModKare;
            //Console.WriteLine($"{sayi} ile {sayiModKare} birbirine eşit mi :{esitMi}");

            //// 80 metrekare uzerindeki evlerde balkon bulunuyor kullanicinin verdigi metrekare bilgisine gore evde balkon varmi tahmin ediniz.
            //int limit = 80;
            //int evinMetreKaresi = 85;
            //bool balkonVarMi = (evinMetreKaresi > limit);
            //Console.WriteLine($"Balkon var mi?: {balkonVarMi}");

            //// Yaricapi 2 birim olan bir dairenin alani ile, belirtilen karenin alani birbirine denkmidir kontrol ediniz.
            //decimal daireAlan = (3.14m * 2 * 2);
            //decimal kareAlan = 5 * 5;
            //bool esitMi = daireAlan == kareAlan;
            //Console.WriteLine($"Daire'nin alanı:{daireAlan}\nKarenin alanı:{kareAlan}");
            //Console.WriteLine($"Aynı alanı kaplıyorlar mı? {esitMi}");

            //// Fide olarak dikilen bir bitki ilk asamada 1cm dir. Gunluk 1.5 kat buyume gerceklestiren bir fidenin 5. gunun sonunda boyu 1 metreyi asiyormu kontrolu yapiniz.
            //decimal ilkBoyu = 1m;
            //decimal uzamaBoyu = 1.5m;
            //decimal ilkGun= ilkBoyu *uzamaBoyu;
            //decimal ikinciGun= ilkGun * uzamaBoyu;
            //decimal ucuncuGun= ikinciGun * uzamaBoyu;
            //decimal dorduncuGun= ucuncuGun * uzamaBoyu;
            //decimal besinciGun= dorduncuGun * uzamaBoyu;
            //bool istek = (besinciGun > 100);
            //Console.WriteLine(  "son boyu "+besinciGun+" istek ise : "+ istek);


            //// Bir papatya uzerinde seviyor sevmiyor denemesi yapiliyor. 5 yaprakli olan bu papatyada seviyor ile baslandiginda sonuc 5. yaprak seviyora denk geliyormu kontrol ediniz.
            //byte nthLeaf = 5;
            //bool isLoving = nthLeaf % 2 == 1;
            //Console.WriteLine($"Seviyor mu: {isLoving}");

            //// Belirtilen perdenin kisa kenari 2 birim,uzun kenari 3 birimdir. Alani 3 metrekare olan bir cami ortebilirmi kontrolu yapiniz.
            //int kisaKenar = 2;
            //int uzunKenar = 3;
            //int perdeAlani = kisaKenar * uzunKenar;
            //int camAlani = 3;
            //bool camiOrtebilirMi = perdeAlani >= camAlani;
            //Console.WriteLine($"Cami ortebilir mi? : {camiOrtebilirMi}");

            //// 5 adet kitap alabilen kutu icerisine gonderilen kitaplarin hepsi sigiyormu kontrol ediniz.
            //int kapasite = 5;
            //int gonderilenKitapSayisi = 3;
            //bool kitaplarSigiyorMu=gonderilenKitapSayisi<=kapasite;
            //Console.WriteLine($"Kitaplar Sığıyor Mu: {kitaplarSigiyorMu}");

            //// Belirtilen 3 asal sayinin toplaminin 2 fazlasi 3 e tam bolunuyormu kontrol ediniz.
            //int asalSayi1 = 3;
            //int asalSayi2 = 5;
            //int asalSayi3 = 7;
            //int toplam = asalSayi1 + asalSayi2 + asalSayi3;

            //bool kontrol = (toplam + 2) % 3 == 0;

            //Console.WriteLine($"{asalSayi1} + {asalSayi2} + {asalSayi3}={toplam}\nIki fazlasi{toplam+2}\nToplamın 2 fazlası 3'e tam bölünüyor mu : {kontrol}");


            //// Girilen sayi hem 3e hemde 5 e ayni anda bolunuyormu kontrol ediniz.
            //int number = 15;
            //bool isSucces = number % 3 == 0 && number % 5 == 0;

            //Console.WriteLine($"3' e ve 5'e tam bölünüyor mu?: {isSucces}");
        }
    }
}