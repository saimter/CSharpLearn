﻿namespace CSharpLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Git Test");
            Console.WriteLine("캠프에서 추가");

            Console.WriteLine("------------------별 그리기--------------------");
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("--------------------별과 샾 그리기------------------");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if( i >= j) {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("--------------------별과 샾 그리기------------------");
            int size = 10;
            for (int i = 0; i < size; i++)
            {
                for (int j = size; j >= 0; j--)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("---------------배열-----------------------");
            size = 10;
            int[] data = new int[size];

            for (int i = 0; i < size; i++)
            {
                data[i] = i + 1;
            }
            for (int i = 0; i < size; i++) {
                Console.WriteLine(data[i]);
            }

            String s = "Hello World!!!";

            int[,] data2 = new int[10,10];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    data2[i, j] = i * 10 + j + 1;
                }
            }
            Console.WriteLine("-------------- 2차원 배열------------------------");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($" {data2[i,j]} \t");
                }
                Console.WriteLine($" ");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}

