// See https://aka.ms/new-console-template for more information
using static InterfaceDemo.Repo;
using static InterfaceDemo.Model;

var PersonA = new Person("firstName", "lastName", 10);

var fullName = PersonA.getFullName(PersonA.fName, PersonA.lName);

var newFullName = getFullNameWithPrefix(fullName);

Console.WriteLine(newFullName);
Console.WriteLine(" ");