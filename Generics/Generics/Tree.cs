using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{

    public class Tree
    {
        public static List<Tree> Trees;

        //public int Id { init; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public Tree()
        {
            if (Trees is null)
                Trees = new List<Tree>();
        }

        public Tree Create(int id, string name, string location)
        {
            var tree = new Tree()
            {
                Id = id,
                Name = name,
                Location = location
            };
            Trees.Add(tree);
            return tree;
        }

        public Tree Read(int id)
        {
            return Trees.FirstOrDefault(t => t.Id == id);
        }
        public Tree Update(Tree tree)
        {
            var updatedTree = Trees.FirstOrDefault(t => t.Id == tree.Id);
            updatedTree.Name = tree.Name;
            updatedTree.Location = tree.Location;
            return updatedTree;
        }

        public bool Delete(int id)
        {
            var deletedTree = Trees.FirstOrDefault(t => t.Id == id);
            if (deletedTree is null)
                return false;
            Trees.Remove(deletedTree);
            return true;
        }

        public string ToString(Tree tree)
        {
            return $"{tree.Id} {tree.Name} {tree.Location}";
        }

        public string DisplayAll()
        {
            StringBuilder output = new StringBuilder();
            foreach (var tree in Trees)
            {
                output.AppendLine(ToString(tree));
            }
            return output.ToString();
        }
    }
}
