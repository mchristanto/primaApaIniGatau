using System;

namespace PraktikumW14
{
    class Program
    {
        static void prima(int input)
        {
            int counter = 0;
            int angkaBerjalan = 0;
            int apaprima = 0;
            for (int i = 0; i < input; i++)
            {
                for(int j = 0; j < input; j++)
                {
                    apaprima = 0;
                    while (apaprima == 0)
                    {
                        angkaBerjalan++;
                        counter = 0;
                        for (int k = 1; k <= angkaBerjalan; k++)
                        {
                            if (angkaBerjalan % k == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == 2)
                        {
                            apaprima = 1;
                        }
                        else
                        {
                            apaprima = 0;
                        }
                    }
                    Console.Write($"{angkaBerjalan}".PadLeft(5));
                }
                Console.WriteLine();
            }
        }
        static void nonPrima(int input)
        {
            int counter = 0;
            int angkaBerjalan = 0;
            int apaprima = 0;
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    apaprima = 0;
                    while (apaprima == 0)
                    {
                        angkaBerjalan++;
                        counter = 0;
                        for (int k = 1; k <= angkaBerjalan; k++)
                        {
                            if (angkaBerjalan % k == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == 2)
                        {
                            apaprima = 0;
                        }
                        else
                        {
                            apaprima = 1;
                        }
                    }
                    Console.Write($"{angkaBerjalan}".PadLeft(5));
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //gatau ko bingung
            Console.Write("Input : ");
            int input = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            Console.WriteLine("Output :");
            if (input < 2)
            {
                Console.WriteLine("");
            }
            else
            {
                for (int i = 1; i <= input; i++)
                {
                    if (input % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    prima(input);
                    Console.WriteLine();
                }
                else
                {
                    nonPrima(input);
                }
            }
           /* for (int i = 2; i <= 100; i++)
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
            }*/
        }

    }

}







