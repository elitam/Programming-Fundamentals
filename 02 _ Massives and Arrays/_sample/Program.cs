using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _sample
{
    class Program
    {
        public static void Main()
        {
            

        }

        private static void DeDaZnam()
        {
            var names = new List<string> { "Sasho", "Maria", "Sasho", "Gosho" };
            names.Add("Koko");
            names.Add("Ceca");
            names.Add("Dnn");

            names.Remove("Maria");
            names.RemoveAll(x => x == "Sasho");
            Console.WriteLine(string.Join("; ", names));

            var nums = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine($"nums[{i}] = {nums[i]}");
            }
        }

    }
}
