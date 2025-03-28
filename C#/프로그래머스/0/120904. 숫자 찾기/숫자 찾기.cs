using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int num, int k) {
        List<int> list = new List<int>();
        foreach(char c in num.ToString())
        {
            list.Add(c - '0');
        }
        
        int index = list.IndexOf(k);
        
        return (index >= 0) ? index + 1 : -1;
    }
}