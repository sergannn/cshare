using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace света
{
    public class Registration
    {
        public static String name;
        public static String pass;
        public static String pass2;
        public static String login;

     public static void Main()
     {  
          Name();
          Login();
          Pass();
     }
                    public static void Name() {
                        Console.Write("\nYour name: ");
                         name = Console.ReadLine();
                         var match = name.IndexOfAny("0123456789".ToCharArray()) != -1;
                         if(match) { Console.WriteLine("should contain no numbers"); Name(); }
                    }
                     public static void Login() {
                        Console.Write("\nYour login: ");
                         login = Console.ReadLine();
                       
                    }
                    public static void Pass() {
                        Console.Write("\nYour pass: ");
                         pass = Console.ReadLine();
                         if(!isLettersAndNumbers(pass))  {
                             Console.WriteLine("should contain both letters and numbers"); Pass();
                         }
                         else {
                            Console.Write("\nYour pass again: ");
                              pass2 = Console.ReadLine();
                            if(pass==pass2) { Console.WriteLine("Thanks! "+name+" is registrated"); Log(); }
                         }

                    }
                    public static void Log() {
                    Console.Write("\nYour login: ");
                     String log = Console.ReadLine();
                      Console.Write("\nYour pass: ");
                     String log_pass = Console.ReadLine();
                     if(log==login && pass==log_pass) {   
                          Console.Write("\nLets convert a number: ");
                           String some_num = Console.ReadLine();
                        String res = Convert.ToString ( Convert.ToInt32(some_num), 2);
                        Console.WriteLine(res);
                          }


                    }
                    public static bool isLettersAndNumbers(string text)
                   {
                        int ctr_letters = text.Count(char.IsLetter);
                        int ctr_digits = text.Count(char.IsDigit);            
                        if(ctr_digits>0 && ctr_letters>0) { return true;} else { return false;}
                        
                     }

    }
}