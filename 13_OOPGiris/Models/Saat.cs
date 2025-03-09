namespace _13_OOPGiris.Models
{
    public class Saat
    {
        // Fiyat 0 in altinda olamasin.
        decimal _fiyat;
        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                if (value < 0)
                    value = 0;

                _fiyat = value;
            }
        }

        //Marka en fazla 5 karakter olabilir.
        string _marka;
        public string Marka
        {
            get
            {
                // Atanmis bire degeri okuyabilmek icin kullanilan metottur. Geriye ilgili property tipinde deger dondurur. 
                return _marka;
            }
            set
            {
                // Atama islemi esnasinda kullanilan metottur. Yani esittir ifadesini koyup bir deger verdiginizde set calisir.
                // Value : Default parametredir ilgili ozell,g,n tipine burunur ve disaridan set edilmeye calisan degeri yakalar.

                if (value.Length > 5)
                    value = value.Remove(5);

                _marka = value;
            }
        }


        public string Model;
        public string Kordon;
    }
}
