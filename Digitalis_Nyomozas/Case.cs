using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Case
	{
		private string ugy_azonosito;
		private string cim;
		private string leiras;
		private CaseStatus allapot;
		private List<Person> szemelyek;
        private List<Suspect> gyanusitottak;
        private List<Witness> tanuk;
        private List<Evidence> bizonyitekok;

		public Case(string ugy_azonosito, string cim, string leiras)
		{
			this.ugy_azonosito = ugy_azonosito;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = new CaseStatus(CaseStatus.CaseState.Nyitott);
			this.szemelyek = new List<Person>();
			this.gyanusitottak = new List<Suspect>();
			this.tanuk = new List<Witness>();
			this.bizonyitekok = new List<Evidence>();
		}

		public string Ugy_azonosito { get => ugy_azonosito; set => ugy_azonosito = value; }
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public CaseStatus Allapot { get => allapot; set => allapot = value; }
		public List<Person> Szemelyek { get => szemelyek; set => szemelyek = value; }
        public List<Suspect> Gyanusitottak { get => gyanusitottak; set => gyanusitottak = value; }
        public List<Witness> Tanuk { get => tanuk; set => tanuk = value; }
		public List<Evidence> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
    }
}
