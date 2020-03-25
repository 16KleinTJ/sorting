using System;

namespace SamplePrograms
{
    class Program
    {
        /* We'll use instance variables as 'global' variables to avoid having to
         * mess around with passing arrays between functions
         */

        private static int[] unsortedList, sortedList;
        private static Random random = new Random();

        static void Main(string[] args)
        {
            int i;
            
            unsortedList = new int[10];
            sortedList = new int[10];

            for (i = 0; i < unsortedList.Length; i++)
                unsortedList[i] = random.Next(50);

            /* You can also do Python-style for loops */
            foreach (int num in unsortedList)
                Console.WriteLine(num);

            bubbleSort();

            Console.ReadKey();
        }

        /* A void function is a procedure- it does not return a value */
        private static void bubbleSort()
        {
            int i, j;

            /* Copy unsortedList into sortedList
             * no, you can't just do sortedList=unsortedList!
             * https://www.telerik.com/blogs/copying-and-cloning-arrays-in-c
             */

            /* Iterate over the list, you'll need a couple of counting variables.
             * Above, i and j are declared for you.
             * You should know how to do a bubble sort by now, right? :)
             */
        }

    }
}
