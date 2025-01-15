using ITSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App03
{
    public class Application03 : ApplicationBase
    {
        public Application03()
        {
            Cerinta = "Cititi un numar si calculati patratul scestuia. Afisati rezultatul.";
        }
        public override void Launch()
        {
            // Inregistrare numar intreg valid de la tastatura pentru "a"

            int a = Utils.GetIntFromKeyboard("a");

            // calculam patratul numarului si afisam

            int patrat = a * a;

            Console.WriteLine($"Patratul numarului \"a\" {a} este {patrat}.");
        }
    }
}
