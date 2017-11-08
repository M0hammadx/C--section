using System;
using System.Collections.Generic;
public class Test
{
    public static void Main()
    {
        int n;
        Console.WriteLine("enter number of students");
        n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> deg = new Dictionary<string, int>();
        int maxdegree = -10;
        string maxname = "";
        while (--n >= 0)
        {
            Console.WriteLine("enter student name");
            string s;
            s = Console.ReadLine();
            Console.WriteLine("enter student degree");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            deg[s] = x;
            if (x > maxdegree)
            {
                maxdegree = x;
                maxname = s;
            }
        }
        while (1 == 1)
        {
            Console.WriteLine("1-Search for student degree /n2-Get top student name and degree /n3-Change a student name");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter a student name");
                string sname;
                sname = Console.ReadLine();
                if (deg.ContainsKey(sname))
                {
                    Console.WriteLine(deg[sname]);
                }
                else
                {
                    Console.WriteLine("student not found");
                }
            }
            if (choice == 2)
            {
                Console.WriteLine(maxname + " " + maxdegree);
            }
            if (choice == 3)
            {
                Console.WriteLine("Enter old student name");
                string ssname;
                ssname = Console.ReadLine();
                if (deg.ContainsKey(ssname))
                {
                    Console.WriteLine("enter the new name for the student");
                    string sssname;
                    sssname = Console.ReadLine();
                    if (ssname == maxname) { maxname = sssname; }
                    deg[sssname] = deg[ssname];
                    deg.Remove(ssname);
                }
                else
                {
                    Console.WriteLine("student not found");
                }
            }
        }
    }
}
