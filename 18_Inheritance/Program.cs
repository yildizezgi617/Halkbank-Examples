using _18_Inheritance.Models;
using _18_Inheritance.Models2;

namespace _18_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Seller seller = new Seller()
            //{
            //    Id = 1,
            //    Address = "Adres",
            //    CompanyName = "nedenolmasin",
            //    Email = "bla@nedenolmasin.com",
            //    Password = "password",
            //    PhoneNumber = "1234567890",
            //    UserName = "username"
            //};

            //Console.WriteLine(seller.Id);
            //Console.WriteLine(seller.UserName);
            //Console.WriteLine(seller.Email);
            //Console.WriteLine(seller.PhoneNumber);
            //Console.WriteLine(seller.Address);
            //Console.WriteLine(seller.Password);

            //Console.WriteLine("\n________________________________________\n");

            //User user = new Seller()
            //{
            //    Id = 1,
            //    Address = "Adres",
            //    CompanyName = "nedenolmasin",
            //    Email = "bla@nedenolmasin.com",
            //    Password = "password",
            //    PhoneNumber = "1234567890",
            //    UserName = "username"
            //};

            //Console.WriteLine(user.Id);
            //Console.WriteLine(user.UserName);
            //Console.WriteLine(user.Email);
            //Console.WriteLine(user.PhoneNumber);
            //Console.WriteLine(user.Password);

            // Urun,Telefon,Tablet,Televizyon modellerini olusturarak hepsinde ortak olan ozellikleri base de toplayiniz.

            Telefon telefon = new Telefon()
            {
                EkranBoyutu = "1inc",
                Fiyat = 123,
                Islemci = "AMD",
                Marka = "Armut",
                Model = "SX PRO MAX",
                Operator = "Turkcell",
                Ram = 3,
                Renk = "Mavi"
            };





        }
    }
}
