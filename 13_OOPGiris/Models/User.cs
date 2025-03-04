using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPGiris.Models
{
    //firstname en az 2 en fazla 25 karakter olalı
    //soyad en az 2 en fazla 25 karakter olmalıdır.
    //email adresinde @ ifadesi yoksa dafult@mail.com şeklinde atansın
    //parola min3 max10 karakterli olmalıdır. eğer aksi durum varsa random karakterlerden oluşan 10 karakterli default deper atanmalıdır.
    //kullanıcı adı min 3 max 5 olmalidir. aksi durum var ise 4 haneli random 1 kullanıcı adı belirtilsin.
    // telefon no 11 hane olmalı aksi halde kırpma veya * ekleme yapılmalı.
    public class User
    {
        

        string _firstname;

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                if (value.Length < 2)
                {
                    value = value.PadRight(5, '*');
                    _firstname = value;
                }
                else if (value.Length > 25)
                {
                    value = value.Remove(25);
                    _firstname = value;
                }




            }
        }

        private string _lastname;

        public string  LastName
        {
            get
            { 
                return _lastname; 
            }
            set
            {
                if (value.Length<2)
                {
                    value = value.PadRight(2, '*');
                    _lastname = value;

                }
                else if (value.Length>25)
                {
                    value = value.Remove(5);
                    _lastname = value;
                       
                }
                _lastname = value;
            }
        }

        private string _email;

        public string Email
        {
            get 
            { return _email; 
            }
            set
            {
                if (!value.Contains("@"))
                {
                    value = "default@mail.com";
                    _email = value;
                }
                _email = value;
            }
        }

        private string _password;

        public string Password
        {
            get
            { return _password; 
            }
            set
            {
                if (value.Length<3 || value.Length>10)
                {
                    _password = value;
                }
                for (int i = 0; i < 10; i++)
                {
                    Random rnd = new Random();        //farklı yöntemi de var bak.Guid
                    int sayi = rnd.Next(1, 10);
                    value = value+sayi;

                }
                _password = value;
               
            }
        }

        private string _username;

        public string UserName
        {
            get
            { return _username; 
            }
            set
            {
                string randomHarfler = "qwertyuıldşklndmhöşmndmşlmtlşmşmbmş";
                Random rnd = new Random();
                string uName = "";
                if (!(value.Length>3 && value.Length<5))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        uName += randomHarfler[rnd.Next(randomHarfler.Length)];
                    }
                    value = uName;
                }
                value = uName;
            }
        }




    }
}

