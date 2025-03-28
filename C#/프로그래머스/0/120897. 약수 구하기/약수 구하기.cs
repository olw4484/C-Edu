using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        
        List<int> num = new List<int>();
        
        int sqrt = (int)Math.Sqrt(n);
        for (int i = 1; i <= sqrt; i++)
        {
            if (n % i ==0)
            {
                num.Add(i);
                if (i != n / i)
                {
                    num.Add(n / i);
                }
            }
        }
        num.Sort();
        int[] answer = num.ToArray();
        return answer;
    }
}