using ITSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App08
{
    public class Application08 : ApplicationBase
    {
        public static string Cerinta = "Cititi un numar si calculati factorialul acestuia ( n! = 1*2*3*...*n).";

        public override void Launch()
        {
            // Inregistrare numar intreg valid de la tastatura pentru "a"
            int a = Utils.GetIntFromKeyboard("a");

            int produs = 1;

            for (int i = 0; i <= a; i++)
            {
                produs *= i;
            }

            Console.WriteLine($"a ({a}) factorial = {produs}");
        }
    }
}
