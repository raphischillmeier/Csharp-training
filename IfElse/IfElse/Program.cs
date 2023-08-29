using System;

namespace IfElse
{
    class Programm
    {
        static void Main(string[] args)
        {
            int alter = 15;

            if (alter == 15 )
            {
                Console.WriteLine(alter + " ist 15");
            }
            else if (alter == 18 )
            {
                Console.WriteLine(alter + " ist 18");
            }
            else
            {
                Console.WriteLine(alter + " ist nicht 15");
            }
            // && und || vorhanden
        }
    }
}
