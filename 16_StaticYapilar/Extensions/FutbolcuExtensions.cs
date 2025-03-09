using _16_StaticYapilar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_StaticYapilar.Extensions
{
    internal static class FutbolcuExtensions
    {

        public static void RastgeleFormaNumarasıÜret(this Futbolcu futbolcu)
        {
            Random rnd = new Random();
            futbolcu.FormaNumarasi = rnd.Next(1, 100);



        }
        public static string TumBilgiler(this Futbolcu futbolcu)
        {
            return $"{futbolcu.Takim}--{futbolcu.FormaNumarasi}--{futbolcu.DogumTarihi}--{futbolcu.Takim}";
        }



        public static decimal MaasBonservisFarki(this Futbolcu futbolcu)
        {
            return futbolcu.Maas - futbolcu.Bonservis;
        }

    }
}
