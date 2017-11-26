using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Text : File,extention
    {
       static int number_of_lines=0;
        string[] txt=new string[10];

        public static int Number_of_lines { get => number_of_lines; set => number_of_lines = value; }

        public Text(string name, string location) : base(name, location)
        {
            current_extention = ".txt";
        }


        public string get_text()
        {
            string s = "";
            for(int i = 0; i < number_of_lines; i++)
            {
                s += txt[i]+" ";
            }
            return s;
        }

        public void add_line(string line)
        {
            txt[number_of_lines] = line;
            number_of_lines++;


        }
        public string current_extention { get; private set; }
        public override string Name { get => base.Name+ current_extention; set => base.Name = value; }

        public void change_extention(string new_ext)
        {
            current_extention = new_ext;
        }

        public void Delete_ext()
        {
            current_extention = "";
        }
    }
}
