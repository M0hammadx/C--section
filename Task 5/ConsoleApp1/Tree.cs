using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tree
    {
        int lastChangeDate=0;
        string[] tree = new string[10];
        int i = 0;

        public int LastChangeDate { get => lastChangeDate; set => lastChangeDate = value; }

        public void addToTree(string x)
        {
            lastChangeDate++;
            tree[i++] = x;
        }
        public void deleteLast()
        {
            lastChangeDate++;
            i--;
        }
        public string getTree()
        {
             string res = "";
             for (int j = 0; j < i; j++) res += tree[j] + " ";
             return res;
            
        }
    }
}
