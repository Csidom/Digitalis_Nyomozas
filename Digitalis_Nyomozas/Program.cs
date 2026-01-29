using System.ComponentModel;

namespace Digitalis_Nyomozas
{
    internal class Program
    {

        static void ugykezeles()
        {
            
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
                    return;
				case 2:
					szemelykezeles();
                    return;
				case 3:
					bizonyitekkezeles();
                    return;
				case 4:
					idovonal();
                    return;
				case 5:
					elemzes();
                    return;
				case 6:
					break;
			}
        }
    }
}
