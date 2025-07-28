using System;
using System.Collections.Generic;

class Solution682
{
	public static void CalPoints(string[] operations)
	{
		var stack = new Stack<int>();
		int current = 0;
		foreach (string s in operations)
		{
			if (s == "C")
			{
				stack.Pop();
			}
			else if (s == "D")
			{
				current = stack.Pop();
				int doubleCurrent = current * 2;
				stack.Push(current);
				stack.Push(doubleCurrent);
			}
			else if (s == "+")
			{
				current = stack.Pop();
				int previous = stack.Pop();
				int previousAndCurrent = current + previous;
				stack.Push(previous);
				stack.Push(current);
				stack.Push(previousAndCurrent);
			}
			else
			{
				current = int.Parse(s);
				stack.Push(current);
			}
		}
		int[] res = stack.ToArray();
		Console.WriteLine(string.Join(",",res));
	}
}
