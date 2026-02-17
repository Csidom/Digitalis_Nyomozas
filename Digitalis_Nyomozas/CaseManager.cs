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
                return;
            }

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
}
