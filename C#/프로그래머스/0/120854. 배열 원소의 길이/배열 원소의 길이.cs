using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] strlist) {
        return strlist.Select(s => s.Length).ToArray();
    }
}

