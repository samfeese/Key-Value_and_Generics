using System;
using System.Collections.Generic;
using System.Text;

namespace KeyValueStore

{
    /*
     * List<T>
     * LinkedList<T>
     * Queue<T>
     * Stack<T>
     * Dictionary<TKey, TValue>
     * SortedList<TKey, TValue>
     * HashSet<T>).
     * 
     * Insert 5 values of a type of your choosing into each of these collections, 
     * then iterate over the collection and print each value to the console. 
     * Print a line above your iteration stating which data structure you're printing from,
     * and print a blank line between the last item in the collection and the description of the following data structure.
     */

    class ApplyGenerics
    {
        public static void Instantiate()
        {
            Console.WriteLine("\n\n\nList of type char");

            List<char> name = new List<char>() { 'S', 'A', 'M', 'U', 'E', 'L' };

            foreach (var i in name)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n-----------------------------------------------------------------------");

            Console.WriteLine("\n\n\nLinkedList of type double");

            double[] math1 = new double[] { 1.0, 3, 4.20093900940, 42, 17 };
            LinkedList<double> lili = new LinkedList<double>(math1);

            foreach (var i in lili)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n-----------------------------------------------------------------------");

            Console.WriteLine("\n\nQueue of type int");

            Queue<int> countUp = new Queue<int>();
            countUp.Enqueue(1);
            countUp.Enqueue(2);
            countUp.Enqueue(3);
            countUp.Enqueue(4);
            countUp.Enqueue(5);


            foreach (var i in countUp)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n-----------------------------------------------------------------------");

            Console.WriteLine("\n\nStack of type int");

            Stack<int> alsoUp = new Stack<int>();

            alsoUp.Push(5);

            alsoUp.Push(4);

            alsoUp.Push(3);

            alsoUp.Push(2);

            alsoUp.Push(1);

            foreach (var i in alsoUp)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\n-----------------------------------------------------------------------");

            Console.WriteLine("\n\nDictionary of useless values");

            Dictionary<string, string> crabs = new Dictionary<string, string>();
            crabs.Add("Sam", "Red");
            crabs.Add("Ash", "Green");
            crabs.Add("Elliot", "Blue");
            crabs.Add("Jordan", "Yellow");
            crabs.Add("Ryan", "Grey");

            foreach (KeyValuePair<string, string> colors in crabs)
            {
                Console.WriteLine(colors);
            }

            Console.WriteLine("\n\n-----------------------------------------------------------------------");

            Console.WriteLine("\n\nSortedList of more useless things\n");

            SortedList<string, string> Dates = new SortedList<string, string>();
            Dates.Add("Sam", "Jun");
            Dates.Add("Elliot", "Feb");
            Dates.Add("Ash", "October");
            Dates.Add("Jordan", "November");
            Dates.Add("Ryan", "December");

            foreach (KeyValuePair<string, string> things in Dates)
            {
                Console.WriteLine(things);
            }

            Console.WriteLine("\n\nMore Useless items in Hash");

            HashSet<string> cars = new HashSet<string>();
            cars.Add("Tahoe");
            cars.Add("WRX");
            cars.Add("Grand Prix");
            cars.Add("Exploder");
            cars.Add("Mini Cooper S");

            foreach (string models in cars)
            {
                Console.WriteLine(models);
            }





        }



    }
}
