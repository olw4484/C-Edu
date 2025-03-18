using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers, int num1, int num2) {
        return numbers.Skip(num1).Take(num2 - num1 + 1).ToArray();
    }
}
