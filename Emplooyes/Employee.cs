using System.Globalization;

namespace Emplooyes {
    public class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalaray(double percent) {
            Salary += Salary * (percent / 100);
        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
