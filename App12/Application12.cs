using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App12
{
    public class Application12
    {
        public string Cerinta = "Dati un numar natural de la tastatura. Numarul trebuie sa fie in intervalul definit in A11. Cautati numarul introdus in colectia generata in A11. Daca il gasiti, afisati poziţia lui si intrerupeti funcţionarea metodei, altfel afisati un mesaj corespunzator lipsei lui. Hint: cheia “break” intrerupe rularea unei structuri repetitive.";

        public void Launch()
        {
            // dam numarul de elemente pentru sir
            int a;
            Console.Write("Introduceti numarul de elemente pentru sir: ");
            string aInput = Console.ReadLine();
            bool aValid = int.TryParse(aInput, out a);

            while (!aValid)
            {
                Console.Write("Datele introduse nu sunt un numar intreg! Introduceti un numar: ");
                aInput = Console.ReadLine();
                aValid = int.TryParse(aInput, out a);
            }

            // indicati intervalul in care putem avea valori
            const int limitaInferioara = -10;
            const int limitaSuperioara = 10;

            int[] arrayDeNumere = new int[a];

            Random generatorDeNumereAleatoare = new Random();

            // generam valori aleatoari pentru fiecare pozitie din array
            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                // atribuim un numar aleator pentru pozitia curenta din array
                arrayDeNumere[i] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                Console.WriteLine(arrayDeNumere[i]);
            }

            int n;

            Console.WriteLine("Introduceti un numar: ");

            string nInput = Console.ReadLine();

            bool nValid = int.TryParse(nInput, out n);

            while (nValid == false || (n < limitaInferioara || n > limitaSuperioara))
            {
                Console.Write($"Datele introduse nu reprezinta un numar intreg din interval! Dati un numar in intervalul [{limitaSuperioara}]");
                nInput = Console.ReadLine();
                nValid = int.TryParse(nInput, out n);

                if (nValid && (n < limitaInferioara || n > limitaSuperioara))
                {
                    nValid = false;
                }
            }

            // Cautarea pozitiei numarului citit in array
            int indexGasit = -1;

            for (int i = 0; i < arrayDeNumere.Length; i++)
            {
                if (arrayDeNumere[i] == n)
                {
                    indexGasit = i;
                    break;
                }
                if (indexGasit > -1)
                {
                    Console.WriteLine($"Numarul apare prima oare pe pozitia {indexGasit}.");
                }
                else
                {
                    Console.WriteLine($"Numarul {n} nu a fost gasit in sir.");
                }
            }
        }
    }
}
