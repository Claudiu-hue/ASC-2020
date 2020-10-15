using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moore_s_law
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, j;
            i = 1;
            j = 1;
            n = Convert.ToInt32(Console.ReadLine()); //puterea de calcul introdusa
            while(i<n) 
            {
                i = i * 2; //puterea de calcul pe care o dublez
                j = j + 2; //timpul parcurs

            }
            Console.WriteLine(j);
        }
    }
}
