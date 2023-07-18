using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoSum
{
    public class Program
    {
        public static void Main()
        {
            int[] arr = {
            10,
            20

        };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}
