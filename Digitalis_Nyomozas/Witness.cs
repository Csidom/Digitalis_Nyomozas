using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Witness
	{
		private Person szemely;
		private string vallomas;
		private DateTime datum;

		public Witness(Person szemely, string vallomas, DateTime vallomas_datuma)
		{
			this.szemely = szemely;
			this.vallomas = vallomas;
			this.datum = vallomas_datuma;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public DateTime Datum { get => datum; set => datum = value; }
		internal Person Szemely { get => szemely; set => szemely = value; }

        public override string ToString()
        {
            return $"{this.Szemely.Nev} | Vallomás: {this.Vallomas} | Vallomás dátuma: {this.Datum.ToString("yyyy-MM-dd")}";
        }
    }
}
