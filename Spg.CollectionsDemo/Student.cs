using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CollectionsDemo
{
    public record StudentId(int Id);

    public class Student : Person
    {
        public StudentId Id { get; set; } = default!;
        public int RegistrationNumber { get; set; }

        public Student GetStudent(StudentId studentId, ClassRoomId classRoomId) 
        {
            return null;
        }
    }
}
