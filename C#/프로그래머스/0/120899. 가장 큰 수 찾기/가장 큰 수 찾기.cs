using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] array) {
        int max = array.Max();
        int index = Array. IndexOf(array, max);
        return new int[] {max , index};
    }
}