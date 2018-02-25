using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ComparationCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] thePlane = Console.ReadLine()
    .Split().Select(int.Parse).ToArray();

            int index = int.Parse(Console.ReadLine());
        
            int damage = 1;

            string command = Console.ReadLine();
            while (command != "Supernova")
            {
                string[] myArr = command.Split();
                string direction = myArr[0];
                int steps = int.Parse(myArr[1]);

                switch (direction)
                {
                    case "left":

                        for (int i = 0; i < steps; i++)
                        {
                            index--;

                            if (index < 0)
                            {
                                index = thePlane.Length - 1;
                                damage++;
                            }

                            thePlane[index] -= damage;
                        }

                        break;

                    case "right":

                        for (int i = 0; i < steps; i++)
                        {
                            index++;

                            if (index > thePlane.Length - 1)
                            {
                                index = 0;
                                damage++;
                            }

                            thePlane[index] -= damage;
                        }

                        break;

                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", thePlane));
        }
    }
}
