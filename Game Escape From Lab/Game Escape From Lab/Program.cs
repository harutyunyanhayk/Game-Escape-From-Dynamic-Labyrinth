using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Escape_From_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Labirinth lb = new Labirinth(LabirinthSize.Small);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(String.Join(", ", lb.DrowLabirinth()));
                Console.WriteLine();
            }
        }
    }
}
