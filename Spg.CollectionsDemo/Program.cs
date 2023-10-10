using Spg.CollectionsDemo;

//List<ClassRoom> classRooms = new List<ClassRoom>()
//{
//    new ClassRoom()
//    {
//        Number="C1.07",
//        Students = new List<Student>()
//        {
//            new Student() { FirstName="Martin", LastName="Schrutek" }
//        }
//    },
//    new ClassRoom()
//    {
//        Number="C4.08",
//        Students = new List<Student>()
//        {
//            new Student() { FirstName="Herbert", LastName="Hofer" },
//            new Student() { FirstName="Huber", LastName="Göisern" },
//            new Student() { FirstName="Anna", LastName="Theke" },
//        }
//    },
//    new ClassRoom()
//    {
//        Number="C3.08",
//        Students = new List<Student>()
//        {
//            new Student() { FirstName="Susanne", LastName="Mayer" },
//            new Student() { FirstName="Max", LastName="Reinsch" },
//        }
//    },
//    new ClassRoom()
//    {
//        Number="C4.11",
//        Students = new List<Student>()
//        {
//            new Student() { FirstName="Daniel", LastName="Moroz" }
//        }
//    },
//    new ClassRoom()
//    {
//        Number="C5.03",
//        Students = new List<Student>()
//        {
//            new Student() { FirstName="Max", LastName="Müller" }
//        }
//    }
//};

// Output:

//foreach (ClassRoom classRoom in classRooms)
//{
//    Console.WriteLine($"{classRoom.Number}");
//    foreach (Student student in classRoom.Students)
//    {
//        Console.WriteLine($"  {student.FirstName} {student.LastName}");
//    }
//}

//ClassRoom x = new ClassRoom() { Number = "C4.08", };

ClassRoom c1 = new ClassRoom("C1.07") { Number = "C1.01" };
//c1.Number = "C1.01";

MyList classRooms2 = new MyList()
{
    new ClassRoom("C1.07"),
    new ClassRoom("C4.08"),
    new ClassRoom("C3.08"),
    new ClassRoom("C4.11"),
    new ClassRoom("C5.03")
};

classRooms2.Remove(new ClassRoom("C4.08"));

ClassRoom secondClassroom = classRooms2["C3.08"] 
    ?? throw new ArgumentNullException("Classroom ist NULL, soll aber nicht!");

foreach (ClassRoom classRoom in classRooms2)
{
    Console.WriteLine($"{classRoom.Number}");
}
Console.WriteLine("----------------------");
Console.WriteLine($"{secondClassroom.Number}");