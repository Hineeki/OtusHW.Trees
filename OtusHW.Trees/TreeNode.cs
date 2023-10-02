using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW.Trees
{
    internal class TreeNode
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(string name, int salary)
        {
            Name = name;
            Salary = salary;
            Left = null;
            Right = null;
        }
    }
}
