namespace CSharpLearn
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
            Console.WriteLine("---------------2차원 배열-----------------------");
            int[,] map = new int[5,5];
            int size = 10;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    map[j, i] = i;
                    //if (i >= j)
                    //{
                    //    Console.Write("*");
                    //}
                    //else
                    //{
                    //    Console.Write("#");
                    //}
                }
                Console.WriteLine($" ");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}

