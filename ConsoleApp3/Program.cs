using System;

namespace SamplePrograms
{
    class Program
    {
        private static int[] Array;
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Array = new int[10];

            for (int i = 0; i < Array.Length; i++) // fills the array with (10) random integers between 0-50
                Array[i] = random.Next(50);

            Console.Write("Unsorted list:");
            foreach (int num in Array) // prints each integer in the unsorted array
                Console.Write(" {0}", num);

            bubbleSort(); // call the bubblesort method

            Console.Write("\nSorted list:");
            foreach (int num in Array) // prints each integer in the newly sorted array
                Console.Write(" {0}", num);

            Console.ReadKey();
        }

        private static void bubbleSort()
        {
            while (true) // loops forever until break is called
            {
                bool swapped = false; // init a boolean to track whether any swaps have been made
                for (int i = 0; i < Array.Length - 1; i++) // for the entirety of the list, minus one (so that the final element is not compared against nothing)
                {
                    if (Array[i] > Array[i + 1]) // compare the current element to the element to it's right
                    {
                        swapped = true; // sets the swapped bool to true indicating that a swap has been made
                        var tempvar = Array[i]; // store the current element in the array
                        Array[i] = Array[i + 1]; // overwrites the current element with the smaller value
                        Array[i + 1] = tempvar; // move the larger value to i + 1
                    }
                }
                if (!swapped) // if swapped is false (indicating that no swaps have been made) the list is sorted
                {
                    break; // break is called to end the loop
                }
            }
        }

    }
}
