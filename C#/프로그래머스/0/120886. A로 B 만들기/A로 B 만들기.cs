using System;
using System.Linq;

public class Solution {
    public int solution(string before, string after) {
        
        char[] sortedBefore = before.ToCharArray();
        char[] sortedAfter = after.ToCharArray();
        
        Array.Sort(sortedBefore);
        Array.Sort(sortedAfter);
        
        return sortedBefore.SequenceEqual(sortedAfter) ? 1 : 0;
    }
}
