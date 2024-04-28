using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo.Customer
{
    public class Customer
    {
        public int Id;
        public string Name;
        public void Introduce()
        {
            Console.WriteLine("My name is " + Name);
        }
    }
}
