using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Device dev = new Device("Hard Disk");
            dev.DeviceName1 = "dev1";
            Console.WriteLine(dev.DeviceName1);
            Console.WriteLine(dev.DeviceType);
            Console.WriteLine(dev.LastChangeDate);
            dev.addToTree("c/");
            dev.addToTree("programs");
            dev.addToTree("bla.txt");
            Console.WriteLine(dev.LastChangeDate);
            Console.WriteLine(dev.getTree());
            Console.WriteLine();


            
            Directory dir = new Directory("c/");
            Console.WriteLine(dir.DirectoryName);
            Console.WriteLine(dir.LastChangeDate);
            dir.addToTree("programs");
            dir.addToTree("bla.txt");
            Console.WriteLine(dir.LastChangeDate);
            Console.WriteLine(dir.getTree());
            Console.WriteLine();


            File txt = new File("text");
            Console.WriteLine(txt.FileType);
            txt.addToTree("bla1");
            txt.addToTree("bla2");
            Console.WriteLine(txt.DateOfLastChange1);
            Console.WriteLine(txt.getTree());
            txt.deleteLast();
            Console.WriteLine(txt.getTree());
            Console.WriteLine(txt.DateOfLastChange1);
            Console.WriteLine();


            File bin = new File("binary");
            Console.WriteLine(bin.FileType);
            bin.addToTree("0");
            bin.addToTree("1");
            Console.WriteLine(bin.DateOfLastChange1);
            Console.WriteLine(bin.getTree());
            bin.deleteLast();
            Console.WriteLine(bin.getTree());
            Console.WriteLine(bin.DateOfLastChange1);


            Console.ReadKey();
        }
    }
}
