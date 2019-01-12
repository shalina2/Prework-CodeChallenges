using System;

namespace prework_codechallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("challenges");
            int[] arr = new int[]{ 2, 4, 4, 6, 8 };
            Console.WriteLine("select number 2,4,4,6,8");
            Console.Write("");
            int max=Int32.Parse(Console.ReadLine());
            maxarr(arr, max);


            Console.WriteLine("please choose your favorite year?");
            Console.Write("");
            int year =Int32.Parse(Console.ReadLine());
            leapyear(year);
        }
       public static void maxarr(int[] arr,int max)
        {
            int result = 0;
            for(int i = 0; i < arr.Length; i++)
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
            else if(year%100==0)
            {
                Console.WriteLine($"{year} is not leap year");
            }
            else if(year%400==0)
            {
                Console.WriteLine($"{year} is  leap year");
            }
            else{
                Console.WriteLine($"{year} is not a leap year");
            }
            Console.ReadLine();
        }
    }
}
