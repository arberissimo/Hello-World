using System;
using System.Collections.Generic;
using System.Text;

namespace Notenverwaltung
{
    public class Noten
    { 
        public decimal Value { get; set; }

       public String Describtion { get; set; }

       internal static Fach Create()
        {
            Console.WriteLine("Geben Sie Ihre Note ein: ");
            String input3 = Console.ReadLine();

            return new Fach()
            {
                Note = input3
            };
        }

        internal static void Add(Fach fach)
        {
            throw new NotImplementedException();
        }
    }


}
