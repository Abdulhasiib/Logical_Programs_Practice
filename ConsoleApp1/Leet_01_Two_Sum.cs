using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Leet_01_Two_Sum
    {
        public static void Main(String[] args)
        {
            int[] vnums = { 1, 6, 4, 9 };
            int target = 10;
            int[] res = TwoSum(vnums, target);
            foreach (var item in res)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int Target)
        {
            int sum = 0;
            int[] result = { 0, 0};
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    sum = nums[i] + nums[j];

                    if (sum == Target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
