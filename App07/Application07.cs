using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App07
{
    public class Application07
    {
        public string Cerinta = "Cititi un numar n si calculati suma primelor n numere naturale.";

        public void Launch()
        {

            // Inregistrare numar intreg valid de la tastatura pentru "n"

            int n;

            Console.Write("Dati o valoare pentru \"n\": ");

            string nInput = Console.ReadLine();

            bool inputValid = int.TryParse(nInput, out n);

            int suma = 0;

            while (inputValid == false)
            {
                Console.WriteLine("Datele introduse nu sunt valide!");

                Console.Write("Dati o valoare pentru \"n\": ");

                nInput = Console.ReadLine();

                inputValid = int.TryParse(nInput, out n);
            }

            for (int i = 0; i <= n; i++)
            {
                suma += i;
            }

            Console.WriteLine($"Suma primelor n numere naturale este {suma}");
        }
    }
}
