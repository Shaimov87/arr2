using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 10);
            }
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Please enter number");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == N)
                    count++;

            }
            Console.WriteLine($"number N is repeated {count} times");


        }
    }
}
