using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Animal
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Animal Create()
        {
            return new Animal();
        }

        public Animal Read()
        {
            return new Animal();
        }
        public Animal Update()
        {
            return new Animal();
        }

        public bool Delete()
        {
            return true;
        }
    }
}
