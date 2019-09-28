using System;
using System.Collections.Generic;
using System.Text;

namespace ApplyingGenerics

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
            Console.WriteLine("List of type string");

            List<char> name = new List<char>() { 'S', 'A', 'M', 'U', 'E', 'L' };

            foreach (var i in name)
            {
                Console.WriteLine(i);
            }
        }
    }
}
