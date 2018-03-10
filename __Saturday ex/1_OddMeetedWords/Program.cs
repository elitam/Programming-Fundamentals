using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OddMeetedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Trim().Split().Select(x => x.ToLower()).ToList();
            var dic = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dic.ContainsKey(word))
                {
                    dic[word] += 1;
                }
                else
                {
                    dic.Add(word, 1);
                }
            }

            var result = new List<string>();
            foreach (var pair in dic)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
