using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Video : File,extention
    {
        int length;
        public Video(string name, string location,int size,int length) : base(name, location,size)
        {
            this.length = length;
            current_extention = ".mp4";
        }
        public void change_length(int new_length)
        {
            length = new_length;
        }

        public string current_extention { get; private set; }
        public override string Name { get => base.Name + current_extention; set => base.Name = value; }

        public void change_extention(string new_ext)
        {
            current_extention = new_ext;
        }

        public void Delete_ext()
        {
            current_extention = "";
        }
        public int Length { get => length; set => length = value; }
    }
}
