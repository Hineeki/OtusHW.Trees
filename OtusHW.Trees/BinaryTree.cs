using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHW.Trees
{
    internal class BinaryTree
    {
        public TreeNode root;

        public void Insert(string name, int salary)
        {
            root = InsertRec(root, name, salary);
        }

        private TreeNode InsertRec(TreeNode root, string name, int salary)
        {
            if (root == null)
            {
                root = new TreeNode(name, salary);
                return root;
            }

            if (salary < root.Salary)
            {
                root.Left = InsertRec(root.Left, name, salary);
            }
            else if (salary >= root.Salary)
            {
                root.Right = InsertRec(root.Right, name, salary);
            }

            return root;
        }

        public void InOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine($"{node.Name} - {node.Salary}");
                InOrderTraversal(node.Right);
            }
        }
        public string FindEmployeeBySalary(int targetSalary)
        {
            return FindEmployeeBySalaryRec(root, targetSalary);
        }

        private string FindEmployeeBySalaryRec(TreeNode node, int targetSalary)
        {
            if (node == null)
            {
                return "Такой сотрудник не найден";
            }

            if (targetSalary == node.Salary)
            {
                return node.Name;
            }

            if (targetSalary < node.Salary)
            {
                return FindEmployeeBySalaryRec(node.Left, targetSalary);
            }
            else
            {
                return FindEmployeeBySalaryRec(node.Right, targetSalary);
            }
        }
    }
}
