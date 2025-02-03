using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        static int Plus(int Number, int Number2)
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


        #region  로그라이크류 게임 변수

        static char wall = '*';
        static char floor = ' ';
        static int playerX = 1;
        static int playerY = 1;

        static int[,] map =               {
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 4, 0, 1 },
                    { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                    { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
            };
        static ConsoleKeyInfo keyInfo;

        static bool IsRunning = true;
        #endregion

        static void Main(string[] args)
        {

            while (IsRunning)
            {
                Input();
                Update();
                Render();
            }

            Console.Clear();
            Console.WriteLine("Game over");

            #region 일반 함수
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
            string s = "Hello World!!!";


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
            #endregion
        }

        private static void Render()
        {
            Console.Clear();

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        Console.Write('P');
                    }
                    else if (map[y, x] == 1)
                    {
                        Console.Write(wall);
                    }
                    else if (map[y, x] == 0)
                    {
                        Console.Write(floor);
                    }
                    else if (map[y, x] == 4)
                    {
                        Console.Write('M');
                    }
                }
                Console.Write('\n');
            }
        }

        private static void Update()
        {
            if (keyInfo.Key == ConsoleKey.W)
            {
                playerY--;
            }
            else if (keyInfo.Key == ConsoleKey.S)
            {
                playerY++;
            }
            else if (keyInfo.Key == ConsoleKey.A)
            {
                playerX--;
            }
            else if (keyInfo.Key == ConsoleKey.D)
            {
                playerX++;
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                IsRunning = false;
            }
        }

        private static void Input()
        {
            keyInfo = Console.ReadKey();
        }


    }
}

