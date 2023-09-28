using Spg.TypesDemo.DoaminModel.Model;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");

int i = 12;

Console.WriteLine(i);

Person p = new Person();
p.Id = 4711;
p.Name= "Test";

Product product = new Product();

string s = Console.ReadLine();

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}
