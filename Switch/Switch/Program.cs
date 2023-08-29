using System;

namespace switchblock
{
    class Programm
    {
        static void Main(string[] args)
        {
            int Wochentag = 3;

            switch (Wochentag)
            {
                case 2:
                    Console.WriteLine("Dienstag");
                    break;

                case 3:
                    Console.WriteLine("Mittwoch");
                    break;

                default:
                    Console.WriteLine("Kein Wochentag");
                    break;
            }
        }
    }
}
