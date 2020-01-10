using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_Con
{
    class Program
    {
        static void Main(string[] args)
        {
            object b = new object();
            b = 0;
            int a = (int)b; a = 100;
            char c = (char)b; c ='a';
            Console.ReadLine();
        }
    }
}
