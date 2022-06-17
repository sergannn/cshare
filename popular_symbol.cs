using System;
using System.Linq;
using System.Collections.Generic;  
using System.Reflection;  
using System.Collections;  
namespace MyApplication
{
  class Program
  {  
      private static void CalculateMaxCharCountUsingArray(string actualString)
        {
    Dictionary<char, int> dic = new Dictionary<char,int>();
            char[] charArray = actualString.ToCharArray();
            int[] arr = new int[256];
            int maxCount = 0;
            char maxChar = ' ';
            foreach (var r in charArray)
            {
               arr[r] = arr[r] + 1;
            }
            IEnumerable<char> distinctCharArray = charArray.Distinct();
            foreach(var r in distinctCharArray)
            {
                 if(r.Equals("."[0])) 
                 {  break; }
                dic.Add(r, arr[r]);
            }
            int the_max = dic.Values.Max();
            int Counter = 0;
              Dictionary<int, HashSet<char>> final_dic = 
              new Dictionary<int,HashSet<char>>();
              HashSet<char> maxs = new HashSet<char>();
            foreach(var r in dic)
            {
        if((int)r.Value == the_max) { maxs.Add(r.Key);  }
            }
         
            Console.WriteLine(maxs.Min());
        }
    static void Main(string[] args)
     {
       
        CalculateMaxCharCountUsingArray("yyyybccc. Helloooooooooooooooo");
     }
}
}
