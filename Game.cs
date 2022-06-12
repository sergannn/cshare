using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace света
{
    public class Game
    
{
   public string name { get; set; }
   public int min { get; set; }
   public int price { get; set; }
   public int max { get; set; }

    public Game ParsePersonFromLine(string line)
    {
    string[] parts = line.Split(',');
    
    return new Game {
        min = Int32.Parse(parts[2]),
        max = Int32.Parse(parts[3]),
        name = parts[1],
        price = Int32.Parse(parts[4])
    };
    }
    public String hi() { Console.WriteLine("hello"); return "a";}

}				

        
       
}

