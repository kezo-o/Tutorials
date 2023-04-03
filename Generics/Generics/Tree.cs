using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    
    public class Tree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public Tree Create()
        {
            return new Tree();
        }
              
        public Tree Read()
        {
            return new Tree();
        }
        public Tree Update()
        {
            return new Tree();
        }

        public bool Delete()
        {
            return true;
        }
    }
}
