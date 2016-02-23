using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cycles
{
    class Tasks
    {
        public static void Task1()
        {
            int n=int.Parse(Console.ReadLine());

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(n.ToString() +" * "+i.ToString() +" = " +(n * i).ToString());
            }


        }
        public static void Task2()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 1;

            while ( (n/Convert.ToInt32(Math.Pow(10,count))) !=0)
            {
                
                count++;
            }
            Console.WriteLine((count).ToString() + " разрядов");
        }
        public static void Task3()
        {
            Random r=new Random();
            int number=r.Next(1,146);

            int k=-1;
            //k = int.Parse(Console.ReadLine());
            while (k != number)
            {
                k = int.Parse(Console.ReadLine());
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
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (Math.Pow(i, 2) < n)
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
                numbers[i] = int.Parse(Console.ReadLine());
                ar += Convert.ToDouble(numbers[i]) / 5.0;
            }
            Console.WriteLine(ar);


        }
        public static void Task6()
        {
            int[] numbers = new int[5];
            Random r = new Random();
            double ar = 0;

            for (int i = 0; i < 5; i++)
            {
                ar += Convert.ToDouble(r.Next(int.MaxValue,int.MaxValue)) / 5.0;
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
