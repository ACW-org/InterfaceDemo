using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public static class Repo
    {
        public static int addSomeAge(int age)
        {
            return age + 10;
        }

        public static string getFullNameWithPrefix(string FullName)
        {
            return "Mr" +" "+ FullName;
        }
    }
}
