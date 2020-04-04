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
            int[] vnums = { 2, 7, 11, 15 };
            int target = 10;
            //int[] res = TwoSum(vnums, target);

            int[] res = DictTwoSum(vnums, target);
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

        public static int[] DictTwoSum(int[] nms, int trgt)
        {
            Dictionary<int, int> inputArrayDict = new Dictionary<int, int>();

            for (int i = 0; i < nms.Length; i++)
            {
                int complimentNu = trgt - nms[i];
                if (inputArrayDict.ContainsKey(complimentNu))
                {
                    int[] resultArray = { inputArrayDict[complimentNu],i  };
                    return resultArray;
                }
                inputArrayDict.Add(nms[i],i);
            }
            throw new Exception("No two sum solution");
        }
    }
}
