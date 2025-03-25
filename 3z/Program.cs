using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> employees = new SortedDictionary<int, string>();

            employees.Add(103, "Peter");
            employees.Add(112, "Maria");
            employees.Add(102, "Ivan");
            employees.Add(109, "Jivko");
            employees.Add(115, "Iliqna");
            employees.Add(104, "Maksim");
            employees.Add(107, "Daniel");

            foreach (var pair in employees)
            {
                Console.WriteLine($"Номер: {pair.Key}, Име: {pair.Value}");
            }
        }
    }
}
