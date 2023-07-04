// Урок 7. Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

using System;

namespace TaskCS7_52
{
    class TaskCS7_52
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк двумерного массива,\nзаполненного целыми числами");
            int mRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов двумерного массива,\nзаполненного целыми числами");
            int nColumns = int.Parse(Console.ReadLine());
            int[,] array = new int[mRows, nColumns]; // объявление массива 
            // цикл задания элементов массива и вывода на консоль
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    Console.Write("a[" + (i + 1) + "," + (j + 1) + "]=");
                    array[i,j] = int.Parse(Console.ReadLine());
                }
                Console.Write("\n");
            }
            Console.WriteLine("\nВведенный массив:");
            // цикл вывода на экран введенного массива
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }
            double currentSrArifm = 0; // текущее среднее арифметическое
            Console.WriteLine("\nСредние арифметиченские по столбцам:");
            // цикл подсчета и вывода среднего арифметического по столбцам
            for (int i = 0; i < nColumns; i++)
            {
                currentSrArifm = 0;
                for (int j = 0; j < mRows; j++)
                {
                    currentSrArifm += array[j, i];
                }
                currentSrArifm /= mRows;
                Console.Write(currentSrArifm+"\t");
            }
            Console.Write("\n");
        }
    }
}
