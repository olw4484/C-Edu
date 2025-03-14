using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] dot) {
        List<int> list = new List<int>(dot);
        int a = dot[0];
        int b = dot[1];
            
            if(a > 0 && b > 0) // 꺼내서 비교하는 방법이 이게 아닌가.
            {
                return 1;
            }
            else if(a < 0 && b > 0)
            {
                return 2;
            }
            else if(a < 0 && b < 0)
            {
                return 3;
            }
            else if(a > 0 && b < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
    }
}