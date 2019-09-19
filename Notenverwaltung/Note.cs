using System;
using System.Collections.Generic;
using System.Text;

namespace Notenverwaltung
{
    public class Noten
    {

        public decimal Value { get; set; }

       public String Describtion { get; set; }
        public string Note { get; private set; }
        public string Fach { get; private set; }
        public string Tag { get; private set; }
        public string Monat { get; private set; }
        public string Jahr { get; private set; }
        public static IEnumerable<object> FaecherListe { get; set; }
        public static string fach { get; private set; }

        internal static Noten Create()
        {
            Console.WriteLine("Geben Sie Ihre Note ein: ");
            String note = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Geben Sie noch das Datum der Prüfung an: ");

            Console.WriteLine("\nGeben Sie Ihre Tag ein: ");
            String tag = Console.ReadLine();

            Console.WriteLine("Geben Sie Ihre Monat ein: ");
            String monat = Console.ReadLine();

            Console.WriteLine("Geben Sie Ihre Jahr ein: ");
            String jahr = Console.ReadLine();

            return new Noten()
            {
                Fach = fach,
                Note = note,
                Tag = tag,
                Monat = monat,
                Jahr = jahr
            };
        }

        internal static void Add(Fach fach)
        {
        }

        internal static void Add(Noten noten)
        {
            throw new NotImplementedException();
        }
    }


}
