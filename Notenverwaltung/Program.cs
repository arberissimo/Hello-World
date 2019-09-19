using System;
using System.Collections.Generic;

namespace Notenverwaltung
{
    class Program
    {
        private static List<Fach> FaecherListe = new List<Fach>();

        public static int FaecherIndex { get; private set; }

        private static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int a = 1;

            while (a == 1)
            {

                Console.Clear();


            Console.WriteLine("Wählen Sie etwas aus");
            Console.WriteLine("[a] neues Fach erfassen");
            Console.WriteLine("[b] alle Fächer auflisten");
            Console.WriteLine("[c] neue Note verfassen");
            Console.WriteLine("[d] Exit");

            var option = Console.ReadLine();

            Console.Clear();

            switch (option)
            {
                case "a":
                    Fach fach = Fach.Create();  //  Fach.AddFach();

                    FaecherListe.Add(fach);
                    Console.WriteLine("Das Fach wurde erfolgreich erstellt.");
                    Console.ReadKey();
                    break;
                case "b":
                    Console.WriteLine("Alle Fächer auflisten");
                    foreach (var Fach in FaecherListe)
                    {
                        Console.WriteLine($"{Fach.Name}: {Fach.Beschreibung}");
                    }
                    Console.ReadKey();
                    break;
                case "c":
                    Console.WriteLine("Wählen Sie ein Fach aus: ");
                    int i = 0;

                        foreach (var Fach in FaecherListe)
                        {
                            Console.WriteLine($"[{i + 1}] {FaecherListe[i].Name}");
                            i++;
                        }
                        string selectedSubjectStr = Console.ReadLine();
                        int selectedSubjectInt;

                        int.TryParse(selectedSubjectStr, out selectedSubjectInt);

                        Console.Clear();

                        var selectedSubject = FaecherListe[selectedSubjectInt - 1];

                        selectedSubject note = Notenverwaltung.selectedSubject.Create();

                        Console.Clear();

                        Console.WriteLine($"{selectedSubject.Name}: {note.Note}");
                        Console.WriteLine($"\nDatum der abgeschlossener Prüfung: {note.Tag}.{note.Monat}.{note.Jahr}");

                        Console.ReadKey();

                        Console.Clear();
                        Console.WriteLine("Möchten Sie eine neue Note hinzufügen?");
                        Console.WriteLine("[j] ja");
                        Console.WriteLine("[n] nein");

                        var hinzufuegen = Console.ReadLine();

                        switch (hinzufuegen)
                        {
                            case "j":

                                Console.Clear();
                                int b = 0;

                                foreach (var Fach in FaecherListe)
                                {
                                    Console.WriteLine($"[{b + 1}] {FaecherListe[b].Name}");
                                    b++;
                                }
                                string fachAuswaehlenStr = Console.ReadLine();
                                int fachAuswaehlenInt;

                                int.TryParse(selectedSubjectStr, out fachAuswaehlenInt);

                                Console.Clear();

                                var fachAuswaehlen = FaecherListe[fachAuswaehlenInt - 1];

                                selectedSubject note1 = Notenverwaltung.selectedSubject.Create();

                                Console.Clear();

                                Console.WriteLine($"{fachAuswaehlen.Name}: {note.Note}");
                                Console.WriteLine($"\nDatum der abgeschlossener Prüfung: {note.Tag}.{note.Monat}.{note.Jahr}");

                                Console.ReadKey();
                                break;

                            case "n":
                                break;
                        }

                        break;
                case "d":
                    Console.WriteLine("Exit");
                    a = 0;
                    break;
                default:
                    break;
            } //switch
        }
        } //Run
    } //class
} //namespace
