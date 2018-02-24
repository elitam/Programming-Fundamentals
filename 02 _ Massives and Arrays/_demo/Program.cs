using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _demo
{
    class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombs[0])
                {
                    numbers[i] = 0;

                    for (int j = 1; j <= bombs[1]; j++)
                    {
                        if (i + j >= numbers.Count)
                        {
                            break;
                        }
                        numbers[i + j] = 0;
                    }

                    for (int k = 1; k <= bombs[1]; k++)
                    {
                        if (i - k < 0)
                        {
                            break;
                        }
                        numbers[i - k] = 0;
                    }

                }
            }

            Console.WriteLine(numbers.Sum());

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
