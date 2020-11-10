using System;
using System.Collections.Generic;

namespace ContiguousArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] nums = new int[2] { 0,1};
            Console.WriteLine(FindMaxLength(nums));
            Console.ReadLine();
        }
        public static int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int max = 0;
            int sum = 0;
            //For [0,1] case
            map.Add(0, -1);
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + (nums[i] == 0 ? -1:1);
                if (map.ContainsKey(sum))
                {
                    max = Math.Max(max, i - map[sum]);
                }
                else
                {
                    map.Add(sum, i);
                }
            }
            return max;
        }

    }
}
