// Урок 7. Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента? bkb ;t erfpfybt xnj nfrjuj 'ktvtynf ytn

using System;

namespace TaskCS7_50
{
    class TaskCS7_50
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
                    array[i, j] = rnd.Next(-99, 99) / 10.0;
                    Console.Write(array[i, j] + "\t");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\nВведите индекс номера строки желаемого элемента\n(номер первой строки равен 1):");
            int iRow = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите индекс номера столбца желаемого элемента\n(номер первого столбца равен 1):");
            int jColumn = int.Parse(Console.ReadLine());
            if ((iRow < 1) || (iRow > mRows) || (jColumn < 1) || (jColumn > nColumns))
            {
                Console.WriteLine("\nТакого элемента нет\n");
                return;
            }
            else
            {
                Console.WriteLine("\nЗначение элемента массива с введенными номерами строки и столбца равен\n"+array[iRow-1,jColumn-1]);
            }

        }
    }
}
