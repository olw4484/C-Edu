using System;

public class Solution {
    public int solution(int price) {
        double discount = 0.0;
        
        if (price >= 500000)
        {
            discount = 0.20;
        }
        else if (price >= 300000)
        {
            discount = 0.10;
        }
        else if (price >= 100000)
        {
            discount = 0.05;
        }

        double a = price * (1 - discount);
        return (int) a;
    }
}