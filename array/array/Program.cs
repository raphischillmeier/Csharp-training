using System;

namespace arrays
{
    class Programm
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];

            names[0] = "Raphi";
            names[1] = "markus";
            names[2] = "Leo";
            names[3] = "Peter";

            int[] numbers = new int[] { 10, 20, 30 };

            string[,] products = new string[2, 2];

            products[0, 0] = "Senf";
            products[1, 0] = "Lebensmittel"; //Zeile 1

            products[0, 1] = "Smartphone";
            products[1, 1] = "Hallo"; //Zeile 2
        }
    }
}