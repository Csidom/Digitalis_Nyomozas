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
		private DateTime vallomas_datuma;

		public Witness(Person szemely, string vallomas, DateTime vallomas_datuma)
		{
			this.szemely = szemely;
			this.vallomas = vallomas;
			this.vallomas_datuma = vallomas_datuma;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public DateTime Vallomas_datuma { get => vallomas_datuma; set => vallomas_datuma = value; }
		internal Person Szemely { get => szemely; set => szemely = value; }
	}
}
