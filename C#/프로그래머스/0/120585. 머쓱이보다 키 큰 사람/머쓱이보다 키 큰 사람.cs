using System;

public class Solution {
    public int solution(int[] array, int height) {
        int count = 0;
        
        foreach (int i in array)
        {
            if(i > height)
            {
                count++;   
            }
            
        }
        return count;
    }
}