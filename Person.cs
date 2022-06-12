using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace света
{
    public class Person
    
{
   public int id { get; set; }
   public int kolvo { get; set; }
   public string lastname { get; set; }
   public int kg { get; set; }

    public Person ParsePersonFromLine(string line)
    {
    string[] parts = line.Split(',');
    
    return new Person {
        id = Int32.Parse(parts[0]),
        kolvo = Int32.Parse(parts[1]),
        lastname = parts[2],
        kg = Int32.Parse(parts[3])
    };
    }
    public String hi() { Console.WriteLine("hello"); return "a";}

}				

        
       
}

