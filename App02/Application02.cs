using ITSchool.AppUtilities;

namespace App02
{
    public class Application02 : ApplicationBase
    {
        public Application02()
        {
            Cerinta = "Cititi doua numere de la tastatura. Calculati produsul lor si afisati rezultatul.";
        }

        public override void Launch()
        {
            // Inregistrare numar intreg valid de la tastatura pentru "a"

            int a = Utils.GetIntFromKeyboard("a");

            // Inregistrare numar intreg valid de la tastatura pentru "b"

            int b = Utils.GetIntFromKeyboard("b");

            int produs = a * b;

            Console.WriteLine("Produsul numerelor \"a\" (" + a + ") si \"b\" (" + b + ") este: " + produs);
        }
    }
}
