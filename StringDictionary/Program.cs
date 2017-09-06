using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var newWord = "Hello World";
            //var sd = new Dictionary<int, char>();
            var cn = new List<ChatAndNumber>();
            var sequance = 1;

            foreach (var item in newWord)
            {
                sequance = 1;
                foreach (var item2 in cn)
                {
                    if (item2.ch == item)
                    {
                        item2.no += 1;
                        sequance = item2.no;
                        break;

                    }

                }

                cn.Add(new ChatAndNumber() { no = sequance, ch = item });

            }

            for (int i = 0; i < cn.Count; i++)
            {
                Console.WriteLine(cn[i].no + " and " + cn[i].ch);
            }

            Console.Read();

        }
    }
}
