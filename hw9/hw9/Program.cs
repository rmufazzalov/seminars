using System;

namespace hw9
{
    internal class Program
    {
        static void Main()
        {
            //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
            Random random = new Random();
              int num1 = random.Next(0, 9);
              Console.Write("N = " + num1 + "=>");
              Integers(num1); 

              //Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
              int M = random.Next(1, 10);
              int N = random.Next(11, 20);
              Console.WriteLine("\nN = " + N + "\nM = " + M);
              int sum = 0;
              IntegersSum(M, N, sum); 

            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            Console.WriteLine("Функция Аккермана от 2 и 3: " + Ackerman(2, 3));

        }

        public static void Integers(int num1)
        {
        if (num1 > 0)
            {
                Console.Write(num1);
                num1--;
                Integers(num1);
            }
            else return;
        }

        public static void IntegersSum(int m, int n, int sum)
        {
            if (n > m)
            {
                sum += n;
                n--;
                IntegersSum(m, n, sum);
            }
            else
            {
                Console.WriteLine("Сумма чисел между числами: " + sum);
            }
        }

        static int Ackerman(int m, int n)
        {
           if ((m >= 0) && (n >= 0))
            {
                if (m == 0) return n + 1;
                if (n == 0) return Ackerman(m - 1, 1);
                return Ackerman(m - 1, Ackerman(m, n - 1));
            }
            else
            {
                return 0;
            }
        }

    }

}