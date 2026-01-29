using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class EvidenceManager
	{
		private List<Evidence>bizonyitekok;

		public EvidenceManager(List<Evidence> bizonyitekok)
		{
			this.bizonyitekok = bizonyitekok;
		}

		internal List<Evidence> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
	}
}
