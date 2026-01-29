using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class EvidenceManager
	{
		private Evidence bizonyitek;

		public EvidenceManager(Evidence bizonyitek)
		{
			this.bizonyitek = bizonyitek;
		}

		internal Evidence Bizonyitek { get => bizonyitek; set => bizonyitek = value; }
	}
}
