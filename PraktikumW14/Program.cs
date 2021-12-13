using System;

namespace PraktikumW14
{
    class Program
    {
        static void prima()
        {
            for (int i = 2; i <= 100; i++)
            {
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        Console.Write(i + 1 + " ");
                    }
                }
                if (prime)
                {
                    Console.Write(i + " ");
                }
            }
        }
        static void Main(string[] args)
        {
            //gatau ko bingung
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int row = input;
            int column = input;
            int counter = 0;
            Console.WriteLine("Output :");
            prima();
        }

    }

}







