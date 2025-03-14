using System;

public class Solution {
    public float solution(float num1, float num2) {
        float a = num1 / num2;
        float b = a*1000;
        
        float answer = (int)b;

        return answer;
    }
}