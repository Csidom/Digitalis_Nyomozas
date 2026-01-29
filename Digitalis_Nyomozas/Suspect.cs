using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Suspect
	{
		private Person szemely;
		private int gyanu_szint;
		private string statusz;

		public Suspect(Person szemely, int gyanu_szint, string statusz)
		{
			this.szemely = szemely;
			this.gyanu_szint = gyanu_szint;
			this.statusz = statusz;
		}

		public int Gyanu_szint { get => gyanu_szint; set => gyanu_szint = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Person Szemely { get => szemely; set => szemely = value; }
	}
}
