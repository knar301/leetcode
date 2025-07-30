using System;
using System.Collections.Generic;


class Solution345
{
	public static string ReverseVowels(string s)
	{
		char[] letters = s.ToCharArray();
		var vowels = new HashSet<char> {'a','e','i','o','u','A','E','I','O','U'};
		int left = 0;
		int right = s.Length -1;
		while (left < right)
		{
			if (vowels.Contains(letters[left]) && vowels.Contains(letters[right]))
			{
				(letters[left],letters[right]) = (letters[right],letters[left]);
				left++;
				right--;
			}
			else if (!vowels.Contains(letters[left]))
			{
				left++;
			}
			else if (!vowels.Contains(letters[right]))
			{
				right--;
			}
		}
		string res = new string(letters);
		return res;
	}
}