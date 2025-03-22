using System;

public class Solution {
    public string solution(string my_string) {
        string vowels = "aeiou";
        string answer = my_string;
        
        foreach (char vowel in vowels)
        {
            answer = answer.Replace(vowel.ToString(),"");
        }
            
        return answer;
    }
}