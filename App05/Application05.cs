using ITSchool.AppUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App05;

public class Application05 : ApplicationBase
{
    public static string Cerinta = "Cititi un numar si verificati daca este par sau impar.";

    public override void Launch()
    {
        int a = Utils.GetIntFromKeyboard("a");

        if (a % 2 == 0)
        {
            Console.WriteLine("Numarul este par.");
        }
        else
        {
            Console.WriteLine("Numarul este impar.");
        }
    }
}
