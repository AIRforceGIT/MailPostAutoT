using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepikTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string kill = null;
            int count = 1;
            input = Console.ReadLine();
            for(int i = 0; i < input.Length - 1; i++)
            {
                if (input[i].Equals(input[i + 1]))
                {
                    count += 1;
                }
                else
                {
                    if (count != 1)
                    {
                        kill += count;
                        kill += input[i];
                        count = 1;
                    }
                    else
                        kill += input[i];
                }
            }
            kill += count;
            kill += input[input.Length-1];
            Console.WriteLine(kill);
            Console.ReadKey();
        }
    }
}
