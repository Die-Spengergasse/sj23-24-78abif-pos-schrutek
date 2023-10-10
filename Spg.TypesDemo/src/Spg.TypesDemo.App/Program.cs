using Spg.TypesDemo.DoaminModel.Model;

Console.WriteLine("Hello, World!");

Nullable<int> i = null;

Console.WriteLine(i);
if (i.HasValue)
{
    int j = i.Value;
}

long x = 999999999999999;
i = (int)x;

Int32 y = new Int32();
y = 12;

Point point = new Point();
bool isInEurope = point.IsInEurope();


DateTime xy;

Console.WriteLine(i);

Person p = new Person("MyName");
p.Id = 4711;
p.Name= "Test";

Product product = new Product() { Name = "Product 01", Description = "Decsription 01", Age = 12 };
//product.Name = "MyProductName";

List<Cart> cart2 = new List<Cart>
{
    new Cart()
};


List<Cart> cart = new List<Cart>()
{ 
    new Cart() 
    { 
        Id = 1, 
        CartItems = new List<CartItem>() 
        { 
            new CartItem() 
            { 
                Amount = 12,
                ProductId = 4711
            } 
        } 
    },
    new Cart()
    {
        Id = 2,
        CartItems = new List<CartItem>()
        {
            new CartItem()
            {
                Amount = 8
            }
        }
    },
    new Cart()
    {
        Id = 3,
        CartItems = new List<CartItem>()
        {
            new CartItem()
            {
                Amount = 147
            }
        }
    }
};

string s = Console.ReadLine();


class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; }
}
