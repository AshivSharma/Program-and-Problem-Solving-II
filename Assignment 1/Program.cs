using System;

namespace Lab_Assignment_1B
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] nums = { 1, 4, 13, 43, -25, 17, 22, -37, 29 };
            int[] data = new int[20];
            data = randArray(data);
            int randLargest = findLargest(data);
            int randLarge = findLargest(nums);
            Console.WriteLine("Data: " + printData(data));
            Console.WriteLine("\nLargest element in data is: " + randLarge);
            Console.WriteLine("\nLargest element in nums is: " + randLargest);
            Console.WriteLine("\nSum of the largest values from nums and data is: " + (randLargest + randLarge));
            Console.WriteLine("\nLength of the longest continuous series of positive numbers in the array data is: " + findLength(data));

        }

        private static int findLargest(int[] nums)
        {
            int large = nums[0];
            for (int n = 1; n < nums.Length; n++)
            {

                if (large < nums[n])
                    large = nums[n];
            }
            return large;
        }
        private static int[] randArray(int[] data)
        {
            Random rand = new Random();
            for (int n = 0; n < data.Length; n++)
            {
                data[n] = rand.Next(-100, 100);
            }
            return data;
        }
        private static string printData(int[] data)
        {
            string s = "";
            for (int i = 0; i < data.Length; i++)
            {
                s += data[i] + " ";
            }
            return s;
        }
        
        private static int findLength(int[] data)
        {
            int count = 0;
            int largest = 0;
            for (int i = 0; i < data.Length; i++)
            {
                int m = data[i];


                if (m > 0)
                {
                    count++;

                }
                else
                {
                    if (count > largest)
                    {
                        largest = count;
                    }

                    count = 0;

                }

            }
            if (count > largest)
            {
                count = largest;
            }
            return largest;
        }
    }
}
