using System;

public class Solution {
    public double solution(double n) {
        double sqrt = Math.Sqrt(n);
        if (n % sqrt == 0)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
}