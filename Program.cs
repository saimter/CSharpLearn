using System.Drawing;

namespace CSharpLearn
{

    internal class Program
    {
        static int size = 10;
        static int[,] data2 = new int[10, 10];

        static void Initialize()
        {
                
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    data2[i, j] = i * 10 + j + 1;
                }
            }
        }
        
        static void Print()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($" {data2[i, j]} \t");
                }
                Console.WriteLine($" ");
            }
        }        
        static void Main(string[] args)
        {

            void fnIni() { 
            }
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
                for (int j = 0; j < 5; j++)
                    data[i] = i + 1;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(data[i]);
            }
            String s = "Hello World!!!";


            Console.WriteLine("-------------- 2차원 배열------------------------");
            int[,] data2 = new int[10, 10];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    data2[i, j] = i * 10 + j + 1;
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($" {data2[i, j]} \t");
                }
                Console.WriteLine($" ");
            }

            Console.WriteLine("------------------static를 이용한 변수 선언 및 함수 만들기--------------------");
            Initialize();
            Print();
        }
    }
}

