using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice.Reflection
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;

        }
        public Customer()
        {
            Id = -1;
            Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("Id {0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name {0}", this.Name);

        }
    }
}
