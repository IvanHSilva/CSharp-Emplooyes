using System;
using System.Collections.Generic;
using System.Globalization;

namespace Emplooyes {
    internal class Program {
        static void Main(string[] args) {

            List<Employee> employee = new List<Employee>();
            Console.Write("Número de funcionários: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < N; i++) {
                Console.WriteLine($"Funcionário #{i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Id do funcionário: ");
            int empid = int.Parse(Console.ReadLine());
            Employee emp = employee.Find(x => x.Id == empid);
            if (emp != null) {
                Console.Write("Porcentagem do aumento: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalaray(percent);
            }
            else {
                Console.WriteLine("Id do funcionário não encontrado");
            }
            Console.WriteLine();

            Console.WriteLine("Lista dos funcionários atualizada:");
            foreach (Employee e in employee) {
                Console.WriteLine(e);
            }
        }
    }
}
