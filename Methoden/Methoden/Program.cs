using System;

namespace methoden
{
    class Progamm
    {
        public static void Main(string[] args)
        {
            GreetUser("Peter");

            double area = RectangeArea(5, 5);
            Console.WriteLine("Das Rechteck hat eine Fläche von " + area);
        }

        static void GreetUser(string username)
        {
            Console.WriteLine("hallo " + username);
        }
        
        static double RectangeArea(double width, double height)
        {
            return width * height;
        }

        
    }
}
