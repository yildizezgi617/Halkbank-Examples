namespace _03_Donusturmeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sayisal bir ifadeyi metinsele metinsel bir ifadeyi sayisala donusturme islemidir. Convert ile donusturme islemi yaparken sayisaldan farkli bir sayisal tipe veya metinselden sayisal bir tipe donusturme islemi gercekletirebiliriz. Eger donusturme islemi yapilamz ise yani gelen ifade sayisala donusebilecek birsey degilse hata verecektir. Parse kullanmak istersek sadece metinselden istenilen tipe donusturme islemi yaptigini bilmemiz gerekir.

            // CONVERT
            string ifade = "55";
            short shortSayi = Convert.ToInt16(ifade);
            Console.WriteLine($"ShortSayi : {shortSayi}");
            int intSayi = Convert.ToInt32(shortSayi);
            Console.WriteLine($"IntSayi : {intSayi}");
            long longSayi = Convert.ToInt64(intSayi);
            Console.WriteLine($"Long Sayi: {longSayi}");
            float floatSayi = Convert.ToSingle(intSayi);
            Console.WriteLine($"Float Sayi: {longSayi}");

            // PARSE
            int sayi = int.Parse("55");
            Console.WriteLine($"Parse Sayi : {sayi}");
            bool dogruMu = bool.Parse("True");
            Console.WriteLine(dogruMu);

            // Metinsel olarak saklanan 3 adet sayinin toplamini sayisal bir degiskende saklayarak ekrana yazdiriniz.
            string sayi1 = "1";
            string sayi2 = "2";
            string sayi3 = "3";

            int yeniSayi1 = int.Parse(sayi1);
            int yeniSayi2 = int.Parse(sayi2);
            int yeniSayi3 = int.Parse(sayi3);

            int toplam = yeniSayi1 + yeniSayi2 + yeniSayi3;
            Console.WriteLine(toplam);

            // CAST
            // Ayni kategorideki ifadeleri birbirine rica minnet ile kabul ettirilmesi durumudur.
            int kucukTip = 5;
            long buyukTip = kucukTip;

            // kucukTip = buyukTip; // Veri kaybina sebep olacagindan hata verir.
            kucukTip = (int)buyukTip;

            object bilinmeyenSayi = 5;
            int? bilinenSayi = bilinmeyenSayi as int?;

        }
    }
}