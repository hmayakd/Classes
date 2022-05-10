using System;

// Классы. Свойства с одным методом доступа.

namespace Classes
{
    internal class Program
    {
        class Constants
        {
            private double pi = 3.14d;
            private double e = 2.71d;

            // Свойства только для записи. WriteOnly Property
            public double PI
            {
                set { pi = value; }
            }

            // Свойства только для чтения. ReadOnly Property
            public double E
            {
                get { return pi; }
            }
        }
        static void Main(string[] args)
        {
            Constants constants = new Constants();

            constants.PI = 3.14159265D;
            //Console.WriteLine(constants.PI); // Недоступно.

            //constants.E = 3.71D;             // Недоступно.
            Console.WriteLine("e = {0}", constants.E);

            // Delay
            Console.ReadKey();
        }
    }
}
