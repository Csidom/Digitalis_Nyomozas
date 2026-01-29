using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Evidence
	{
		private string azonosito;
		private string tipus;
		private int megbizhatosag;

		public Evidence(string azonosito, string tipus, int megbizhatosag)
		{
			this.azonosito = azonosito;
			this.tipus = tipus;
			this.megbizhatosag = megbizhatosag;
		}

		public string Azonosito { get => azonosito; set => azonosito = value; }
		public string Tipus { get => tipus; set => tipus = value; }
		public int Megbizhatosag { get => megbizhatosag; set => megbizhatosag = value; }
	}
}
