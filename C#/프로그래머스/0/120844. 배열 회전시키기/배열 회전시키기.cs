using System;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
        int[] answer = (int[])numbers.Clone();
        
        switch(direction)
        {
            case "right":
                int temp1 = answer[answer.Length - 1];
                    for(int i = answer.Length - 1; i > 0; i--)
                    {
                        answer[i] = answer[i - 1];
                    }
                answer[0] = temp1;
                break;

            case "left":
                int temp2 = answer[0];
                    for(int i = 0; i < answer.Length - 1; i++)
                    {
                        answer[i] = answer[i + 1];
                    }
                    answer[answer.Length - 1] = temp2;
                break;
        }
        
        return answer;
    }
}