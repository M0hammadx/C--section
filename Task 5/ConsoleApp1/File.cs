using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class File
    {
        string fileName,directory;
        int dateOfCreation=0,DateOfLastChange,time=0;

        string[] content = new string[10];
        int i = 0;
        private string fileType;

        public File(string v)
        {
            this.fileType = v;
        }

        public void addToTree(string x)
        {
            DateOfLastChange = ++time;
            content[i++] = x;
        }
        public void deleteLast()
        {
            DateOfLastChange = ++time;
            i--;
        }
        public string getTree()
        {
            string res = "";
            for (int j = 0; j < i; j++) res += content[j] + " ";
            return res;
        }
        public string FileName { get => fileName; set => fileName = value; }
        public string Directory { get => directory; set => directory = value; }
        public string FileType { get => fileType; set => fileType = value; }
        public int DateOfCreation { get => dateOfCreation; set => dateOfCreation = value; }
        public int DateOfLastChange1 { get => DateOfLastChange; set => DateOfLastChange = value; }
        public int Time { get => time; set => time = value; }
    }
}
