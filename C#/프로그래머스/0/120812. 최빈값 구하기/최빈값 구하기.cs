using System; 

public class Solution { 
    public int solution(int[] array) {
        Array.Sort(array);
        if(array.Length == 1)
        {
            return array[0];
        }
            
            
        int number = array[0];
        int count = 1;
        int maxNumber = number;
        int maxCount = count;
        bool multiple = false;
        
        for (int i = 1; i < array.Length; i++) 
        {
            if (array[i] == number) 
            {
                count++; 
            } 
            else 
            { 
                if(count > maxCount)
                {
                    maxCount = count;
                    maxNumber = number;
                    multiple = false;
                } 
                else if (count == maxCount) 
                {
                    multiple = true; 
                } 
            
            number = array[i];
            count = 1;
            }
        }
        if (count > maxCount) 
        {
            maxNumber = number;
            multiple = false;
        }
        else if(count == maxCount) 
        {
            multiple = true; 
        } 
        return multiple ? - 1 : maxNumber;
    } 
}