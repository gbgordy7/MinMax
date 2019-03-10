using System;

//find the min and max value in an array

//see the bottom for a simpler (but faster?) method

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //going to use the datetime to check to clock each method
            DateTime start = DateTime.Now;

            //length of the array
            int length = 1000000;
            //largest value to put in the array
            int largestValue = int.MaxValue;

            //create an array
            int[] nums = new int[length];

            //populate the array with random integers
            Random r = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(largestValue);
            }

            //set min and max to smallest and largest available values
            int max = int.MinValue;
            int min = int.MaxValue;

            DateTime started1 = DateTime.Now;

            //cycle through the array checking value of each number
            for (int i = 0; i < nums.Length; i++)
            {
                int value = nums[i];

                if (value > max)
                    max = value;
                else if (value < min)
                    min = value;
            }

            Console.WriteLine("Max Value: " + max.ToString());
            Console.WriteLine("Min Value: " + min.ToString());

            DateTime ended1 = DateTime.Now;

            //as I started to write the above I realized that I could just sort the array which, I thought, would be
            //faster; to check this I opted to do it both ways and time it, you know, instead of just googling it
            
            Console.WriteLine();
            Console.WriteLine("Is sorting a better method?");

            DateTime started2 = DateTime.Now;

            Array.Sort(nums);

            Console.WriteLine("Max Value: " + nums[nums.Length - 1]);
            Console.WriteLine("Min Value: " + nums[0]);

            DateTime ended2 = DateTime.Now;

            Console.WriteLine();
            Console.WriteLine("Time it took to execute:");
            Console.WriteLine("Method #1: " + (ended1 - started1).TotalMilliseconds);
            Console.WriteLine("Method #2: " + (ended2 - started2).TotalMilliseconds);

            Console.ReadLine();

            //on small arrays method #2 is fastest taking no time, however, the larger the array
            //gets the longer the sort takes making method #1 faster on large arrays

            //both methods took about the same time up to around 10,000 numbers with method #2 taking longer 
            //as you increase the size of the array until it took 20x longer with 1,000,000 numbers

        }
    }
}
