using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class CaseStatus
	{
		private string ugy_azonosito;
		private string aktualis_allapot;

		public CaseStatus(string ugy_azonosito, string aktualis_allapot)
		{
			this.ugy_azonosito = ugy_azonosito;
			this.aktualis_allapot = aktualis_allapot;
		}

		public string Ugy_azonosito { get => ugy_azonosito; set => ugy_azonosito = value; }
		public string Aktualis_allapot { get => aktualis_allapot; set => aktualis_allapot = value; }
	}
}
