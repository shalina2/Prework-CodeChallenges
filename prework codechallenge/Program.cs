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
    }
}
