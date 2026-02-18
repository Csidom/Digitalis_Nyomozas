using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class Person
	{
		private string nev;
		private int eletkor;
		private string leiras;

		public Person(string nev, int eletkor, string leiras)
		{
			this.nev = nev;
			this.eletkor = eletkor;
			this.leiras = leiras;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Eletkor { get => eletkor; set => eletkor = value; }
		public string Leiras { get => leiras; set => leiras = value; }

        public override string ToString()
        {
			return $"{this.nev} | {this.eletkor} év | {this.leiras}";
        }
    }
}
