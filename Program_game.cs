using System.Globalization;
using System.Numerics;
using System;
using System.IO;
using System.Collections.Generic;
using CsvHelper;

namespace света {
	
public class Program2
{	
  public static void Main()
	{
         Game games= new Game();
         int the_max=0;
         int the_min=0;
              		var csv_file = File.ReadAllLines("file2.csv").Skip(1);
                  var all_games = csv_file;
       
                 var games0 = csv_file.Select(games.ParsePersonFromLine);
                 if(games0.Any())
                 { the_max = games0.Max(row => row.price);
                   the_min = games0.Min(row => row.price);
                 }
    
                
                var games1 = csv_file.Select(games.ParsePersonFromLine)
                 .Where(p => p.price <= 140).Where(p => p.max > 5);
               
                Console.WriteLine(games1.ToList().Count);

                
            var games2 = csv_file.Select(games.ParsePersonFromLine).Where(p=>p.name=="Mary").ToList();
            if (games2.Any())
                    {
                int max = games2.Max(row => row.price);
                Console.WriteLine("max="+max);
                    }
            foreach( var i in games2) { Console.WriteLine(i.name);  }
                
             var games3 = csv_file.Select(games.ParsePersonFromLine).Where(p=> (the_max-p.price)<=40 ).ToList();
                    foreach( var i in games3) { Console.WriteLine(i.name);  }

              var games4 = csv_file.Select(games.ParsePersonFromLine).Where(p=> (p.max==4 || p.max==5) ).ToList();
              int the_4_max=0;
                if (games4.Any())
                    {
                 the_4_max = games4.Max(row => row.price);
                Console.WriteLine("max="+the_4_max);
                    }
                games4 = csv_file.Select(games.ParsePersonFromLine).Where(p=> (p.max==4 || p.max==5)).Where(p=>p.price==the_4_max).ToList();     
                    foreach( var i in games4) { Console.WriteLine(i.name);  }       
  }
}

        
}


