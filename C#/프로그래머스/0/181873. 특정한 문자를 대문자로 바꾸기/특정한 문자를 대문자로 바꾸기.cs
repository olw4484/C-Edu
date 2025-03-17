using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        
        foreach (char c in my_string)
        {
            if (c.ToString() == alp)
            {
                answer += char.ToUpper(c);
            }
            else
            {
                answer += c;
            }
        }
        
        
        
        
        return answer;
    }
}