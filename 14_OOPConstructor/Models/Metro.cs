using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPConstructor.Models
{
    class Metro
    {
        //ct tab tab dendiğinde oluşur.
        //:this() yaptığımda akış şu şekilde ilk passengercapacityli olanı çalıştırıcam o gidip mesaj olanı tetikliycek o da boş olanı tetikli,ycek ilk once boş olanın içi çalışcak sonra mesajlı olanın içi en son passengercapacity
        public Metro()
        {
            Console.WriteLine("Yapıcı  method çalışti");
        }
        public Metro(string mesaj) : this() // boş olanı tetikler
        {
            Console.WriteLine(mesaj);
        }

        public Metro(int passengercapacity) :this("mesaj")   //mesajlı olanı tetikler
        {
            if (passengercapacity<0)
            {
                passengercapacity = 0;              //passengercapacity nin set işlemi burda yapılıyor setini kaldırdık.
            }
            this.PassengerCapacity = passengercapacity;
            
        }

        public int PassengerCapacity { get; }
        public decimal FuelPrice { get; set; }
        ~Metro()
        {
            //Destructor : Yikici method. Bu metot ram uzerinden ilgili nesnenin isi bitirilip kaldırıldığı esnada calıştırılır. zaman bağımsız çalışmaktadır. kullanımı tercih edilmez.
        }
    }
}
