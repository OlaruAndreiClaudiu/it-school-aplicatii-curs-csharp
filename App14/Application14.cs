using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App14
{
    public class Application14
    {
        public string Cerinta = "Afisati toate numerele care sunt prime dintr-un sir de numere intregi (generat la A11). Un numar este prim daca acesta se imparte fara rest doar la 1 si la el insusi. Ignorati orice numar din sir care este -1, 0 sau 1. Considerati si numerele negative ca putand fi prime.";

        public void Launch()
        {
            int[] arrayDeIntrare = GetRandomGeneratedArray(-100, 100);

            for (int i = 0; i < arrayDeIntrare.Length; i++)
            {
                if (arrayDeIntrare[i] == -1 || arrayDeIntrare[i] == 0 || arrayDeIntrare[i] == 1)
                {
                    continue;
                }

                if (VerificaNumarPrim(arrayDeIntrare[i]))
                {
                    Console.WriteLine("|" + arrayDeIntrare[i] + "| este prim!");
                }
            }

            bool VerificaNumarPrim(int numar)
            {
                int copie = numar;

                if (copie < 0)
                {
                    copie *= -1;
                }

                for (int i = 2; i < numar; i++)
                {
                    if (numar % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            int[] GetRandomGeneratedArray(int limitaInferioara = -10, int limitaSuperioara = 10)
            {
                // dam numarul de elemente pentru sir
                int a;
                Console.Write("Introduceti numarul de elemente pentru sir: ");
                string aInput = Console.ReadLine();
                bool aValid = int.TryParse(aInput, out a);

                if (aValid && a <= 0)
                {
                    aValid = false;
                }

                while (!aValid)
                {
                    Console.WriteLine("Datele introduse nu sunt un numar intreg sau numarul este mai mic sau egal cu 0!");
                    Console.Write("Introduceti un numar: ");
                    aInput = Console.ReadLine();
                    aValid = int.TryParse(aInput, out a);

                    if (aValid && a <= 0)
                    {
                        aValid = false;
                    }
                }

                int[] arrayDeNumere = new int[a];

                Random generatorDeNumereAleatoare = new Random();

                // generam valori aleatoare pentru fiecare pozitie din array
                for (int i = 0; i < arrayDeNumere.Length; i++)
                {
                    // atribuim un numar aleator pentru pozitia curenta din array
                    arrayDeNumere[i] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                    Console.Write(arrayDeNumere[i] + ", ");
                }

                return arrayDeNumere;
            }
        }
    }
}
