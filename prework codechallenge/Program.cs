using System;

namespace prework_codechallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("challenges");
            int[] arr = new int[] { 2, 4, 4, 6, 8 };
            Console.WriteLine("select number 2,4,4,6,8");
            Console.Write("");
            int max = Int32.Parse(Console.ReadLine());
            maxarr(arr, max);


            Console.WriteLine("please choose your favorite year?");
            Console.Write("");
            int year = Int32.Parse(Console.ReadLine());
            leapyear(year);
            Sequence();



        }
        public static void maxarr(int[] arr, int max)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max == arr[i])
                    result += arr[i];
            }
            Console.WriteLine($"your score is {result}");
        }
        public static void leapyear(int year)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine($"{year} is a leap year");

            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is not leap year");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is  leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }

        }

        public static void Sequence()
        {
            Console.WriteLine("please enter how many numbers you want");
            Console.Write("");
            int seq = Int32.Parse(Console.ReadLine());
            int[] array = new int[seq];
            int sum = 0;
            int product = 1;
            for (int i = 0; i < seq; i++)
            {
                Console.WriteLine("please enter{0} element:", i + 1);
                array[i] = Int32.Parse(Console.ReadLine());
                sum += array[i];
                product *= array[i];
            }
            if (sum < 0)
            {
                Console.WriteLine("not a perfect sequence");
            }
            else if (sum == product)
            {
                Console.WriteLine("perfect sequence");
            }
            else
            {
                Console.WriteLine("not a perfect match...");
            }

        }
    }
}
    
