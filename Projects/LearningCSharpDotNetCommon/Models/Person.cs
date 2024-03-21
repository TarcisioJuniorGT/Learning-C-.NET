using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LearningCSharpDotNetCommon.Models
{
    public class Person
    {
        public Person(string name, int age) {
            Name = name;
            Age = age;
        }
        private string? _name;
        private int _age;

        [JsonProperty("Name")]
        public string? Name 
        { 
            get => _name;

            set {
                if(value == "" || value == null)
                {
                    throw new ArgumentException("Invalid name");
                }
                _name = value;
            }
        } 
        public int Age
        { 
            get => _age;

            set {
                if(value <= 0)
                {
                    throw new ArgumentException("Invalid age");
                }
                _age = value;
            }
        } 
        public void Presentation()
        {
            Console.WriteLine($"Hello, my name is {Name} and i am {Age} years old.");
        }
    }
}