using System;

public class Solution {
    public int solution(int[] array) {
        Array.Sort(array);
        int answer = array.Length/2;
        return array[answer];
    }
}