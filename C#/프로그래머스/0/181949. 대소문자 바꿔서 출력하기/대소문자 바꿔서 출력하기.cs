using System;

public class Example
{
    public static void Main()
    {
        String s = Console.ReadLine();
        String result = ReverseCase(s);
        Console.WriteLine(result);
    }    
    public static string ReverseCase(string s)
    {
        char[] characters = s.ToCharArray();
        
        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsUpper(characters[i]))
            {
                characters[i] = char.ToLower(characters[i]);
            }
            else if (char.IsLower(characters[i]))
            {
                characters[i] = char.ToUpper(characters[i]);
            }
            
            
        }
        return new string(characters);
       
    }
        
         

}
