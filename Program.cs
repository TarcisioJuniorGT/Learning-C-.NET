// See https://aka.ms/new-console-template for more information

using Learning_CSharp_.NET.Models;

Console.WriteLine("Hello World!");

Person testPerson = new() // camelCase
{
    Name = "Bob",
    Age = 23
};

testPerson.Presentation();