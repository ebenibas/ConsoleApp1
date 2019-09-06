using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // string str = "food is a very good stuff";
            //string reversedString = new string(str.Reverse().ToArray());
            //Console.WriteLine(reversedString);
            //Console.ReadLine();
            string x = "this is my name";
            string reverse = string.Empty;
            foreach (char str in x)
            {
                reverse = str + reverse;
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }

}

