using System;

namespace InterfaceDemo
{
    public class Model
    {
        public class Person : IPersonInterface
        {
            public string fName { get; set; }
            public string lName { get; set; }
            public int Age { get; set; }
            public Person(string fname, string lname, int age)
            {
                fName = fname;
                lName = lname;
                Age = age;
            }
            public int addAge(int age)
            {
                return age + 1;
            }

            public string getFullName(string fName, string lName)
            {
                return fName+ " "+ lName;
            }
        }
    }
}