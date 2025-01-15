using ITSchool.AppUtilities;

namespace App01
{
    public class Application01 : ApplicationBase
    {
        public Application01()
        {
            Cerinta = "Declarati doua variabile, atribuiti valori numerice si afisati suma lor.";
        }
        public override void Launch()
        {
            // Inregistrare numar intreg valid de la tastatura pentru "a"
             
            int a = Utils.GetIntFromKeyboard("a");

            Console.WriteLine("Valuarea lui a este: " + a);

            // Inregistrare numar intreg valid de la tastatura pentru "b"

            int b = Utils.GetIntFromKeyboard("b");

            Console.WriteLine("Valuarea lui a este: " + b);

            Console.WriteLine($"Suma numerelor {a} si {b} este {a + b}");
        }

    }
}
