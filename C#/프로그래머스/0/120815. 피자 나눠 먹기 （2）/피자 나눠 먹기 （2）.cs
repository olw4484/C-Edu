using System;

public class Solution {
    public int solution(int n) {
  
        return LCM(n , 6) / 6;
    }
    public static int GCD(int a, int b)
    {
        while(b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }            
        return a;
    }

    public static int LCM (int a, int b)
    {
        return (a*b) / GCD(a,b);
    }
}
    