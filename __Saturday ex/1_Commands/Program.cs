using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            //Аppend < Символен низ >
            //Remove < pos > < number >
            //Insert < pos > < string >
            //Replace < substring > < substring >

            var sb = new StringBuilder(Console.ReadLine());
            var command = Console.ReadLine().Split().ToList();
            switch (command[0])
            {
                case "Append":
                    sb.Append(command[1]);
                    break;
                case "Remove":
                    var startIndx = int.Parse(command[1]);
                    var lenght = int.Parse(command[2]);
                    sb.Remove(startIndx, lenght);
                    break;
                case "Insert":
                    var position = int.Parse(command[1]);
                    sb.Insert(position, command[2]);
                    break;
                case "Replace":
                    sb.Replace(command[1], command[2]);
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
            Console.WriteLine(sb);
        }
    }
}
