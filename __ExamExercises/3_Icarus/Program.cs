using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Icarus
{
    class Program
    {
        private static int damage = 1;

        static void Main(string[] args)
        {
            var plane = Console.ReadLine().Trim().Split().Select(int.Parse).ToList();
            var position = int.Parse(Console.ReadLine()) ;

            var isSupernova = false;
            while (!isSupernova)
            {
                var command = Console.ReadLine().Split().ToList();
                if (command[0] == "Supernova")
                {
                    break;
                }
                var direction = command[0];

                var steps = int.Parse(command[1]);

                switch (direction)
                {
                    case "right":
                        position = StepToRight(plane, position, steps);
                        break;
                    case "left": 
                        position = StepToLeft(plane, position, steps);
                        break;
                    default:
                        Console.WriteLine("bye bye");
                        break;
                }
                 //Console.WriteLine(string.Join(" ", plane));
            }
            Console.WriteLine(string.Join(" ", plane));
        }

        private static int StepToLeft(List<int> plane, int position, int steps)
        {
    

            for (int i = 0; i < steps; i++)
            {
                position--;
                if (position < 0)
                {
                    position = plane.Count - 1;
                    damage++;
                }
                plane[position] -= damage;
            }

            return position;
        }

        private static int StepToRight(List<int> plane, int position, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                position++;
                if (position > plane.Count - 1)
                {
                    position = 0;
                    damage++;
                }
                plane[position] -= damage;

            }

            return position;
        }
    }
}
