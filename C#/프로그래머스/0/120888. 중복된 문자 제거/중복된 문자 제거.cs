using System;
using System.Linq;

public class Solution {
    public string solution(string my_string) { 
        string result = new string(my_string.Distinct().ToArray());
        return result;
    }
}
