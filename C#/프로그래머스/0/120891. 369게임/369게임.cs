using System;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(int order) {
        string numbers = order.ToString();
        MatchCollection matches = Regex.Matches(numbers, "[369]");
            
        return matches.Count;
    }
}