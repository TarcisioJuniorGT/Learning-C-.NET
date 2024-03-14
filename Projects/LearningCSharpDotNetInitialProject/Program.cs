// See https://aka.ms/new-console-template for more information

using LearningCSharpDotNetCommon.Models;

Person testPerson = new() // camelCase
{
    Name = "Bob",
    Age = 23
};

testPerson.Presentation();