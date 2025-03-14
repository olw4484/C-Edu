using System;

public class Solution {
    public int solution(int n, int k) {
        int sheep = n*12000;
        int drink = k*2000-(n/10 *(2000));
        
        int total = sheep + drink;
        return total;
    }
    
}
