using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Model
{
    public class Employee : Person
    {
        private Employee()
        { }
        public Employee(Guid guid, Genders gender, string firstName, string lastName, PhoneNumber phoneNumber, EMail eMail,
            decimal income, int level, Employee chief)
            : base(guid, gender, firstName, lastName, phoneNumber, eMail)
        {
            Income = income;
            Level = level;
            Chief = chief;
        }

        public decimal Income { get; set; }
        public int Level { get; set; }
        public Employee Chief { get; set; } = default!;
    }
}
