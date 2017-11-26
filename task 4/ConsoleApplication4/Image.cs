using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Image : File,extention
    {
        int resolution;

        public Image(string name, string location,int resolution) : base(name, location)
        {
            current_extention = ".jpg";
            this.resolution = resolution;
        }
        public void change_resolution(int new_resolution)
        {
            resolution = new_resolution;
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
        public int Resolution { get => resolution; set => resolution = value; }
       
    }
}
