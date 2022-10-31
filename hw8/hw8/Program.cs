using System;

namespace Sort
{
    internal class Program
    {
        static void Main()
        {
             int colCount = 7;
             int rowCount = 4;
             int[,] arr = GenerateArray(rowCount, colCount);

             //Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

            //Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
              int minSumNum = ArrRowSum(arr, rowCount, colCount);
              Console.WriteLine("Строка с наименьшей суммой элементов: ");
              Console.WriteLine(minSumNum); 

            //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
             int matrixSideCount = 2;
             int[,] matrix1 = GenerateArray(matrixSideCount, matrixSideCount);
             int[,] matrix2 = GenerateArray(matrixSideCount, matrixSideCount);
             PrintArray(matrix1);
             PrintArray(matrix2);
             int[,] resultMatrix = MatrixMult(matrix1, matrix2, matrixSideCount);
             PrintArray(resultMatrix); 

            //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
            //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
              int arrParam1 = 2;
              int arrParam2 = 2;
              int arrParam3 = 2;
              int[,,] arr3 = GenerateArray2(arrParam1, arrParam2, arrParam3);
              PrintArray2(arr3);   


            //Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
            int[,] arr4 = GenerateArray3(4);
            PrintArray(arr4);

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
        public static int[,] MatrixMult(int[,] inArray1, int[,] inArray2, int a)
        {
            int [,] arrayMult = new int[a, a];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    for (int k = 0; k < a; k++)
                    {
                        arrayMult[i, j] += inArray1[i, k] * inArray2[k, j];
                    }
                }
            }
            return arrayMult;
            
        }

        public static int[,,] GenerateArray2(int a, int b, int c)
        {
            int[,,] array = new int[a, b, c];
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < b; k++)
                    {
                        array[i, j, k] = random.Next(0, 9);
                    }
                }
            }
            return array;
        }

        public static void PrintArray2(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write(array[i, j, k] + "(" + i + ","  + j + "," + k + ")" + " ");
                    }
                }
                Console.WriteLine();
            }
        }



        public static int[,] GenerateArray3(int n)
        {
            int[,] array = new int[n, n];
            int pos = 0;
            int count = n;
            int value = -n;
            int sum = -1;

            do
            {
                value = -1 * value / n;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    array[sum / n, sum % n] = pos++;
                }
                value *= n;
                count--;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    array[sum / n, sum % n] = pos++;
                }
            } while (count > 0);

            return array;
        }

    }

}