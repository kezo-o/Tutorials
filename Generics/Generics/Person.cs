using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Person Create()
        {
            return new Person();
        }

        public Person Read()
        {
            return new Person();
        }
        public Person Update()
        {
            return new Person();
        }

        public bool Delete()
        {
            return true;
        }
    }
}
