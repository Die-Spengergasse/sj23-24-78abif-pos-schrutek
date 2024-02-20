# Unterricht 78ACIF

x

## Projekt

Beschreibung

### Teammitglieder

* A
* B

### Zweck

Beschreibung

### Aufbau

xxxxx

#### Domain Model

```html
<h1>Hello World!</h1>
```

```plantuml

@startuml

abstract class Person {
    Id: int
    Gender: Genders
    FirstName: string
    LastName: string
    EMail: EMail
    Username: string
    Password: string
    Address: Address
    PhoneNumber: PhoneNumber
}

entity Customer {
    RegistrationDateTime: DateTime
}

entity Employee {
    Income: decimal
    Level: int
    Chief: Employee
}

entity Shop {
    Id: int
    Name: string
    Address: Address
    PhoneNumber: PhoneNumber
    EMail: EMail
}

entity Category {
    Id: int
    Name: string
}

entity Product {
    Id: int
    Name: string
    Description: string
    ExpiryDate: DateOnly
    CategoryNavigation: Category
}

entity ShoppingCart {
    Id: int
    CreationDateTime: DateTime
    PersonNavigation: Person
    Status: ShoppingCartStates
}

entity ShoppingCartProduct << Zwischentabelle >> {
    Id: int
    BuyingDateTime: DateTime
    Pieces: int
    Product: Product
    ShoppingCartNavigation: ShoppingCart
    CreationDateTime: DateTime
}

entity Address << (V,#FF7700) Embeddable >> {
    Street: string
    HouseNumber: string
    Zip: string
    Country: string
}

entity PhoneNumber << (V,#FF7700) Embeddable >> {
    Prefix: string
    Number: string
}

entity EMail << (V,#FF7700) Embeddable >> {
    Address: string
}

enum ShoppingCartStates {
    Active
    Payed
    Sent
    Delivered
}

enum Genders {
    Male
    Female
    Other
}

Shop o-- Category
Shop -- Address
Shop .up. PhoneNumber
Customer -- Address
Customer -- PhoneNumber
Category "0..1" o-- "0..n" Product
Person "1" o-- "1..n" ShoppingCart : ownes <
ShoppingCart "1" o-- "0..n" ShoppingCartProduct
ShoppingCartProduct "0..n" --o "1" Product
Shop -- EMail
Customer -- EMail
ShoppingCart .. ShoppingCartStates
Person .. Genders
Customer --|> Person
Employee --|> Person
Employee -- Employee


@enduml

```

#### C# Example

```C#
<h1>asddsadsadas</h1>

namespace Spg.CollectionsDemo
{
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
    }
}

```

xxxxxx