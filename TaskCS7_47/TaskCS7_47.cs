// Урок 7. Задача 47. Задайте двумерный массив размером mxn,
// заполненный случайными вещественными числами.

using System;

namespace TaskCS7_47
{
    class TaskCS7_47
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк двумерного массива,\nзаполненного случайными вещественными числами");
            int mRows = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов двумерного массива,\nзаполненного случайными вещественными числами");
            int nColumns = int.Parse(Console.ReadLine());
            double[,] array = new double[mRows,nColumns]; // объявление массива 
            Random rnd = new Random();
            Console.WriteLine("\nСгенерированный двумерный массив:");
            // цикл генерации элементов массива и вывода на консоль
            for (int i = 0; i < mRows; i++)
            {
                for (int j = 0; j < nColumns; j++)
                {
                    array[i, j] = rnd.Next(-99, 99)/10.0;
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
             }         
        }
    }
}
