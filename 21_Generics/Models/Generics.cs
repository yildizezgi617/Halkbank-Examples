using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Generics.Models
{
    class Generics
  
    {
        internal class AracKoleksiyonu<T> where T : Arac, new()
        {
            private List<T> araclar = new List<T>();

            public void Ekle(T arac)
            {
                araclar.Add(arac);
            }

            public void Sil(int index)
            {
                if (index >= 0 && index < araclar.Count)
                {
                    araclar.RemoveAt(index);
                }
                else
                {
                    throw new IndexOutOfRangeException("Geçersiz indeks.");
                }
            }

            public T Getir(int index)
            {
                if (index >= 0 && index < araclar.Count)
                {
                    return araclar[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Geçersiz indeks.");
                }
            }
        }
    }

}

