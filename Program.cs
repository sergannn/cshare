using System.Globalization;
using System.Numerics;
using System;
using System.IO;
using System.Collections.Generic;
using CsvHelper;

namespace света {
	
public class Program
{	public static void Main()
	{
         Person persons= new Person();
       
              		var csv_file = File.ReadAllLines("file.csv").Skip(1);
                  var all_persons = csv_file;
                  
                  int[] kolvos=new int[csv_file.ToList().Count];
                  int[] kgs=new int[csv_file.ToList().Count];
                  
                  // double avg = Queryable.Average(all_persons.AsQueryable());
            
                var persons1 = csv_file.Select(persons.ParsePersonFromLine)
                 .Where(p => p.kolvo > 20);
               
                Console.WriteLine(persons1.ToList().Count);

                int index = 0;
                foreach (var i in persons1)
                {  
                  kolvos[index]=i.kolvo;
                  kgs[index]=i.kg;
                  index++;
                 }
                double avg = Queryable.Average(kolvos.AsQueryable());
                
            var persons2 = csv_file.Select(persons.ParsePersonFromLine)
                 .Where(p => p.kolvo > avg);

                  foreach (var i in persons2)
                {  
                  Console.WriteLine(i.lastname); 
                  }

              // допустим m=49
             var persons3 = csv_file.Select(persons.ParsePersonFromLine)
                 .Where(p => p.kolvo == 1).Where(p => p.kg < 49);
                
                 foreach( var i in persons3)
                 {
                  Console.WriteLine(i.kg+i.kolvo+i.lastname);
                 }

                if(persons3.ToList().Count==0) { Console.WriteLine("No passenger"); } else { Console.WriteLine("There is such passenger:"+persons3.ToList().Count);  }
                 
                   int maxxkgs = Queryable.Max(kgs.AsQueryable()); Console.WriteLine("Max wage:"+maxxkgs);
                   int minkgs =  Enumerable.Min(kgs); Console.WriteLine("Min wage:"+minkgs);
                 

                  var persons4 = csv_file.Select(persons.ParsePersonFromLine)
                 .Where(p => p.kg == maxxkgs);
                 foreach( var i in persons4.ToList()) {  Console.WriteLine(i.lastname); }

                  var persons5 = csv_file.Select(persons.ParsePersonFromLine)
                 .Where(p => p.kg == minkgs);
                  foreach( var i in persons5.ToList()) {  Console.WriteLine(i.lastname); }

                  //допустим м=500
                     var persons6 = csv_file.Select(persons.ParsePersonFromLine)
                 .Where(p => (p.kg/p.kolvo <= (avg-500)));
                  foreach( var i in persons6.ToList()) {  Console.WriteLine(i.lastname); }
    }
        
}
}

