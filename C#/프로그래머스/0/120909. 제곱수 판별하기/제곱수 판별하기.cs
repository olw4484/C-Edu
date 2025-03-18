using System;

public class Solution {
    public double solution(double n) {
        int count = 0;
        double sqrt = Math.Sqrt(n);
        if (n % sqrt == 0)
        {
            count++;
        }
        else
        {
            return 2;
        }
        return count;
    }
}