namespace _06_HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Try catch blokları ile hataları yönetebiliriz. Hata Oluşabilecek durumlarda kullanılır.
            //exception
            try
            {
               // kodu buraya yazıyoruz, burdaki kodlarda hata oluşması muhtemel
            }
            catch (Exception) //tüm genel hataları yakalar
            {

                throw;
            }

           // 2 sayıyı kullanıcıdan alıp bölelim
            Console.WriteLine("bir sayı girin");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("bir sayı girin");
            int sayi2 = int.Parse(Console.ReadLine());
            double bolmeSonucu = sayi1 / sayi2;   //0 a bölme, kullanıcıdan yanlış girdi alma gibi hatalar alabiliriz.

            try
            {
                //2 sayıyı kullanıcıdan alıp bölelim
                Console.WriteLine("bir sayı girin");
                int sayi11 = int.Parse(Console.ReadLine());
                Console.WriteLine("bir sayı girin");
                int sayi12 = int.Parse(Console.ReadLine());
                double bolmeSonucu1 = sayi1 / sayi2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("hata mesajı" + ex.Message);   //tüm hataları yakalar ve hatanın mesajını yazdırır.

            }

            //Hataları özelleştirebiliriz bunun için catch bloklarını çoğaltıcaz ve exceptionu özelleştiricez
            try
            {
                //2 sayıyı kullanıcıdan alıp bölelim
                Console.WriteLine("bir sayı girin");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine("bir sayı girin");
                int sayi2 = int.Parse(Console.ReadLine());
                double bolmeSonucu = sayi1 / sayi2;
            }
            catch (FormatException)
            {
                Console.WriteLine("bu bir format hatası doğru formatta girin ");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("sıfıra bölünme hatası");
            }
            catch (Exception)
            {
                Console.WriteLine("harici hatalar");
            }
            finally
            {
                Console.WriteLine("kesinlikle çalışacak kodlar");
            }

            // kullanicidan bir sayi alıp karesini ekrana yazdırınız
            try
            {
                Console.WriteLine("sayi verin");
                int sayi =int.Parse(Console.ReadLine());
                int carpım = sayi * sayi;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
              
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            

            
        }
    }
