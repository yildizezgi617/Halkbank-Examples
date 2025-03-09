namespace _16_StaticYapilar.Models
{
    internal class Motor
    {
        public static int id = 1;

        public Motor()
        {
            this.Id = id++;
        }


        public int Id { get; set; }

        public string Info()
        {
            return "Motor Bilgisi";
        }


    }
}
