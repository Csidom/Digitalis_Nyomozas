using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class TimelineEvent
	{
		private DateTime datum;
		private string esemeny_leiras;

		public TimelineEvent(DateTime datum, string esemeny_leiras)
		{
			this.datum = datum;
			this.esemeny_leiras = esemeny_leiras;
		}

		public DateTime Datum { get => datum; set => datum = value; }
		public string Esemeny_leiras { get => esemeny_leiras; set => esemeny_leiras = value; }

        public override string ToString()
        {
            return $"Dátum: {datum.ToString("yyyy-MM-dd")} | Leírás: {esemeny_leiras}";
        }
    }
}
