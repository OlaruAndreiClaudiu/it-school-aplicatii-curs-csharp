using ITSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App04
{
    public class Application04 : ApplicationBase
    {
        public string Cerinta = "Cititi doua numere si afisati daca primul este mai mare decat al doilea.";

        public override void Launch()
        {
            // Inregistrare numar intreg valid de la tastatura pentru "a"

            int a = Utils.GetIntFromKeyboard("a");

            // Inregistrare numar intreg valid de la tastatura pentru "b"

            int b = Utils.GetIntFromKeyboard("b");

            if (a > b)
            {
                Console.WriteLine($"{a} este mai mare decat {b}.");
            }
            else
            {
                Console.WriteLine($"{b} este mai mic decat {b}.");
            }
        }
    }
}
