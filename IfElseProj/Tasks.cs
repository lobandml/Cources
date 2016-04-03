using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfElseProj
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
            int first = IntParseInput("Введите первое значение");
            int second = IntParseInput("Введите второе значение");
            Console.WriteLine(first > second ? first.ToString() : second.ToString());
        }

       public static void Task2()
        {
            string res = Console.ReadLine().ToLower();
            switch (res)
            {
                case "мяу":
                    Console.WriteLine("Покорми кота");
                    break;
                case "гав":
                    Console.WriteLine("Погуляй с собакой");
                    break;
                default:
                    Console.WriteLine("Что это за звук?");
                    break;
            }
        }

        public static void Task3()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                case "2":
                case "12":
                    Console.WriteLine("Зима");
                    break;
                case "3":
                case "4":
                case "5":
                    Console.WriteLine("Весна");
                    break;
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("Лето");
                    break;
                case "9":
                case "10":
                case "11":
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("На этой планете такого месяца нет");
                    break;
            }

        }
        public static void Task4()
        {
            string res = ((Convert.ToInt32(Console.ReadLine())) == 1) ? "Хорошо" : "Плохо";
            Console.WriteLine(res);

            // или совсем в одну строку всё
            //Console.WriteLine( (( Convert.ToInt32(Console.ReadLine()))==1) ? "Хорошо" : "Плохо");
        }
        public static void Task5()
        {
            string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            int x = IntParseInput("Введите номер дня недели ");
            if (x >= 1 && x <= 7)
            {
                Console.WriteLine(days[x - 1]);
            }
            else Console.WriteLine("некорректный номер дня недели");
            
        }
        public static void Task6()
        {
            
            int kms = IntParseInput("Кол-во километров:");
            
            int mins = IntParseInput("Кол-во минут простоя:");

            if (kms <= 5)
            {
                mins += 20;
            }
            else
            {
                mins += 20;
                mins += (kms - 5) * 3;
            }
            Console.WriteLine(mins);

        }
        public static void Task7()
        {
            bool prost = true;

            
            int n = IntParseInput("Введите число");

            for (int i = 2; i <= Math.Sqrt(n) + 1; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            if (prost)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            

        }
        public static void Task8()
        {
            
            int n = IntParseInput("Введите число");

            Random rnd = new Random();
            int ch = rnd.Next(1, 12);
            if (ch <= 5)
            {
                n = 0;
            }
            else
            {
                switch (ch)
                {
                    case 6:
                    case 7:
                    case 8:
                        // Ничего не нужно менять
                        break;
                    case 9:
                    case 10:
                    case 11:
                        n *= 2;
                        break;

                    case 12:
                        n *= 10;
                        break;
                    default:
                        throw new IndexOutOfRangeException("Выход за пределы допустимых значений");
                        break;
                }
            }

            Console.WriteLine("Ваш банк составляет " + n.ToString());

        }
        public static void Task9()
        {

            double[] valmatrix = { 26.4623, 29.3308 };
            
            int sum = IntParseInput("Введите сумму");

            Console.WriteLine("Введите валюту (UAH, USD, EUR):");
            string buf = Console.ReadLine().ToUpper();
            switch (buf)
            {
                case "UAH":
                    Console.WriteLine("USD = " + (sum * valmatrix[0]).ToString());
                    Console.WriteLine("EUR = " + (sum * valmatrix[1]).ToString());
                    break;
                case "USD":
                    Console.WriteLine("UAH = " + (sum / valmatrix[0]).ToString());
                    Console.WriteLine("EUR = " + (sum / valmatrix[0] * valmatrix[1]).ToString());
                    break;
                case "EUR":
                    Console.WriteLine("UAH= " + (sum / valmatrix[1]).ToString());
                    Console.WriteLine("USD = " + (sum / valmatrix[1] * valmatrix[0]).ToString());
                    break;
                default:

                    break;

            }


        }
    }
}
