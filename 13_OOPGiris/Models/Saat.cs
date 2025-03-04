using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPGiris.Models
{
    
    public class Saat
    {
		private string _marka;
		private decimal _fiyat;
		//Fiyat 1 in altında olamasın
		public decimal Fiyat
		{
			get
			{
				return _fiyat;
			}
			set
			{
				if (value<0)
				{
					value = 0;
				}
				_fiyat = value;
			}
		}


		public string Marka
		{
			get {
				return _marka;
			}
			set {
				if (value.Length>5)
				{
					value = value.Remove(5);
                    _marka = value;
                }
				
			}
		}

	}
}
