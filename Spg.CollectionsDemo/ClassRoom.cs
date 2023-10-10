using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CollectionsDemo
{
    /// <summary>
    /// 0677/123456789
    /// </summary>
    /// <param name="number"></param>
    public record PhonNumber(string Number)
    {
        public int Prefix()
        {
            return 677;
        }

        public int PhoneNumber()
        {
            return 12345789;
        }
    }

    public record ClassRoom(string Number);

    //public class ClassRoom// : IEquatable<ClassRoom>
    //{
    //    public ClassRoom(string number)
    //    {
    //        Number = number;
    //    }
    //    public string Number { get; init; } = string.Empty;

    //    public override bool Equals(object? obj)
    //    {
    //        return Equals(obj as ClassRoom);
    //    }

    //    public bool Equals(ClassRoom? other)
    //    {
    //        return Number == other?.Number;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return base.GetHashCode();
    //    }

    //    public override string? ToString()
    //    {
    //        return base.ToString();
    //    }
    //    public List<Student> Students { get; set; } = new();
    //}
}
