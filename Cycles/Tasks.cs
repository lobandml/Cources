using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cycles
{
    class Tasks
    {

        private static int IntParseInput(string message)
        {
            int result;
            do
            {
                Console.WriteLine(message);
            }
            while (!Int32.TryParse(Console.ReadLine(), out result));
            return result;
        }

        private static double DoubleParseInput(string message)
        {
            double result;
            do
            {
                Console.WriteLine(message);
            }
            while (!Double.TryParse(Console.ReadLine(), out result));
            return result;
        }

        public static void Task1()
        {

            int user_input = IntParseInput("введите число:");

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(user_input.ToString() + " * " + i.ToString() + " = " + (user_input * i).ToString());
            }


        }
        public static void Task2()
        {
            int user_input = IntParseInput("введите число:");
            int count = 1;

            while ((user_input / Convert.ToInt32(Math.Pow(10, count))) != 0)
            {
                
                count++;
            }
            Console.WriteLine((count).ToString() + " разрядов");
        }
        public static void Task3()
        {
            Random rand=new Random();
            int number=rand.Next(1,146);

            int k=-1;
            //k = int.Parse(Console.ReadLine());
            while (k != number)
            {
                k = IntParseInput("введите корректное число:");
                if (k < number)
                {
                    Console.WriteLine("больше");
                }
                else if (k > number)
                {
                    Console.WriteLine("меньше");
                }
            }
                Console.WriteLine("Угадал!");


        }
        public static void Task4()
        {
            int user_input = IntParseInput("введите число:");
            int i = 1;
            while (Math.Pow(i, 2) < user_input)
            {
                Console.WriteLine(Math.Pow(i, 2));
                i++;
            }

        }
        public static void Task5()
        {
            int[] numbers=new int[5];
            double ar=0;

            for (int i=0;i<5;i++)
            {
                numbers[i] =  IntParseInput("введите " +(i+1).ToString()+" число:");
                ar += Convert.ToDouble(numbers[i]) / 5.0;
            }
            Console.WriteLine(ar);


        }
        public static void Task6()
        {
            int[] numbers = new int[5];
            Random rand = new Random();
            double ar = 0;

            for (int i = 0; i < 5; i++)
            {
                ar += Convert.ToDouble(rand.Next(int.MaxValue,int.MaxValue)) / 5.0;
            }
            Console.WriteLine(ar);


        }
        public static void Task7()
        {
            for (int i = 0; i < 17; i++)
            {
                Console.WriteLine(i.ToString() + " кроликов и " + (64 - 4 * i).ToString() + " гусей");
            }
        }
        public static void Task8()
        {
            string pass = "root";
            Console.WriteLine("Введите пароль:");
            while (Console.ReadLine() != pass)
            {
                Console.WriteLine("Неверный пароль! \nВведите ещё раз:");
            }
            Console.WriteLine("Пароль принят");


        }

    }
}
