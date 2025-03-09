using _16_StaticYapilar.Models;

namespace _16_StaticYapilar.Extensions
{
    internal static class MotorOzellestirme
    {
        public static void Bilgi(this Motor motor)
        {
            Console.WriteLine($"{motor.Id} Bilgi verildi...");
        }
    }
}