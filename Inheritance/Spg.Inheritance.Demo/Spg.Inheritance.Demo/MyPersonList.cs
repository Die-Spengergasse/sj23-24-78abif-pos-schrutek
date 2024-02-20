using Spg.Inheritance.Demo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.Inheritance.Demo
{
    public class MyPersonList : List<Person>
    {
        public new void Add(Person p)
        {
            // TODO: Diverse Checks
            if (p.FirstName != "Anna")
            {
                base.Add(p);
            }
        }
    }
}
