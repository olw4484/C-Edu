using System;
using System.Linq;

public class Solution {
    public int[] solution(string my_string) {
        int[] answer = my_string
            .Where(char.IsDigit)
            .Select(c => int.Parse(c.ToString()))
            .ToArray();
        Array.Sort(answer);
        return answer;
    }
}