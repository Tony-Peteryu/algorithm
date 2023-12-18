using System;
using System.Collections.Generic;
using System.Text;

namespace PrefixesArrays
{
    public class NumArray
    {
        public int[] nums { get; set; }
        public NumArray(int[] nums)
        {
            this.nums = new int[nums.Length + 1];
            this.nums[0] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                this.nums[i + 1] = this.nums[i] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            return nums[right + 1] - nums[left];
        }
    }
}
