using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningCSharpDotNetCommon.Models
{
    public class Person
    {
        public string Name { get; set; } //PascalCase
        public int Age { get; set; }
        
        public void Presentation() { // PascalCase
            Console.WriteLine($"Hello, my name is {Name} and i am {Age} years old.");
        }
    }
}