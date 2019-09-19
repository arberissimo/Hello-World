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
                        Console.ReadLine();

                        Console.Clear();
                        Noten note = Noten.Create();

                        Console.Clear();

                        foreach (var Fach in FaecherListe)
                        {
                            Console.WriteLine($"{note.Fach}: {note.Note}");
                            Console.WriteLine($"\nDatum der abgeschlossener Prüfung: {note.Tag}.{note.Monat}.{note.Jahr}");
                        }
                        Console.ReadKey();
                        Console.Clear();

                        var hinzufuegen = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Möchten Sie eine neue Note hinzufügen?");
                        Console.WriteLine("[j] ja");
                        Console.WriteLine("[n] nein");


                        switch (hinzufuegen)
                        {
                            case "j":
                                foreach (var Fach in FaecherListe)
                                {
                                    Console.WriteLine($"[{i + 1}] {FaecherListe[i].Name}");
                                    i++;
                                }
                                Console.ReadLine();
                                break;

                            case "n":
                                a = 0;
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
