using System;
using System.Text.RegularExpressions;

public class Solution
{
    public int solution(string[] babbling)
    {
        int count = 0;

        Regex regex = new Regex("^(?!.*(ayaaya|yeye|woowoo|mama))(aya|ye|woo|ma)+$");

        foreach (string word in babbling)
        {
            if (regex.IsMatch(word))
            {
                count++;
            }
        }
        return count;
    }
}
