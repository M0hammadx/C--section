using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Directory:Tree
    {
        string directoryName;
        
        

        public Directory(string directoryName)
        {
            this.directoryName = directoryName;
            LastChangeDate = 0;
        }

        
        public string DirectoryName { get => directoryName; set => directoryName = value; }
         }
}
