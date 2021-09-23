using System;
using System.Collections.Generic;
using System.Threading;

namespace List_TDD_Practice
{
    class Program
    {
        public static List<Car> cars = new List<Car>();
        public static Car car = new Car();
        public static Timer _timer;
        static void Main(string[] args)
        {
            Console.WriteLine("Let's practice creating tests for Lists!");

            _timer = new Timer(MyMethod, null, 0, 15000);

            cars.Add(new Car());

            Console.Read();
        }

        public static void MyMethod(Object o)
        {
            //Console.WriteLine("I should print out every 2 seconds...");
            //car.Drive();
            foreach(var c in cars)
            {
                c.Drive();
            }
        }
    }
}
