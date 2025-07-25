using System;
using System.Collections.Generic;

public class Solution1160
{
    public static int CountCharacters(string[] words, string chars)
    {
        int res = 0;
        var letters = new Dictionary<char, int>();
        
        foreach (char c in chars)
        {
            if (!letters.ContainsKey(c))
            {
                letters[c] = 1;
            }
            else 
            {
                letters[c]++;
            }
        }

        foreach (string word in words)
        {
            int length = 0;
            var lettersCopy = new Dictionary<char, int>(letters);

            foreach (char c in word)
            {
                if (!lettersCopy.ContainsKey(c) || lettersCopy[c] <= 0)
                {
                    length = 0;
                    break;
                }
                else 
                {
                    length++;
                    lettersCopy[c]--;
                }
            }

            res += length;
        }

        return res;
    }
}

