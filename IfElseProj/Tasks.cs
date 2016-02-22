using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfElseProj
{
    class Tasks
    {
        public static void Task1()
        {
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
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
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 1 && x <= 7)
            {
                Console.WriteLine(days[x - 1]);
            }
        }
        public static void Task6()
        {
            Console.WriteLine("Кол-во километров:");
            int kms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кол-во минут простоя:");
            int mins = Convert.ToInt32(Console.ReadLine());

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

            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());

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
            Console.WriteLine("Введите число");
            int n = int.Parse(Console.ReadLine());

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

                        break;
                    case 9:
                    case 10:
                    case 11:
                        n *= 2;
                        break;

                    case 12:
                        n *= 10;
                        break;

                }
            }

            Console.WriteLine("Ваш банк составляет " + n.ToString());

        }
        public static void Task9()
        {

            double[] valmatrix = { 26.4623, 29.3308 };
            Console.WriteLine("Введите сумму");
            int sum = int.Parse(Console.ReadLine());

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
