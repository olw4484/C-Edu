using System;

public class Solution {
    public string solution(string rny_string) {
        string replaced = rny_string.Replace("m", "rn");
        return replaced.ToString();
    }
}