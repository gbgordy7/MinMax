using System;

//find the min and max value in an array

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //use a string to display the integers that are generated
            string strDisplay = string.Empty;

            //create an array
            int[] nums = new int[100];

            //populate the array with random integers
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                nums[i] = r.Next(100);
            }

            //set min and max to smallest and largest available values
            int max = int.MinValue;
            int min = int.MaxValue;

            //cycle through the array checking value of each number
            for (int i = 0; i < nums.Length; i++)
            {
                int value = nums[i];

                if (value > max)
                    max = value;
                else if (value < min)
                    min = value;

                strDisplay += value.ToString() + ",";
            }

            //write out the array using substring to remove the last comma
            Console.WriteLine("Numbers Generated:" + strDisplay.Substring(0,strDisplay.Length - 1));
            Console.WriteLine("Max Value: " + max.ToString());
            Console.WriteLine("Min Value: " + min.ToString());

            string chars = Console.ReadLine();


        }
    }
}
