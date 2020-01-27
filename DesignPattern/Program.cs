using DesignPattern.FactoryDesignPattern;
using DesignPattern.PrototypeDesign;
using System;

namespace DesignPattern
{
    class Program
    {
        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                p.Name, p.age, p.Date);
            Console.WriteLine(" ID#: {0:d}", p.Idinfo.IdNumber);
        }
        [Obsolete]
        static void Main(string[] args)
        {
          

            Console.WriteLine("1->factory design");
            Console.WriteLine("2->prototype design");
            Console.WriteLine("choose your option");
            int k = Convert.ToInt32(Console.ReadLine());

            switch (k) 
            {
                case 1:
            TestFactory.IsFactory();
                    break;
                case 2:
                    Person p1 = new Person();
                    p1.age = 23;
                    p1.Date = Convert.ToDateTime("1996-01-16");

                    p1.Name = "shan";
                    p1.Idinfo = new IdInfo(101);

                    // Perform a shallow copy of p1 and assign it to p2
                    Person P2 = p1.ShallowCopy();
                    // Make a deep copy of p1 and assign it to p3.
                    Person P3 = p1.DeepCopy();

                    Console.WriteLine("Original values of p1, p2, p3:");
                    Console.WriteLine("   p1 instance values: ");
                    DisplayValues(p1);
                    Console.WriteLine("   p2 instance values:");
                    DisplayValues(P2);
                    Console.WriteLine("   p3 instance values:");
                    DisplayValues(P3);
                    // Change the value of p1 properties and display the values of p1,
                    // p2 and p3.
                    p1.age = 32;
                    p1.Date = Convert.ToDateTime("1900-01-01");
                    p1.Name = "Frank";
                    p1.Idinfo.IdNumber = 7878;
                    Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
                    Console.WriteLine("   p1 instance values: ");
                    DisplayValues(p1);
                    Console.WriteLine("   p2 instance values (reference values have changed):");
                    DisplayValues(P2);
                    Console.WriteLine("   p3 instance values (everything was kept the same):");
                    DisplayValues(P3);
                  

                    break;
        }
        }
    }
}
