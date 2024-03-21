using LearningCSharpDotNetCommon.Models;
using Newtonsoft.Json;

Person firstPerson = new("Bob", 23);
Person secondPerson = new("Ana", 22);

List<Person> personList = [firstPerson, secondPerson];

string serialized = JsonConvert.SerializeObject(personList, Formatting.Indented);

File.WriteAllText("./files/person.json", serialized);

string deserialized = File.ReadAllText("./files/person.json");

List<Person>? personListRead = JsonConvert.DeserializeObject<List<Person>>(deserialized);

foreach (Person p in personListRead)
{
    Console.WriteLine($"Name: {p.Name} - Age: {p.Age}");
}