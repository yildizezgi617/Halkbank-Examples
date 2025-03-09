namespace _13_OOPGiris.Models
{
    // * FirstName en az 2 en fazla 25 karakter olmalidir.
    // * Soyad en az 2 en fazla 25 karakter olmalidir.
    // * Emial icerisinde @ ifadesi yok ise default@mail.com seklinde atansin.
    // * Parola min 3 karakterli max 10 karakterli olmalidir. Eger aksi durum var ise random karakterlerden olusan 10 karakterli default deger atilmalidir.
    // * Kullanici adi min 3 max 5 olmalidir aksi durum var ise 4 haneli random bir kullanici adi belirtilsin
    // * Telefon numarasi 11 karakterli olmalidir aksi durumda yildiz tamamlamasi veya kirpma yapiniz.
    // * Dogum tarihi 18 yasin altinda ise 18 yasina tamamlansin.

    public class Users
    {
        //public string Id { get; set; } = "";
        //public string FirstName;
        //public string LastName;
        //public string Email;
        //public string Password;
        //public string UserName;
        //public string Phone;
        //public DateTime BirthDay;
        //public bool IsActive;

        //private string _firstname;

        //public string FirstName
        //{
        //    get
        //    { return _firstname; 
        //    }
        //    set
        //    {
        //        if (value.Length < 2)
        //        {
        //            value = value.PadRight(2, 'a');
        //            _firstname = value;
        //        }
        //        else if (value.Length > 25)
        //        {
        //            value = value.Remove(25);
        //            _firstname = value;
        //        }
        //        _firstname = value;
        //    }
        //}

        //private string _lastName;
        //public string LastName
        //{
        //    get
        //    {
        //        return _lastName;
        //    }
        //    set
        //    {
        //        if (value.Length < 2)
        //        {
        //            value = value.PadRight(2, '*');
        //            _lastName = value;
        //        }
        //        else if (value.Length > 25)
        //        {
        //            value = value.Remove(25);
        //            _lastName = value;
        //        }
        //        _lastName = value;

        //    }

        string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Contains('@') && value.Contains('.')) _email = value;

                else _email = "default@gmail.com";
            }
        }
        string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                if (value.Length > 3 && value.Length < 10)
                {
                    _password = value;
                }
                else
                {
                    _password = Guid.NewGuid().ToString().Substring(1, 4);
                }
            }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set
            {
                string randomHarfler = "CLVŞDÖCVXLĞEAĞDASELKASDLŞFSİŞDFSLGLCŞVŞLİSF";
                Random rnd = new Random();
                string uName = "";

                if (!(value.Length >= 3 && value.Length <= 5))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        uName += randomHarfler[rnd.Next(randomHarfler.Length)];
                    }
                    value = uName;

                }




                userName = value;
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (value.Length < 11)
                {
                    value = value.PadLeft(11, '*');
                }
                else if (value.Length > 11)
                {
                    value = value.Substring(0, 11);
                }
                phoneNumber = value;
            }

        }
        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set
            {
                if (DateTime.Now.Year - value.Year < 18)
                    value = new DateTime(DateTime.Now.Year - 18, value.Month, value.Day);

                _birthDate = value;
            }
        }

    }
}
