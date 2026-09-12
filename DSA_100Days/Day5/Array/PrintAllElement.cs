using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day5.Array
{
    //Copy elements from one array to another
    internal class PrintAllElement
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr2 = new int[arr1.Length];

            for(int i=0; i<arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Second Array:");
            for(int i=0; i<arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]+" ");
            }
        }
    }
}
