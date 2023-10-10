using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.TypesDemo.DoaminModel.Model
{
    public class Product
    {
        public Product()
        {
            this.Name = "Ein Default Produkt";
        }

        public Product(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }

        public string NameDescription 
            => $"{Name} - {Description}";
        //...

        private int myVar;

        public int Age
        {
            get { return myVar; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Du darfst nicht jünger als 0 sein.");
                }
                myVar = value;
            }
        }


        public void SetWhatever(string whatever)
        {
            this.Name = "InternalSet";
            // TODO: Implementation
        }

        public string GetDescription() 
            => Description;
    }
}
