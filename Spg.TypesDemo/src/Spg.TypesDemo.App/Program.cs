Console.WriteLine("Hello, World!");

int i = 12;

Console.WriteLine(i);

Person p = new Person();
p.Id = 4711;
p.Name= "Test";

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}
