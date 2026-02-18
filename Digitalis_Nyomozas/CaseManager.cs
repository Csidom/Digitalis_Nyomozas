using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class CaseManager
	{
		private DataStore datastore;

        public CaseManager(DataStore datastore)
        {
            this.datastore = datastore;
        }

        public void CreateCase()
        {
            Console.Write("Ügy azonosító: ");
            string id = Console.ReadLine();
            Console.Write("Cím: ");
            string cim = Console.ReadLine();
            Console.Write("Leírás: ");
            string leiras = Console.ReadLine();
            Case ujUgy = new Case(id, cim, leiras);
            datastore.Ugyek.Add(ujUgy);
            Console.WriteLine("Ügy sikeresen hozzáadva!");
            Console.ReadKey();
        }

        public void ListCases()
        {
            if (datastore.Ugyek.Count == 0)
            {
                Console.WriteLine("Nincs rögzített ügy.");
            }

            foreach (var c in datastore.Ugyek)
            {
                Console.WriteLine($"Azonosító: {c.Ugy_azonosito} | Cím: {c.Cim} | Leírás: {c.Leiras} | Állapot: {c.Allapot.CurrentState}");
            }

            Console.ReadKey();
        }

        public void ChangeCaseStatus()
        {
            Console.Write("Add meg az ügy azonosítóját: ");
            string id = Console.ReadLine();

            Case selectedCase = datastore.Ugyek.FirstOrDefault(c => c.Ugy_azonosito == id);

            if (selectedCase == null)
            {
                Console.WriteLine("Nincs ilyen ügy.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("1 - Nyitott");
                Console.WriteLine("2 - Folyamatban");
                Console.WriteLine("3 - Lezárt");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        selectedCase.Allapot.ChangeStatus(CaseStatus.CaseState.Nyitott);
                        break;
                    case 2:
                        selectedCase.Allapot.ChangeStatus(CaseStatus.CaseState.Folyamatban);
                        break;
                    case 3:
                        selectedCase.Allapot.ChangeStatus(CaseStatus.CaseState.Lezart);
                        break;
                }
                Console.WriteLine("Állapot módosítva.");
                Console.ReadKey();
            }

        }

        public void AddSuspect(Case ugy)
        {
            Console.Write("Név: ");
            string nev = Console.ReadLine();

            Console.Write("Életkor: ");
            int kor = int.Parse(Console.ReadLine());

            Console.Write("Leírás: ");
            string leiras = Console.ReadLine();

            Console.Write("Gyanú szint: ");
            int gyanu = int.Parse(Console.ReadLine());

            Console.Write("Státusz: ");
            string statusz = Console.ReadLine();

            Person p = new Person(nev, kor, leiras);
            Suspect s = new Suspect(p, gyanu, statusz);

            ugy.Gyanusitottak.Add(s);

            Console.WriteLine("Gyanúsított hozzáadva.");
            Console.ReadKey();
        }

        public void AddWitness(Case ugy)
        {
            Console.Write("Név: ");
            string nev = Console.ReadLine();

            Console.Write("Életkor: ");
            int kor = int.Parse(Console.ReadLine());

            Console.Write("Leírás: ");
            string leiras = Console.ReadLine();

            Console.Write("Vallomás: ");
            string vallomas = Console.ReadLine();

            Console.Write("Vallomás dátuma(éééé-hh-nn): ");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            Person p = new Person(nev, kor, leiras);
            Witness w = new Witness(p, vallomas, datum);

            ugy.Tanuk.Add(w);

            Console.WriteLine("Tanú hozzáadva.");
            Console.ReadKey();
        }

        public void ListPeople(Case ugy)
        {
            Console.WriteLine("--- Gyanúsítottak ---");
            Console.WriteLine();
            foreach (var s in ugy.Gyanusitottak)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("--- Tanúk ---");
            Console.WriteLine();
            foreach (var t in ugy.Tanuk)
            {
                Console.WriteLine(t);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
