using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class File
    {
        string name;
        string location;
        int size;

        public virtual string Name { get => name; set => name = value; }
        public int Size { get => size; set => size = value; }
        public string Location { get => location; set => location = value; }

        public File(string name,string location,int size)
        {
            this.name = name;
            this.location = location;
            this.size = size;
        }

        public File(string name, string location)
        {
            this.name = name;
            this.location = location;
        }
    }
}
