using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App06;

public class Application06
{
    public string Cerinta = "Cititi un numar si afisati toate numerele de la 1 la n.";

    public void Launch()
    {
        // Inregistrare numar intreg valid de la tastatura pentru "numar"

        int numar;

        Console.Write("Dati o valoare pentru \"numar\": ");

        string numarInput = Console.ReadLine();

        bool inputValid = int.TryParse(numarInput, out numar);

        while (inputValid == false)
        {
            Console.WriteLine("Datele introduse nu sunt valide!");

            Console.Write("Dati o valore pentru \"numar\": ");

            numarInput = Console.ReadLine();

            inputValid = int.TryParse(numarInput, out numar);
        }

        // Afisare
        for (int index = 1; index < numar; index++)
        {
            Console.WriteLine(index + ", ");
        }
    }
}
