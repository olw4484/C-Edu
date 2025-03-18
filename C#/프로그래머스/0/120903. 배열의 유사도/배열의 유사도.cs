using System;
using System.Linq;

public class Solution {
    public int solution(string[] s1, string[] s2) {
        int answer = 0;
        var elimental = s1.Intersect(s2);
        
        foreach(var item in elimental)
        {
            answer++;
        }
        return answer;
    }
}