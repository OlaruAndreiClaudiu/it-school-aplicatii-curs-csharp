namespace ITSchool.AppUtilities
{
    public static class Utils
    {
        public static int GetIntFromKeyboard(string denumire = "")
        {
            int a;

            bool aValid;

            string nume = "";

            if (!string.IsNullOrEmpty(denumire))
            {
                nume = " pentru" + denumire;
            }

            do
            {
                Console.Write($"Introduceti un numar intreg{nume}: ");

                aValid = int.TryParse(Console.ReadLine(), out a);

                if (aValid == false)
                {
                    Console.WriteLine("Datele introduse nu sunt valide!");
                }

            } while (aValid == false);

            return a;
        }


        public static int[] GenereazaArrayDeNumereIntregi(int dimensiuneArray, int limitaInferioara, int limitaSuperioara)
        {
                Random generatorDeNumereAleatoare = new Random();

        int[] arrayDeNumere = new int[dimensiuneArray];

                for (int i = 0;i<arrayDeNumere.Length; i++)
                {
                    arrayDeNumere[i] = generatorDeNumereAleatoare.Next(limitaInferioara, limitaSuperioara + 1);
                }

                return arrayDeNumere;
         }

    }
}
