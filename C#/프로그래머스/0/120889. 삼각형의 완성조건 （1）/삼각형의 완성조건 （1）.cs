using System;

public class Solution {
    public int solution(int[] sides) {
        Array.Sort(sides);
        return sides[2] < sides[0]+sides[1] ? 1:2;
    }
}

//가장 긴 변의 길이는 두변의 합보다 작아야한다.
//a + b > c이다. 같으면 안되니까 = 안들어간다.
//배열값을 확인하는 코드.
//순차정리 Sort