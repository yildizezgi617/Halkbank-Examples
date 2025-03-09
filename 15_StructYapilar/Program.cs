using _15_StructYapilar.Models;

namespace _15_StructYapilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ad = "Hakan";
            //int yas = 18;

            Kitap kitap = new Kitap();
            kitap.Id = 5;
            kitap.KitapAdi = "Garibanlar";

            // Bitki seklinde bir struct olusturunuz. Icerisinde ad,turu,omru,boy,renk,cinsiyet, yaprakturu, zehirliMi ozelliklerini barindirsin.
            // * Ad min 3 karakter max 50 karakter olsun sinir disi olanlarda otomatik tamamlama veya kirtma olsun.
            // * Tur bos gecilemez ve 15 karakterden fazla olamaz.
            // * Omru en fazla 54000 yil olsun
            // * Boy negatif girilirse random atansin
            // * Cinsiyet bos gecilemez eger bos olursa random atansin
            // * Yaprak turu 2 karakterden az olamaz.

            Bitki bitki = new Bitki();

            bitki.Tur = "papatya";
            Console.WriteLine(bitki.Tur);
            bitki.Omur = 60;
            Console.WriteLine(bitki.Omur);
            bitki.Boy = -1;
            Console.WriteLine(bitki.Boy);
            bitki.Cinsiyet = " ";
            Console.WriteLine(bitki.Cinsiyet);
            bitki.LeafType = "lllll";
            Console.WriteLine(bitki.LeafType);

        }
    }
}
