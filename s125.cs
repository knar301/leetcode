using System;
using System.Linq;
using System.Collections.Generic;

//Leetcode 125
//Solved

public class Solution125
{
	public static bool IsPalindrome(string s)
	{
		string t = s.ToLower();
		List<char> characters = t.ToList();
		for (int i = characters.Count - 1; i >= 0; i--)
		{
			if (!Char.IsLetterOrDigit(characters[i]))
			{
				characters.RemoveAt(i);
			}
		}
		int left = 0;
		int right = characters.Count - 1;
		while (left < right)
		{
			if (characters[left] != characters[right])
			{
				return false;
			}
			left++;
			right--;
		}
		return true;
	}

}
