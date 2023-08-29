using System;

namespace schleifen
{
    class Programm
    {
        public static void Main(string[] args)
        {
            int zahl = 1;

            while (zahl <= 10)
            {
                Console.WriteLine(zahl);
                zahl++;
            }

            do
            {
                zahl++;
                Console.WriteLine(zahl);
            } while (zahl <=20);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            string[] array = new string[] { "Peter", "Raphi" };

            for (int p = 0; p < array.Lenght; p++)
            {
                Console.WriteLine(array[p]);
            }
        }
    }
}
