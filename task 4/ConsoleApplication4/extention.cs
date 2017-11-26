using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    interface extention
    {
        string current_extention { get;  }
        void change_extention(string new_ext);
        void Delete_ext();
    }
}
