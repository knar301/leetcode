using System;
using System.Collections.Generic;

//Solved

public class Solution1827
{
	public static int MinOperations(int[] nums)
	{
		int diff = 0;
		int res = 0;
		for (int i = 0; i < nums.Length - 1; i++)
		{
			if (nums[i] >= nums[i+1])
			{
				diff = (nums[i] - nums[i+1]) + 1;
				nums[i+1] = nums[i+1] + diff;
				res += diff;
			}
		}
		return res;
	}
}