using App01;

namespace App01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Application01 app1 = new Application01();
            Console.WriteLine(app1.Cerinta);
            app1.Launch();
        }
    }
}