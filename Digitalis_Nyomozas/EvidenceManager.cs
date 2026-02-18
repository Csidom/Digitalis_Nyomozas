using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalis_Nyomozas
{
	internal class EvidenceManager
	{
        public void AddEvidence(Case ugy)
        {
            Console.Write("Azonosító: ");
            string id = Console.ReadLine();

            Console.Write("Típus: ");
            string tipus = Console.ReadLine();

            Console.Write("Leírás: ");
            string leiras = Console.ReadLine();

            Console.Write("Megbízhatóság(1-10): ");
            int megbizhato = int.Parse(Console.ReadLine());

            Evidence e = new Evidence(id, tipus, leiras, megbizhato);

            ugy.Bizonyitekok.Add(e);

            Console.WriteLine("Bizonyíték hozzáadva.");
            Console.ReadKey();
        }

        public void ListEvidences(Case ugy)
        {
            Console.WriteLine();
            Console.WriteLine("--- Bizonyítékok ---");
            Console.WriteLine();
            foreach (var e in ugy.Bizonyitekok)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public void DeleteEvidence(Case ugy)
        {
            Console.Write("Bizonyíték azonosítója: ");
            string id = Console.ReadLine();

            var talalat = ugy.Bizonyitekok.FirstOrDefault(b => b.Azonosito == id);
            if (talalat != null)
            {
                ugy.Bizonyitekok.Remove(talalat);
                Console.WriteLine("Bizonyíték törölve.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen azonosító.");
            }
            Console.ReadKey();
        }
    }
}
