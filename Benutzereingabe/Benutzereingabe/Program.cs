using System;

namespace Eingabe
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Gebe dein Alter ein");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dein alter ist " + age);
        }
    }
}
