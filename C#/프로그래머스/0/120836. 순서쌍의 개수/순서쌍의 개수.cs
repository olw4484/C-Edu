using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n) {
        List<int> numberCount = new List<int>();
        
        for(int i = 1; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                numberCount.Add(i);
                if(i != n / i)
                {
                    numberCount.Add(n/i);
                }
            }
        }
        
        
        return numberCount.Count;
    }
}