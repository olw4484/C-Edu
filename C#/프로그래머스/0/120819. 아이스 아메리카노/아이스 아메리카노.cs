using System;

public class Solution {
    public int[] solution(int money) {
        int oderCount = 0;
        
        while (money >= 5500) {
            oderCount++;
            money -= 5500;
        }
        return new int[] {oderCount, money};
    }
}