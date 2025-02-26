namespace _11_Metotlar
{
    internal class Program
    {
        //metot belirli görevleri yerine getiren parametrelerdir. çağrılmadan kullanılmaz kesinlikle çağrılması gerekir.
        // deger donduren ve dondurmeyen olarak ikiye ayrılır. bunlar da parametre alan ve almayan olarak ikiye ayrılır.

        //ekrana kullanıcının girdiği adı karakterlerine bölerek alt alta yazdıran method oluşturun

        //ekrana rastgele 5 sayı yazdıran method oluşturun

        // 5 adet evin temizliğini sirasiyla yapan metot oluşturunuz


        // ekrana bir gun her şey daha guzel olacak cumlesinin karakter uzunluğu kadar 

        static void Main(string[] args)
        {
            Selamla();
            EkranaRastgele();
            DaireTemizle();
            Cumle();

            
           
 
        }


        //geriyeDonusTipi methodAdi(){

        //}

        #region Geriye deger dondurmeyen ve parametre almayan  methodlar
        //void: hiçlik yokluk. bu değper tipi geriye deger dondurmeyecegini belirtir. geriye değer dondurmuyor bir şeye atayamam

        static void Selamla () {

            Console.WriteLine("merhaba");
        }

        static void EkranaRastgele() { 
        Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next(1,7));
            }
        
        }

        static void DaireTemizle() {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{i}. daire temizlendi");
            }

            static void KarakterlerineBolen()
            {

                Console.WriteLine("metin girin");

            }

            static void Cumle()
            {
                string cumlemiz = "bir gun her şey cok guzel olacak";

                for (int i = 0; i < cumlemiz.Length; i++)
                {
                    Console.WriteLine("bir gun her şey cok guzel olacak");
                }


            }
        }
        static void Cumle()
        {
            string cumlemiz = "bir gun her şey cok guzel olacak";

            for (int i = 0; i < cumlemiz.Length; i++)
            {
                Console.WriteLine("bir gun her şey cok guzel olacak");
            }

        }


            #endregion



            #region Geriye deger dondurmeyen parametre alan methodlar

            #endregion
        }
}