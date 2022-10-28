using System;

namespace Sort
{
    internal class Program
    {
        static void Main()
        {
            int colCount = 7;//m
            int rowCount = 4;//n
            int[,] arr = GenerateArray(rowCount, colCount);
            //task 54
            Console.WriteLine("Исходный массив");
            PrintArray(arr);

            Console.WriteLine("Отсортированный массив: ");
            int[] row = new int[colCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < colCount; j++)
                    row[j] = arr[i, j];
                Sort(row);
                Insert(true, i, row, arr);
            }
            PrintArray(arr);

            //task 56
            int minSumNum = ArrRowSum(arr, rowCount, colCount);
            Console.WriteLine("Строка с наименьшей суммой элементов: ");
            Console.WriteLine(minSumNum);
            
            //task 
            
        }

        public static void Insert(bool isRow, int dim, int[] source, int[,] dest)
        {
            for (int i = 0; i < source.Length; i++)
            {
                if (isRow)
                    dest[dim, i] = source[i];
                else
                    dest[i, dim] = source[i];
            }
        }

        public static int[,] GenerateArray(int r, int c)
        {
            int[,] array = new int[r, c];
            Random random = new Random();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    array[i, j] = random.Next(0, 9);
                }
            }
            return array;
        }

        public static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Sort(int[] inArray)
        {
            for (int i = 0; i < inArray.Length; i++)
                for (int j = 0; j < inArray.Length - i - 1; j++)
                {
                    if (inArray[j] < inArray[j + 1])
                    {
                        int temp = inArray[j];
                        inArray[j] = inArray[j + 1];
                        inArray[j + 1] = temp;
                    }
                }
        }
        public static int ArrRowSum(int[,] inArray, int a, int b)
        {
            int numRow = 0;
            int[] arraySum = new int[a];
            for (int i = 0; i < a; i++)
            {
                int tempSum = 0;
                for (int j = 0; j < b; j++)
                {
                    tempSum += inArray[i, j];
                }
                arraySum[i] = tempSum;
            }
            for (int i = 0; i < a - 1; i++)
            {
                if (arraySum[i] < arraySum[i + 1])
                {
                    numRow = i;
                } else
                {
                    numRow = i + 1;
                }

            }
            return numRow;
        }

    }

}