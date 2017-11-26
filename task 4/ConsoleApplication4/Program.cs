using System;
using System.Collections.Generic;
using ConsoleApplication4;
public class Test
{
    public static void Main()
    {
        var txt = new Text("file1","c/");
        txt.add_line("1");
        txt.add_line("2");

        Console.WriteLine(txt.Name);
        txt.change_extention(".doc");  //extentions
        Console.WriteLine(txt.Name);    
        txt.Delete_ext();
        Console.WriteLine(txt.Name);
        Console.WriteLine(txt.Location);
        Console.WriteLine(txt.get_text());// text in text
        Console.WriteLine("");

        var vid = new Video("file2", "c/",1024,60);
        Console.WriteLine(vid.Name);
        vid.change_extention(".vlc");  //extentions
        Console.WriteLine(vid.Name);
        vid.Delete_ext();
        Console.WriteLine(vid.Name);
        Console.WriteLine(vid.Length);  // data
        vid.change_length(120);
        Console.WriteLine(vid.Length);
        Console.WriteLine(vid.Size);
        Console.WriteLine();

        var img = new Image("file1", "c/",1080);
        Console.WriteLine(img.Name);
        img.change_extention(".bng");  //extentions
        Console.WriteLine(img.Name);
        img.Delete_ext();
        Console.WriteLine(img.Name);
        Console.WriteLine(img.Location);
        Console.WriteLine(img.Resolution);
        img.change_resolution(720);
        Console.WriteLine(img.Resolution);
        Console.ReadKey();
    }
}