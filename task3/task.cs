using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
 
    class Program
    {
        static Dictionary<string, int> dic = new Dictionary<string, int>();
        static int check(ref string x)
        {
           
            if (!dic.ContainsKey(x))
            
            {
                Console.WriteLine("student not found");
                return 0;
            }
            return 1;
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("enter no of students");
            int n;
            n = int.Parse(Console.ReadLine());

           
            string mx="";
            int max=-1;
            
            while (--n>=0)
            {
                Console.WriteLine("enter data");
                string s;
                s = Console.ReadLine();
                int x;
                x = int.Parse(Console.ReadLine());
                dic[s]=x;
                if (x > max)
                {
                    max = x;
                    mx = s;
                }
            }
            while (1==1)
            {
                Console.WriteLine("1-Search for student degree \n2 - Get top student name and degree \n3 - Change a student name\n");
                Console.WriteLine("enter choice ");
                int x=int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    string s = Console.ReadLine();
                    if (check(ref s) != 0)
                    {
                        Console.WriteLine("degree is " + dic[s]+"\n");
                    }

                }
                else if (x == 2)
                {
                    Console.WriteLine(string.Format("student name {0} with score {1} \n", mx, max));

                } else
                {
                    Console.WriteLine("enter old name ");
                    string s = Console.ReadLine();
                    if (check(ref s) != 0)
                    {
                        Console.WriteLine("enter new name ");
                        string s2 = Console.ReadLine();
                        dic[s2] = dic[s];
                        dic[s] = 0;
                        if (s == mx) { mx = s2; }
                    }

                }

            }



        }
    }
           
}

