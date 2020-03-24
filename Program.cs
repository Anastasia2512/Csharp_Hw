using System;

namespace homeWork.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // length of the arrey
            Console.WriteLine("Hello Enter a number of elements :");
            int lengthOfArray = Convert.ToInt32(Console.ReadLine());

            // number to multiply.
            Console.WriteLine(" Enter secend number :");
            int num = Convert.ToInt32(Console.ReadLine());

            // initialize array
            int[] arr = new int[lengthOfArray];

            Console.WriteLine($"Number of elements is : {lengthOfArray} \n number to multiply by :{num}");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * num;
                Console.Write(arr[i] + ", ");
            }
        }
    }
}
