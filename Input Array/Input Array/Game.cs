using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Array
{
    internal class Game
    {
        public void Run()
        {
            //An empty 5 integer array
            int[] numbers = new int[5];

            GetArray(numbers);
            Console.WriteLine();
            ReverseArray(numbers);
            Console.WriteLine();
            ArraySum(numbers);
            Console.WriteLine();
            HighestInteger(numbers);
            Console.WriteLine();
            LowestInteger(numbers);
        }
        //Asks the user to create a 5 integer array and print it out
        static void GetArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //Asks the user for an integer 5 times
                Console.WriteLine("Enter an integer");
                int input = Convert.ToInt32(Console.ReadLine());
                //Adds each integer into the array
                array[i] = input;
            }
            Console.Clear();
            Console.WriteLine("Your array");
            for (int i = 0; i < array.Length; i++)
            {
                //Prints out each value of the array
                Console.WriteLine(array[i]);
            }
        }
        //Prints out the array in reverse order
        static void ReverseArray(int[] array)
        {
            Console.WriteLine("Array reversed");
            for (int i = 4; i >= 0; i--)
            {
                //Prints out the array from the last element to the first
                Console.WriteLine(array[i]);
            }
        }
        //Prints out the sum of the elements in the array
        static void ArraySum(int[] array)
        {
            //Adds each elements of the array together and prints the sum out
            int sum = array[0] + array[1] + array[2] + array[3] + array[4];
            Console.WriteLine("Sum of array");
            Console.WriteLine(sum);
        }
        //Prints out the highest integer in the array
        static void HighestInteger(int[] array)
        {
            //Assumes the first value is the highest value in the array
            int highest = array[0];
            //Runs through each value of the array
            for (int i = 0; i < array.Length; i++)
            {
                //If the current value is higher, makes it the new highest value
                if (array[i] > highest)
                {
                    highest = array[i];
                }
            }
            //Prints out the highest value in the array
            Console.WriteLine("Highest integer");
            Console.WriteLine(highest);
        }
        //Prints out the lowest integer in the array
        static void LowestInteger(int[] array)
        {
            //Assumes the first value is the lowest value in the array
            int lowest = array[0];
            //Runs through each value of the array
            for (int i = 0; i < array.Length; i++)
            {
                //If the current value is lower, makes it the new lowest value
                if (array[i] < lowest)
                {
                    lowest = array[i];
                }
            }
            //Prints out the lowest value in the array
            Console.WriteLine("Lowest integer");
            Console.WriteLine(lowest);
        }
    }
}
