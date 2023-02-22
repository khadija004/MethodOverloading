using System;

namespace Lesson14Tural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //METHOD OVERLOADING


            //TASK1

            //FindMax

            //Console.WriteLine("Enter Array Size");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] numbers = new int[size];

            //Console.WriteLine("Enter Numbers");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //}

            //int result = FindMax(numbers);

            //Console.WriteLine($"Max num in array is {result}");


            //string[] names = { "Xedice", "Zehra", "Mehemmed" };
            //string answer=FindMax(names);
            //Console.WriteLine(answer);



            //TASK2

            //FindAny



            Console.WriteLine("Enter Array Size");
            int.TryParse(Console.ReadLine(), out int size);

            int[] nums = new int[size];

            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < nums.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out nums[i]);
            }

            FindAny(nums);

        }

        static void FindAny(int[] nums)
        {
            Console.WriteLine("Enter your search");
            int.TryParse(Console.ReadLine(), out int search);

            bool isExist = default;

            for (int i = 0; i < nums.Length; i++)
            {
                if (search == nums[i])
                {
                    isExist = true;
                }
            }

            if (isExist)
            {
                Console.WriteLine($"Your num is exist");
            }
            else
            {
                Console.WriteLine("Your num doesnt exist");
            }
        }

        static int FindMax(int[] numbers)
        {

            int result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>result)
                {
                    result = numbers[i];
                }
            }
            return result;
        }


        static double FindMax(double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>result)
                {
                    result = numbers[i];
                }
            }
            return result;
        }

        static string FindMax(string[] names)
        {
            int length = names[0].Length;
            string answer = names[0];

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length>length)
                {
                    length = names[i].Length;
                    answer = names[i];
                }
            }
            return answer;
        }


        static int FindMin(int[] numbers)
        {
            int result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < result)
                {
                    result = numbers[i];
                }
            }
            return result;
        }

        static double FindMin(double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < result)
                {
                    result = numbers[i];
                }
            }
            return result;
        }


        static string FindMin(string[] names)
        {
            int length = names[0].Length;
            string answer = names[0];

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length < length)
                {
                    length = names[i].Length;
                    answer = names[i];
                }
            }
            return answer;
        }

    }
}
