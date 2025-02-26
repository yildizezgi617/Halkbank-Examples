namespace _10_DegerReferansTip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, };
            Console.WriteLine(sayilar[0]); //1

            int[] yeniSayilar = sayilar;  //adres kopyalaması

            yeniSayilar[0] = 2;
            Console.WriteLine(sayilar[0]);


            int sayi= 5;
            int yeniSayi=sayi ;

            yeniSayi = 1;
            Console.WriteLine(sayi); //5

            string metin = "abc";
            Console.WriteLine(metin[0]);

        }
    }
}