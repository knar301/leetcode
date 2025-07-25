using System;
using System.Collections.Generic;

//Leetcode 187
//Solved

public class Solution187
{
	public static List<string> FindRepeatedDnaSequences(string s)
	{
		var res = new List<string>();
		var sequences = new Dictionary<string,int>();
		int left = 0;
		int right = 9;
		
		while (right < s.Length)
		{
			string substring = s.Substring(left,10);
			if (!sequences.ContainsKey(substring))
			{
				sequences[substring] = 1;
			}
			else
			{
				sequences[substring]++;
			}
			left++;
			right++;
		}	
		foreach (var item in sequences)
		{
			if (item.Value > 1)
			{
				res.Add(item.Key);
			}
		}
		return res;		
	}
}

