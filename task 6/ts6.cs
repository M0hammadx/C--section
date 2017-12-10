using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Create(string path, string file)
        {

            if (File.Exists(path + file)) Delete(path, file);
            using (FileStream fs = File.Create(path+file))
            {
            }
        }
        static string[] Read(string path, string file)
        {
            if (File.Exists(path + file))
                return File.ReadAllLines(path+ file);
            return new string[1];
        }
        static void Update(string path, string file, string s)
        {
            // File.SetAttributes(path+file, FileAttributes.Normal);
            if (!File.Exists(path + file)) Create(path, file);
            using (StreamWriter sw = File.AppendText(path+file))
            {
                sw.WriteLine(s);
            }
        }
        static void Delete(string path, string file)
        {
           
            if (File.Exists(path+file))
                File.Delete(path+file);
            

            // File.SetAttributes(path + file, FileAttributes.Normal);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter path followed by file");
          string path= @"F:\", file= "test.txt";
          //  path=Console.ReadLine(); file= Console.ReadLine();
            Create(path,file);
            while (true)
            {
                Console.WriteLine("choose action \n 1-create new student \n 2-search for students \n 3-update students \n 4-delete student \n");
                string s = Console.ReadLine();


                if (s == "1")
                {
                    string name = Console.ReadLine(), mail = Console.ReadLine(), gender = Console.ReadLine(), num = Console.ReadLine();
                    Update(path, file, name + " " + mail + " " + num + " " + gender);
                }

                if (s == "2")
                {
                    string target = Console.ReadLine();
                    bool f = false;
                    string[] data = Read(path, file);
                    foreach (var d in data)
                    {
                        string name = d.Split(' ')[0];
                        if (name == target) { Console.WriteLine("found"); f = true; break; }

                    }
                    if (!f) Console.WriteLine("not found");
                }
                if (s == "3")
                {
                    string oldname = Console.ReadLine(), name = Console.ReadLine(), mail = Console.ReadLine(), gender = Console.ReadLine(), num = Console.ReadLine();

                    string[] data = Read(path, file);
                    for (int i = 0; i < data.Length; i++)
                    {
                        string nam = data[i].Split(' ')[0];
                        if (nam == oldname) { data[i] = name + " " + mail + " " + num + " " + gender; break; }

                    }
                    Create(path, file);
                    for (int i = 0; i < data.Length; i++)
                    {

                        Update(path, file, data[i]);
                    }

                }
                if (s == "4")
                {
                    string oldname = Console.ReadLine();

                    string[] data = Read(path, file);
                    for (int i = 0; i < data.Length; i++)
                    {
                        string nam = data[i].Split(' ')[0];
                        if (nam == oldname) { data[i] = "0"; break; }

                    }
                    Create(path, file);
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (data[i] != "0")
                            Update(path, file, data[i]);
                    }

                }

            }

            Console.ReadKey();
        }
    }
}
