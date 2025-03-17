using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        foreach (char c in Math.Abs(n).ToString())
        {
             answer += c - '0';
        }
        return answer;
    }
}