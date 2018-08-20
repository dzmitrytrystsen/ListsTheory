using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Index of 1 is: {0}", numbers.IndexOf(1));

            Console.WriteLine("LastIndexOf() Method of 1 is: {0}", numbers.LastIndexOf(1));

            Console.WriteLine("Count() is: {0} objects in the list", numbers.Count);

            numbers.Remove(1);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
            {
                Console.Write(number);
            }

            numbers.Clear();
            foreach (var number in numbers)
            {
                Console.Write(numbers);
            }

            Console.ReadKey();
        }
    }
}
