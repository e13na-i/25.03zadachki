using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> wordFrequency = new Dictionary<string, int>();

            string[] words = input.Split();

            foreach (string word in words)
            {
                if (wordFrequency.ContainsKey(word))
                {
                    wordFrequency[word]++;
                }
                else
                {
                    wordFrequency[word] = 1;
                }
            }

            Console.WriteLine("\nЧестота на думите:");
            foreach (var pair in wordFrequency)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
