using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_100Days.Day7.List
{
    //Sort
    internal class Sorting
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                9,7,6,5,4,3,2,1
            };

            list.Sort();

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
