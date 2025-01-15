using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App13
{
    public class Application13
    {
        public string Cerinta = "Calculati suma numerelor pozitive dintr-un sir de numere intregi (generat in A11). Folositi cheia “continue” pentru a sari peste numerele negative.";

        public void Launch()
        {
            int[] arrayDeIntrare = GetRandomGeneratedArray(-100, 100);

            // declaram o variabila pentru suma
            int suma = 0;

            // parcurgem arrayul
            for (int i = 0; i < arrayDeIntrare.Length; i++)
            {
                // daca numarul este negativ ignora-l
                if (arrayDeIntrare[i] < 0)
                {
                    continue;
                }

                suma += arrayDeIntrare[i];
            }

            Console.WriteLine("Suma numerelor pozitive din arrayul primit este: " + suma);
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
