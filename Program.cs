using System.Drawing;

namespace CSharpLearn
{
    

    public class Player
    {
        public string Eat(string food)
        {
            return $"플레이어가 {food}를 먹었습니다.";
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }

    internal class Program
    {


        static int size = 10;
        static int[,] data2 = new int[10, 10];

        static int Plus(int Number,int Number2)
        {
            return Number + Number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

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
            int num1 = 7;
            int num2 = 6;
            Console.WriteLine($"곱하기 결과 {num1} * {num2} = {Multiply(num1, num2)}");

            Player player = new Player();

            //Console.WriteLine("클래스를 이용한 곱셈 : {player.Multiply(3, 4)}");
            Console.WriteLine($"클래스 곱하기 결과 {num1} * {num2} = {player.Multiply(num1, num2)}");
            Console.WriteLine(player.Eat("사과"));
            Console.WriteLine($"{Plus(2,3)}");
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

