using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._03zadachki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(101, "Ivan");
            students.Add(102, "Maria");
            students.Add(103, "Jivko");
            students.Add(104, "Anna");
            students.Add(105, "Iliqna");
            students.Add(106, "Martin");

            int num = int.Parse(Console.ReadLine());

            if (students.ContainsKey(num))
            {
                Console.WriteLine(students[num]);
            }
            else
            {
                Console.WriteLine("Student not found");
            }
        }
    }
}
