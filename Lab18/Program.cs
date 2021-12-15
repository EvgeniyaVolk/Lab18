using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static bool Result (string check)
        {
            string String = "([{}])";
            Stack<char> stackString = new Stack<char>();
            foreach (var x in check)
            {
                int f = String.IndexOf(x);
                if (f >= 0 && f <= 2)
                    stackString.Push(x);
                    if(f>2)
                {
                    if (stackString.Count == 0 || stackString.Pop() != String[f - 3])
                        return false;
                }
            }
            if (stackString.Count != 0)
                return false;
            return true;
           
        }
        static void Main()
        {
           string check = Console.ReadLine();
           Console.WriteLine(Result(check) ? "Correct" : "Not correct");
            Console.ReadKey();
        }
        
    }

}
