namespace _08_HazirFonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Metinsel fonksiyonlar
            //string ifade = "www.NedenOlmasin.com";
            //Console.WriteLine( "metin uzunluğu "+ ifade.Length);
            //Console.WriteLine(ifade.ToLower());  //hepsini kucuk harfe cevirir
            //Console.WriteLine(ifade.ToUpper());   //hepsini buyuk harfe cevirir
            //Console.WriteLine(ifade.IndexOf('.')); //. charı kaçıncı indexteyse onu verir
            //Console.WriteLine(ifade.LastIndexOf('.')); //tersten aramaya başlar
            //Console.WriteLine(ifade.PadLeft(50,'a')); //belirtilen karakter sayısı kadar sol tarafına dolgu yapar.
            //Console.WriteLine(ifade.PadRight(50, 'a')); //belirtilen karakter sayısı kadar sağ tarafına dolgu yapar.
            //Console.WriteLine(ifade.Contains("neden")); // arama işlemi yapar varsa true yoksa false döner.
            //Console.WriteLine(ifade.Remove(3)); //baştan 3 karakteri alır
            //Console.WriteLine(ifade.Replace("com", "tr")); //com yerine tr yazdırır.
            //Console.WriteLine(ifade.TrimEnd());//ifadenin sonundaki oşlukları siler
            //Console.WriteLine(ifade.TrimStart()); //ifadenin tüm boşluklarını siler !!!! metnin ortasındaki boşluklar silmez

            //kullanıcının verdigi metin icersindeki aramak istedigi ifade var mı yok mu getiriniz
            //Console.WriteLine("metin veriniz");
            //string metin = Console.ReadLine();
            //Console.WriteLine("aratmak istediğiniz ifadeyi verin");
            //string ifade =Console.ReadLine();


            //Console.WriteLine(metin.Contains(ifade));


            //kullanıcıya cumle yazdır. bu cumlede hangi karakterin indexini istiyorsa sor ve getirt

            //Console.WriteLine("cumle yazınız");
            //string cumle = Console.ReadLine();

            //Console.WriteLine("hangi ifadenin indexini istiyorsunuz");
            //string index = Console.ReadLine();
            //Console.WriteLine(metin.IndexOf(index));



            // kullanıcıdan bir metin ve değiştirmek istediği ifadeyi alin. bu metin içersindeki bu ifadeyi degistirerek ve tum boşlukları silerek ekrana yazdırınız
            //Console.WriteLine("cumle yazınız");
            //string cumle = Console.ReadLine();

            //Console.WriteLine("degistirmek istediğiniz ifadeyi yazınız");
            //string ifade = Console.ReadLine();

            //Console.WriteLine("yerine yazacagınız ifadeyi yazınız");
            //string yeniIfade = Console.ReadLine();

            //Console.WriteLine(cumle.Replace(ifade,yeniIfade).TrimStart().TrimEnd());

            



            //Saısal Fonksiyonlar
            Console.WriteLine(Math.Floor(51.2));      //yuvarlama yapar
            Console.WriteLine(Math.Abs(-10));        // mutlak değeri verir
            Console.WriteLine(Math.Min(140,120));    //min olanı verir
            Console.WriteLine(Math.Max(100,50));      // max olanı verir
            Console.WriteLine(Math.Pow(5,2));     //us almak için kullanılır
            Console.WriteLine(Math.PI);                // pi sayısını verir
            Console.WriteLine(Math.E);              // e sayısını verir
            Console.WriteLine(Math.Sqrt(4));     // kok almak için kullanılır


            //karakter fonksiyonlar 
            Console.WriteLine(char.ToLower('A')); //karakteri küçültür
            Console.WriteLine(char.ToUpper('a'));  //karakteri buyutur


            //kullanıcıdan gelen 5 adet sayının en buyugunu ekrana yazdırınız
            //int x = int.MinValue;
            //double sayi;
            //Console.WriteLine("lutfen 5 adet sayı giriniz");
            //for (int i = 0; i < 6; i++)
            //{

            //    sayi = double.Parse(Console.ReadLine());

            //    x = (int)Math.Max(x, sayi);

            //}
            //Console.WriteLine(x);



            //dongulerde 01 ekranı yap
           
            Random random= new Random();
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(random.Next(2));
            }


         















            ////kullanıcının girdiği sayinin karesi kadar donerek ekranda  verdiği ismi bir buyuklu birkucuklu gösteriniz
            //Console.WriteLine("lutfen bir  sayı veriniz");
            //double sayi = double.Parse(Console.ReadLine());
            //Console.WriteLine("isim giriniz");
            //string isim = Console.ReadLine();

            //double karesi= Math.Pow(sayi,2);
            //for (int i = 0; i < karesi; i++)
            //{
            //    Console.WriteLine();
            //}








        }
    }
}