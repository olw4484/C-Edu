using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        List<char> list = new List<char>(my_string.ToCharArray());
        
        char temp = list[num1];
            list[num1] = list[num2];
            list[num2] = temp;
        string answer = string.Join("", list);
        
        return answer;
    
    }
}