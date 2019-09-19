using System;
using System.Collections.Generic;
using System.Text;

namespace Notenverwaltung
{
    public class Fach {

        

        public String Note { get; set;}
        public string Name { get; private set; }
        public string Beschreibung { get; private set; }

        internal static Fach Create()
        {
            Console.WriteLine("Geben Sie einen Namen ein: ");
            String input1 = Console.ReadLine();

            Console.WriteLine("Geben Sie eine Beschreibung ein: ");
            String input2 = Console.ReadLine();

            return new Fach()
            {
                Name = input1,
                Beschreibung = input2
            };


        }

        internal static void Add(Fach fach)
        {
        }
    }
}
