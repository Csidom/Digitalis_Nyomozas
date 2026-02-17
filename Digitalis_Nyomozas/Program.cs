using System.ComponentModel;
using System.Windows.Markup;

namespace Digitalis_Nyomozas
{
    internal class Program
    {

        static DataStore datastore = new DataStore();
        static CaseManager caseManager = new CaseManager(datastore);

        static void ugykezeles()
        {
            bool vissza = false;
            while (!vissza)
            {
                Console.Clear() ;
                Console.WriteLine("""
                    ---Ügyek kezelése---

                    1. Új ügy hozzáadása
                    2. Ügyek listázása
                    3. Ügy állapot módosítása
                    4. Vissza
                    """);
                bool valaszt = false;
                int valasztas = 0;
                while (!valaszt)
                {
                    Console.Write("Választás: ");
                    valasztas = int.Parse(Console.ReadLine());
                    if (valasztas < 1 || valasztas > 4)
                    {
                        Console.WriteLine("Nincs ilyen menüpont!");
                    }
                    else
                    {
                        valaszt = true;
                    }
                }

                switch (valasztas)
                {
                    case 1:
                        caseManager.CreateCase();
                        break;
                    case 2:
                        caseManager.ListCases();
                        break;
                    case 3:
                        caseManager.ChangeCaseStatus();
                        break;
                    case 4:
                        vissza = true;
                        break;
                }
            }
        }

        static void szemelykezeles()
        {

        }

        static void bizonyitekkezeles()
        {

        }

        static void idovonal()
        {

        }

        static void elemzes()
        {

        }



        static void Main(string[] args)
        {
            bool vege = false;
            while (!vege)
            {
                Console.Clear();
			    Console.WriteLine("""

                    Digitális Nyomozó

                        ---Menü---
                    1. Ügyek kezelése
                    2. Személyek kezelése
                    3. Bizonyítékok kezelése
                    4. Idővonal megtekintése
                    5. Elemzés/döntések
                    6. Kilépés

                    """);

			    Console.Write("Adja meg a választott menüpont sorszámát: ");
                int menupont = int.Parse(Console.ReadLine());

                switch (menupont)
                {
                    case 1:
                        ugykezeles();
                        break;
				    case 2:
					    szemelykezeles();
                        break;
				    case 3:
					    bizonyitekkezeles();
                        break;
				    case 4:
					    idovonal();
                        break;
				    case 5:
					    elemzes();
                        break;
				    case 6:
                        vege = true;
					    break;
			    }
            }
        }
    }
}
