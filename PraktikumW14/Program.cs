using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
namespace PraktikumW14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int row = input;
            int column = input;
            int counter = 0;
            Console.WriteLine("Output :");
            int[,] prima = new int[row, column];

            for (int i = 2; i <= 100; i++)
            {
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    Console.Write(i + " ");
                }
            
                
            }
        }

    }

}







