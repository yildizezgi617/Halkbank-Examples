namespace _14_OOPConstructor.Models
{
    internal class Metro
    {
        public Metro()
        {
            Console.WriteLine("Bir metro satin alindi...");
        }
        public Metro(string mesaj) : this()
        {
            Console.WriteLine(mesaj);
        }

        public Metro(int passangerCapasity) : this("mesaj")
        {
            if (passangerCapasity < 0)
                passangerCapasity = 0;

            this.PassengerCapacity = passangerCapasity;

            Console.WriteLine("Kapasite : " + this.PassengerCapacity);
        }

        public int PassengerCapacity { get; set; }
        public decimal FuelPrice { get; set; }





        // Destructor : Yikici metot. Bu metot ram uzerinden ilgili nesnenin isi bitirilip kaldirilacagi esnada calistirilir. Zaman bagimsiz calismaktadir kullanimi tercih edilmez.
        //Random random = new Random();
        //Console.WriteLine(random.Next(0,10));
        //public Metro(int id)
        //{
        //    _id = id;
        //}
        //int _id;
        //~Metro()
        //{

        //    Console.WriteLine(_id);
        //}
    }
}
