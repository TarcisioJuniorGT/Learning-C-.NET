// See https://aka.ms/new-console-template for more information

using Learning_CSharp_.NET.Models;

Person testPerson = new() // camelCase
{
    Name = "Bob",
    Age = 23
};

testPerson.Presentation();