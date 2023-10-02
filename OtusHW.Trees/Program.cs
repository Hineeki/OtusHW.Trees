namespace OtusHW.Trees
{

    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            Console.WriteLine("Введите информацию о сотрудниках (имя и зарплата):");
            while (true)
            {
                Console.Write("Имя (или пустая строка для завершения ввода): ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    break;

                Console.Write("Зарплата: ");
                int salary = int.Parse(Console.ReadLine());

                tree.Insert(name, salary);
            }

            Console.WriteLine("Информация о сотрудниках в порядке возрастания зарплат:");
            tree.InOrderTraversal(tree.root);

            Console.Write("Введите зарплату для поиска сотрудника: ");
            int targetSalary = int.Parse(Console.ReadLine());
            string employeeName = tree.FindEmployeeBySalary(targetSalary);
            Console.WriteLine(employeeName);
        }
    }
}