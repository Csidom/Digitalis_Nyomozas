using System.ComponentModel;
using System.Windows.Markup;

namespace Digitalis_Nyomozas
{
    internal class Program
    {

        static DataStore datastore = new DataStore();
        static CaseManager caseManager = new CaseManager(datastore);
        static EvidenceManager evidenceManager = new EvidenceManager();

        static void ugykezeles()
        {
            bool vissza = false;
            while (!vissza)
            {
                Console.Clear() ;
                Console.WriteLine("""
                    ---Ügyek kezelése---

                    1. Ügyek listázása
                    2. Új ügy hozzáadása
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
                        caseManager.ListCases();
                        break;
                    case 2:
                        caseManager.CreateCase();
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
            bool vissza = false;
            while (!vissza)
            {
                Console.Clear();
                Console.WriteLine("""
                ---Személyek kezelése---
                
                1. Ügy kiválasztása
                2. Vissza

                """);

                Console.Write("Választás: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Adja meg az ügy azonosítóját: ");
                        string id = Console.ReadLine();

                        Case selectedCase = datastore.Ugyek.FirstOrDefault(c => c.Ugy_azonosito == id);

                        if (selectedCase == null)
                        {
                            Console.WriteLine("Nincs ilyen ügy.");
                            Console.ReadKey();
                        }
                        else
                        {
                            bool v = false;
                            while (!v)
                            {
                                Console.Clear();
                                Console.WriteLine("""
                                    ---Személyek kezelése---

                                    1. Személyek listázása
                                    2. Gyanúsított hozzáadása
                                    3. Tanú hozzáadása
                                    4. Másik ügy választása

                                    """);
                                Console.Write("Választás: ");

                                int choice1 = int.Parse(Console.ReadLine());

                                switch (choice1)
                                {
                                    case 1:
                                        caseManager.ListPeople(selectedCase);
                                        break;
                                    case 2:
                                        caseManager.AddSuspect(selectedCase);
                                        break;
                                    case 3:
                                        caseManager.AddWitness(selectedCase);
                                        break;
                                    case 4:
                                        v = true;
                                        break;
                                }
                            }
                        }
                        break;
                    case 2:
                        vissza = true;
                        break;
                }
            }
        }

        static void bizonyitekkezeles()
        {
            bool vissza = false;
            while (!vissza)
            {
                Console.Clear();
                Console.WriteLine("""
                ---Bizonyitékok kezelése---
                
                1. Ügy kiválasztása
                2. Vissza

                """);

                Console.Write("Választás: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine();
                        Console.Write("Adja meg az ügy azonosítóját: ");
                        string id = Console.ReadLine();

                        Case selectedCase = datastore.Ugyek.FirstOrDefault(c => c.Ugy_azonosito == id);

                        if (selectedCase == null)
                        {
                            Console.WriteLine("Nincs ilyen ügy.");
                            Console.ReadKey();
                        }
                        else
                        {
                            bool v = false;
                            while (!v)
                            {
                                Console.Clear();
                                Console.WriteLine("""
                                    ---Bizonyítékok kezelése---

                                    1. Bizonyítékok listázása
                                    2. Bizonyíték hozzáadása
                                    3. Bizonyíték törlése
                                    4. Másik ügy választása

                                    """);
                                Console.Write("Választás: ");

                                int choice1 = int.Parse(Console.ReadLine());

                                switch (choice1)
                                {
                                    case 1:
                                        evidenceManager.ListEvidences(selectedCase);
                                        break;
                                    case 2:
                                        evidenceManager.AddEvidence(selectedCase);
                                        break;
                                    case 3:
                                        evidenceManager.DeleteEvidence(selectedCase);
                                        break;
                                    case 4:
                                        v = true;
                                        break;
                                }
                            }
                        }
                        break;
                    case 2:
                        vissza = true;
                        break;
                }
            }
        }

        static void idovonal()
        {
            Console.WriteLine("Nincs itt még semmi...");
            Console.ReadKey();
        }

        static void elemzes()
        {
            Console.WriteLine("Nincs itt még semmi...");
            Console.ReadKey();
        }

        static void kezdoadatok()
        {
            // ----- KEZDŐ ADATOK -----

            Case ugy1 = new Case("U001", "Bankrablás", "Ismeretlen elkövető kirabolta a belvárosi bankot.");
            Case ugy2 = new Case("U002", "Adatszivárgás", "Céges adatbázis feltörése történt.");
            Case ugy3 = new Case("U003", "Zsaroló email", "Ismeretlen feladó fenyegető üzenetet küldött.");

            // Gyanúsítottak
            Person p1 = new Person("Kovács Béla", 42, "Korábban már büntetett előéletű.");
            Suspect s1 = new Suspect(p1, 65, "Megfigyelt");

            Person p2 = new Person("Nagy Anna", 29, "Volt alkalmazott.");
            Suspect s2 = new Suspect(p2, 40, "Szabad");

            // Tanúk
            Person p3 = new Person("Tóth Gábor", 35, "Szemtanú.");
            Witness w1 = new Witness(p3, "Láttam egy fekete autót a bank előtt.", new DateTime(2026, 5, 12));

            Person p4 = new Person("Szabó Lilla", 31, "Irodai dolgozó.");
            Witness w2 = new Witness(p4, "Gyanús bejelentkezést észleltem.", new DateTime(2026, 6, 2));

            // Bizonyítékok
            Evidence e1 = new Evidence("E001", "Fotó", "Fekete autó a bank előtt.", 8);
            Evidence e2 = new Evidence("E002", "Dokumentum", "Rablás során hagyott ujjlenyomat.", 9);
            Evidence e3 = new Evidence("E003", "Digitális adat", "Hozzáférés log a cég adatbázisában.", 7);
            Evidence e4 = new Evidence("E004", "Email", "Zsaroló üzenet a CEO-nak.", 6);

            // Hozzárendelések
            ugy1.Gyanusitottak.Add(s1);
            ugy1.Tanuk.Add(w1);
            ugy1.Bizonyitekok.Add(e1);
            ugy1.Bizonyitekok.Add(e2);

            ugy2.Gyanusitottak.Add(s2);
            ugy2.Tanuk.Add(w2);
            ugy2.Bizonyitekok.Add(e3);

            ugy3.Bizonyitekok.Add(e4);

            // Ügyek hozzáadása a datastore-hoz
            datastore.Ugyek.Add(ugy1);
            datastore.Ugyek.Add(ugy2);
            datastore.Ugyek.Add(ugy3);
        }

        static void Main(string[] args)
        {
            kezdoadatok();

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
