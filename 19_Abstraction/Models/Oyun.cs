using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Abstraction.Models
{
   abstract class Oyun  //newlenemez
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public DateTime CikisYili { get; set; }
        public List<string> Platformlar { get; set; }



        public virtual string Bilgi()   //virtual ezilebilir. govdesi dolu olabilir. genelde birçok sınıfta ortak olup bir iki sınıfta ististnası olan methodlar için kullanılır.
        {

            string metin = $"{Id},{Ad},{CikisYili}";
            foreach (var item in Platformlar)
            {
                metin += $" \n ***{item}";
            }
            return metin ;
        }

        public abstract string Saldir();   //abstract methodların gövdesi olmaz diğer sınıflar govedelerini kendi içlerinde doldurur.
       
          
        }
    }

