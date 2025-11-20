using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(string[] operations)
    {
        SortedDictionary<int, int> dict = new SortedDictionary<int, int>();

        foreach (var op in operations)
        {
            if (op[0] == 'I')
            {
                int num = int.Parse(op.Substring(2));
                if (!dict.ContainsKey(num))
                    dict[num] = 0;
                dict[num]++;
            }
            else if (op[0] == 'D')
            {
                if (dict.Count == 0)
                    continue;

                if (op[2] == '1')
                {
                    var last = dict.Last();
                    int key = last.Key;
                    if (last.Value == 1)
                        dict.Remove(key);
                    else
                        dict[key] = last.Value - 1;
                }
                else
                {
                    var first = dict.First();
                    int key = first.Key;
                    if (first.Value == 1)
                        dict.Remove(key);
                    else
                        dict[key] = first.Value - 1;
                }
            }
        }

        if (dict.Count == 0)
            return new int[] { 0, 0 };

        int max = dict.Last().Key;
        int min = dict.First().Key;
        return new int[] { max, min };
    }
}
