using _19_Abstraction.Models;

namespace _19_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Abstraction soyutlamak manasına gelen oop prensiplerinden birisidir. Tek başına bir şeyy ifade etmemektedir. abstract class tek gorevi miras vermektir. Bu türdeki classlardan nesne orneği uretilememektedir.

            //Oyun oyun = new Oyun(); //Hata verir
            //Oyun içersindeki bilgi metodunun tüm oyunlarda aynı çalışıp metin2 de farklı çalışmasını istiyoruz karakterler ve yarkalr da gozuksun.

            Pubg pubg = new Pubg();
            pubg.Ad = "Pubg";
            pubg.Platformlar = new List<string>()
            {
                "Mobil","Pc"
            };
            Console.WriteLine(pubg.Bilgi());
            Console.WriteLine(pubg.Saldir());

            WolfTeam wolfTeam = new WolfTeam();
            wolfTeam.Ad = "WolfTeam";
            wolfTeam.Platformlar = new List<string>()
            {
                "Pc"
            };

            Console.WriteLine(wolfTeam.Bilgi());
            Console.WriteLine(wolfTeam.Saldir());


            Mario mario = new Mario();
            mario.Ad = "Mario";
            mario.Platformlar = new List<string>()
            {
                "Mintendo"
            };
            Console.WriteLine(mario.Bilgi());
            Console.WriteLine(mario.Saldir());



            Metin2 metin2 = new Metin2()
            {
                Id = 1,
                Ad = "Metin2",
                CikisYili = DateTime.Now,
                Bayraklar = new List<string>()
                {
                    "Kırmızı","Mavi","Sarı"
                },
                Bolumler = new List<string>()
                {
                    "Alesta","Ergenokon","Dodurga"
                },
                Karakterler = new List<string>()
                {
                    "Ninja","Sura","Lycan","Şaman","Savasci"
                },
                Nesneler = new List<string>()
                {
                    "Dolunay Kilici","Siyah Çelik","Mavi Çelik","Kirmizi Demir Pala"
                },
                Platformlar = new List<string>()
                {
                    "Mobil","Pc"
                }






            };
            Console.WriteLine(metin2.Bilgi());
            Console.WriteLine(metin2.Saldir());



            //Bir çiçek, papatya orkide,lale,lavanta,bitki siniflarini oluşturarakher birine 3er property yaziniz. bu proplar ayri olarak her birinin full ozelliklerini ekrana yazdıran metot oluşturunuz. Son olarak cicekler için gecerli yasam surelerini ekrana yazdiran ama bu hesaplamanın bazı cicek turleri için değiştirilebileceği goz onunde bulundurularak yasam suresini hesaplayan bir metot oluşturunuz. Idler otomatik artsın.

            //Hayvan,Omurgali,Omurgasiz,Surungen,Memeli,Yilan,Aslan,Kanarya,Yarasa,Kartal,Kedi,Kopek modellerini oluşturunuz ve miras operasyonunu gerçekleştiriniz. idler otomatik artsın

            //Urun,Bilgisayar, masaustu,laptop,telefon,Koltuk,Sandalye Masa,Hali,Sehpa, Camasır makinesi modelleri oluşturulsun. Ham nesnelerin hepsinde tum ozelliklerin isimleri ekrana yazdirilsin. Random fiyat oluşturucu metodu default olarak 10000 90000 arasında belirlenmisken istenilen bazi modeller bunu degistirebilsin idler otomatik artsın


            
            //



        }

    }
}
