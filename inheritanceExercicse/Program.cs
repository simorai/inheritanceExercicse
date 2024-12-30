using inheritanceExercicse.Entities;
using System.Globalization;

namespace inheritanceExercicse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma lista para armazenar os funcionários
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            // Loop para coletar dados de cada funcionário
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"Emplyee #{i} data:");
                Console.Write("Outsorced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y')
                {
                    // Se for terceirizado, solicita a cobrança adicional
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge)); 
                }
                else
                {
                    // Se não for terceirizado, adiciona um funcionário regular
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            // Imprime os pagamentos de todos os funcionários
            Console.WriteLine("Payments:");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture)); 
            }
        }
    }
}
