using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IPersonInterface
    {
        string getFullName(string fName, string lName);
        int addAge(int age);
    }
}
