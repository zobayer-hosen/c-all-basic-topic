using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>();
            values.Add(100);
            values.Add(5);
            values.Add(30);
            values.Add(41);
            values.Add(50);
            values[0] = 1000;
            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(values.Count);
            Console.WriteLine(values.Capacity);

            values.AddRange(new List<int>() { 200, 300, 400 });
            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
            values.Insert(2, 150);
            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n new list");

            values.Remove(41);
            foreach(int i in values)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
            values.RemoveAt(2);
            foreach (int i in values)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
            values.RemoveRange(0, 2);
            foreach (int i in values)
            {
                Console.WriteLine(i);
            }

            List<int> values2 = new List<int>() { 100, 5, 9, 2, 200 };
            values2.Sort();
            foreach(int i in values2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            values2.Reverse();
            foreach(int i in values2)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\n");

            List<Car> cars = new List<Car>();
            Car c1 = new Car();
            c1.CarName = "marcedes";
            Car c2 = new Car();
            c2.CarName = "Ford";
            cars.Add(c1);
            cars.Add(c2);
            foreach(Car c in cars)
            {
                Console.WriteLine(c.CarName);
            }

        }
    }
}
