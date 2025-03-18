using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {

        int numerator = numer1 * denom2 + numer2 * denom1; 
        int denominator = denom1 * denom2; 

        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;

        return new int[] { numerator, denominator };
    }


    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a); 
    }
}
