using System;

namespace ObjKla
{
    class Program
    {
        public static void Main(string[] args)
        {   
            //kann nicht zusammen mit Konstruktor verwendet werden
            Person Raphi = new Person();

            Raphi.Name = "Raphi";
            Raphi.Alter = 21;

            Raphi.SagHallo();

            //kann nur mit Konstruktor verwendet werden
            Person person1 = new Person("Andreas", 43);
            person1.SagHallo();
        }

        class Person
        {
            public string Name { get; set; }
            public int Alter { get; set; }

            //unveränderlich
            public string Mensch { get; } = "Mensch";

            //unveränderlich
            private int anzahlTüren = 4;
            

            //konstruktor
            public Person(string name, int alter)
            {
                Name = name;
                Alter = alter;
            }

            public void SagHallo()
            {
                Console.WriteLine(Name + " ist " + Alter + " Jahre alt");
            }  
        }
    }
}
