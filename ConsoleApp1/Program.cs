using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            bool found = false;

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            Console.WriteLine("Enter a number: ");
            int val = Convert.ToInt32(Console.ReadLine());

            foreach (var x in nums)
            {
                if (val == x)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Value is found.");
            }
            else
            {
                Console.WriteLine("Value is not found.");
            }
        }
    }
}
