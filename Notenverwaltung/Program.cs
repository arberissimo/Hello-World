using System;
using System.Collections.Generic;

namespace Notenverwaltung
{
    class Program
    {
        private static List<Fach> Faecher = new List<Fach>();

        private static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int a = 1;

            while (a == 1)
            {

            Console.WriteLine("Wählen Sie etwas aus");
            Console.WriteLine("[a] neues Fach erfassen");
            Console.WriteLine("[b] alle Fächer auflisten");
            Console.WriteLine("[c] neue Note verfassen");
            Console.WriteLine("[d] Zeugnis anzeigen");
            Console.WriteLine("[e] Exit");

            var option = Console.ReadLine();

            Console.Clear();

            switch (option)
            {
                case "a":
                    Faecher.Add(Fach.Create()); //  Fach.AddFach();
                    Console.WriteLine("Das Fach wurde erfolgreich erstellt.");
                    break;
                case "b":
                    Console.WriteLine("Alle Fächer auflisten");
                    foreach (var fach in Faecher)
                    {
                        Console.WriteLine("Fach");
                    }
                    break;
                case "c":
                    Noten.Add(Noten.Create());
                    Console.WriteLine("Die Note wurde erfolgreich hinzugefügt.");
                    break;
                case "d":
                    Console.WriteLine("Zeugnis zeigen");
                    break;
                case "e":
                    Console.WriteLine("Exit");
                    break;
                default:
                    break;
            } //switch
        }
        } //Run
    } //class
} //namespace
