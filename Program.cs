﻿using Microsoft.VisualBasic;
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
    //  1 ~ 13      하트
    //  14 ~ 26     다이아
    //  27 ~ 39     클로버
    //  40 ~ 52     스페이드
    internal class Program
    {

        static void Initialize(int[] deck)
        {
            //unsafe
            //{
            //    TypedReference tr1 = __makeref(deck);
            //    IntPtr ptr1 = **(IntPtr**)(&tr1);
            //    Console.WriteLine(ptr1);
            //}

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = i + 1;
            }
        }

        static void Shuffle(int[] deck)
        {
            Random random = new Random();

            for (int i = 0; i < deck.Length * 10; ++i)
            {
                int firstCardIndex = random.Next(0, deck.Length);
                int secondCardIndex = random.Next(0, deck.Length);

                int temp = deck[firstCardIndex];
                deck[firstCardIndex] = deck[secondCardIndex];
                deck[secondCardIndex] = temp;
            }
        }

        enum CardType
        {
            None = -1,
            Heart = 0,
            Diamond = 1,
            Clover = 2,
            Spade = 3,
        }

        static int GetScore(int cardNumber)
        {
            int value = (((cardNumber - 1) % 13) + 1);
            return value > 10 ? 10 : value;
        }

        static void PrintCardList(int[] deck)
        {
            //Computer
            Console.WriteLine("Computer");
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine($"{CheckCardType(deck[i]).ToString()} {CheckCardName(deck[i])}");
            }
            Console.WriteLine("-------------");

            Console.WriteLine("Player");
            for (int i = 3; i < 6; ++i)
            {
                Console.WriteLine($"{CheckCardType(deck[i]).ToString()} {CheckCardName(deck[i])}");
            }
            Console.WriteLine("-------------");
        }

        static void Print(int[] deck)
        {
            PrintCardList(deck);

            int computerScore = GetScore(deck[0]) +
                GetScore(deck[1]) + GetScore(deck[2]);
            int playerScore = GetScore(deck[3]) + GetScore(deck[4])
                + GetScore(deck[5]);

            Console.WriteLine($"Computer score : {computerScore}, Player Score : {playerScore}");

            if (playerScore >= 21 && computerScore < 21)
            {
                //Computer Win
                Console.WriteLine("Computer Win");
            }
            else if (playerScore < 21 && computerScore >= 21)
            {
                //Player Win
                Console.WriteLine("Player Win");
            }
            else if (playerScore >= 21 && computerScore >= 21)
            {
                //Player Win
                Console.WriteLine("Player Win");
            }
            else if (computerScore <= playerScore)
            {
                //Player Win
                Console.WriteLine("Player Win");
            }
            else // (computerScore > playerScore)
            {
                //Computer Win
                Console.WriteLine("Computer Win");
            }
        }

        static CardType CheckCardType(int cardNumber)
        {
            int valueType = (cardNumber - 1) / 13;

            //CardType returnCardType = (CardType)valueType;
            //switch((CardType)valueType)
            //{
            //    case CardType.Heart:
            //        returnCardType = CardType.Heart;
            //        break;
            //    case CardType.Diamond:
            //        returnCardType = CardType.Diamond;
            //        break;
            //    case CardType.Spade:
            //        returnCardType = CardType.Spade;
            //        break;
            //    case CardType.Clover:
            //        returnCardType = CardType.Clover;
            //        break;
            //    default:
            //        returnCardType = CardType.None;
            //        break;
            //}

            return (CardType)valueType;
        }

        static string CheckCardName(int cardNumber)
        {

            //1 - 13
            int cardValue = ((cardNumber - 1) % 13) + 1;
            string cardName;
            switch (cardValue)
            {
                case 1:
                    cardName = "A";
                    break;
                case 11:
                    cardName = "J";
                    break;
                case 12:
                    cardName = "Q";
                    break;
                case 13:
                    cardName = "K";
                    break;
                default:
                    cardName = cardValue.ToString();
                    break;
            }

            return cardName;
        }



        #region 자작
        static void CardMakeTypecast(int __num)
        {
            int cardSort = -1;
            int cardInd = -1;
            cardSort = (int)((__num - 1) / 13);
            cardInd = (__num - 1) % 13;

            string cardSortResult = "";
            string cardNumResult = "";

            switch (cardSort)
            {
                case 0:
                    cardSortResult = "♥";
                    break;
                case 1:
                    cardSortResult = "◆";
                    break;
                case 2:
                    cardSortResult = "♣";
                    break;
                case 3:
                    cardSortResult = "♠";
                    break;
            }
            switch (cardInd)
            {
                case 0:
                    cardNumResult = "A";
                    break;
                case 10:
                    cardNumResult = "J";
                    break;
                case 11:
                    cardNumResult = "Q";
                    break;
                case 12:
                    cardNumResult = "K";
                    break;
                default:
                    cardNumResult = (cardInd + 1).ToString();
                    break;
            }
            Console.WriteLine($"{__num} : {cardSortResult} {cardNumResult}");
        }
        static void CardMake()
        {
            int size = 52;
            int cntNum = 8;
            int cntResultNum = 0;

            int[] arrLottery = new int[size];
            int[] arrResult = new int[cntNum];
            string[] arrResultS = new string[cntNum];


            for (int i = 0; i < size; i++)
            {
                arrLottery[i] = i + 1;
            }
            Random rand = new Random();

            while (cntNum > cntResultNum)
            {
                bool isExists = false;

                int sizeArr = arrLottery.Length;
                int rd = rand.Next(1, sizeArr);

                for (int i = 0; i < cntResultNum; i++)
                {
                    if (rd == arrResult[i])
                    {
                        isExists = true;
                    }
                }
                if (!isExists)
                {
                    arrResult[cntResultNum] = rd;
                    cntResultNum++;
                }
            }
            fnMsg("01 ~ 13     하트");
            fnMsg("14 ~ 26     다이아");
            fnMsg("27 ~ 39     클로버");
            fnMsg("40 ~ 52     스페이드");
            fnMsg("----------------------------");

            for (int i = 0; i < arrResult.Length; ++i)
            {
                //Console.Write(arrResult[i].ToString() + ",");
                CardMakeTypecast(arrResult[i]);
            }
        }
        #endregion

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


        public class CPixcel
        {

            public int x;
            public int y;
            public int R;
            public int G;
            public int B;
            public CPixcel()
            {
                Console.WriteLine("생성자");
            }
            ~CPixcel()
            {
                Console.WriteLine("소멸자");
            }
        } 

        static void Main(string[] args)
        {
            CPixcel[] arrCPixcels = new CPixcel[2];

            CPixcel CPixcel = new CPixcel();
            CPixcel.x = 0;
            CPixcel.y = 1;
            CPixcel.R = 165;
            CPixcel.G = 55;
            CPixcel.B = 128;
            Console.WriteLine(CPixcel.R.ToString());

            CPixcel CPixcel2 = new CPixcel();
            CPixcel2.x = 0;
            CPixcel2.y = 1;
            CPixcel2.R = 265;
            CPixcel2.G = 155;
            CPixcel2.B = 228;
            Console.WriteLine(CPixcel2.R.ToString());


            //int[] deck = new int[52];
            //Initialize(deck);
            //Shuffle(deck);
            //PrintCard();

            //CardMake();


            //while (IsRunning)
            //{
            //    Input();
            //    Update();
            //    Render();
            //}

            //Console.Clear();
            //Console.WriteLine("Game over");

            //#region 일반 함수
            //int num1 = 7;
            //int num2 = 6;
            //Console.WriteLine($"곱하기 결과 {num1} * {num2} = {Multiply(num1, num2)}");

            //Player player = new Player();

            ////Console.WriteLine("클래스를 이용한 곱셈 : {player.Multiply(3, 4)}");
            //Console.WriteLine($"클래스 곱하기 결과 {num1} * {num2} = {player.Multiply(num1, num2)}");
            //Console.WriteLine(player.Eat("사과"));
            //Console.WriteLine($"{Plus(2,3)}");
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Git Test");
            //Console.WriteLine("캠프에서 추가");

            //Console.WriteLine("------------------별 그리기--------------------");
            //for (int i = 0; i < 5; i++) 
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("--------------------별과 샾 그리기------------------");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if( i >= j) {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write("#");
            //        }
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("--------------------별과 샾 그리기------------------");
            //int size = 10;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = size; j >= 0; j--)
            //    {
            //        if (i >= j)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine("");
            //}
            //Console.WriteLine("---------------배열-----------------------");
            //size = 10;
            //int[] data = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //        data[i] = i + 1;
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(data[i]);
            //}
            //string s = "Hello World!!!";


            //Console.WriteLine("-------------- 2차원 배열------------------------");
            //int[,] data2 = new int[10, 10];
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        data2[i, j] = i * 10 + j + 1;
            //    }
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write($" {data2[i, j]} \t");
            //    }
            //    Console.WriteLine($" ");
            //}

            //Console.WriteLine("------------------static를 이용한 변수 선언 및 함수 만들기--------------------");
            //Initialize();
            //Print();
            //#endregion
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

        static void fnMsg(string __msg)
        {
            Console.WriteLine(__msg);
        }
    }
}

