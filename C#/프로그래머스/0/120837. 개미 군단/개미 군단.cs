using System;

public class Solution {
    public int solution(int hp) {
        int antG = 5;
        int antS = 3;
        int antW = 1;
        int answer = 0;
        
        answer += hp / antG;
        hp %= antG;
        answer += hp / antS;
        hp %= antS;
        answer += hp / antW;
        hp %= antW;
        

        return answer;
    }
}