using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App10
{
    public class Application10
    {
        public string Cerinta = "Cititi un numar n si inca un numar x si apoi n numere. Cautati numarul x in acest sir si afisati poziţia acestuia (sau un mesaj daca nu este citit.";

        public void Launch()
        {
            // Inregistrare numar intreg valid de la tastatura pentru "n"

            int n;

            Console.Write("Dati o valoare pentru \"n\": ");

            string input = Console.ReadLine();

            bool inputValid = int.TryParse(input, out n);

            while (inputValid == false)
            {
                Console.WriteLine("Datele introduse nu sunt valide!");

                Console.Write("Dati o valoare pentru \"n\": ");

                input = Console.ReadLine();

                inputValid = int.TryParse(input, out n);
            }

            // Inregistrare numar intreg valid de la tastatura pentru "x"

            int x;

            Console.WriteLine("Dati o valoare pentru \"x\": ");

            input = Console.ReadLine();

            inputValid = int.TryParse(input, out x);

            while (inputValid == false)
            {
                Console.WriteLine("Datele introduse nu sunt valide!");

                Console.Write("Dati o valoare pentru \"x\": ");

                input = Console.ReadLine();

                inputValid = int.TryParse(input, out x);
            }

            bool aFostXGasit = false;

            for (int index = 1; index <= n; index++)
            {
                Console.Write($"({index}) - Dati un numar: ");

                input = Console.ReadLine();

                int numar = int.Parse(input);

                if (numar == x)
                {
                    aFostXGasit = true;

                    Console.WriteLine($"Valoarea lui x ({x}) a fost gasita pe pozitia {index}!");
                }
            }

            if (aFostXGasit == false) Console.WriteLine($"Valoarea {x} nu a fost gasita in numerele introduse!");
        }
    }
}
