
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Int32.Parse(Console.ReadLine());

         
            string[] s = { "zero", "one", "two", "three", "four", "five", "six ", "seven", "eight", "nine","ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            string[] ss = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };


           
                int a = n % 10; 
                int b = (n / 10) % 10;
                int c = (n / 100) % 10;


         if (n > 100)
            {

                Console.WriteLine(s[c] + " hundred");
                if (a != 0)

                    Console.WriteLine("and ");

                n %= 100;
            }
               
             if(n<=19)
                        Console.WriteLine(s[n]);
                     
                  else  if (a == 0)
                    
                        Console.WriteLine(ss[b - 2]);
                    
                    else
                    
                        Console.WriteLine(ss[b - 2] + "-" + s[a]);
                    
                

                    
                }
            }
           
        }

    
    

