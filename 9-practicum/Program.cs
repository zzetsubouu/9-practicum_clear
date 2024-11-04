using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить, имеются ли в одномерном массиве случайных чисел элементы, значения которых кратны 11.
            //Вывести такие значения.
            //const int value = 5;
            //int[] ints = new int[value];
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.Write($"inst[{i}]= ");
            //    ints[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("числа массива, кратные 11:");
            //foreach (int element in ints)
            //{
            //    if (element % 11 == 0)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}



            //Задача 2.Найти сумму и количество положительных элементов в одномерном массиве с явной инициализацией.
            //int[] massiv = { 3, 5, 8, -7, -5, 10, 11, -2 };
            //int count = 0, sum = 0;
            //foreach (var element in massiv)
            //{
            //    if (element > 0)
            //    {
            //        sum += element;
            //        count++;
            //    }
            //}
            //Console.WriteLine($"Количество положительных чисел в массиве: {count}\nСумма положительных чисел массива: {sum}");



            //Задача 3. Вывести элементы одномерного массива, заполненного с клавиатуры ,в обратном порядке.
            int[] invertedMas = new int[5];
            for (int i = 0; i < invertedMas.Length; i++)
            {
                Console.Write($"inst[{i}]= ");
                invertedMas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Перевернутый массив:");
            for (int j = invertedMas.Length - 1; j >= 0; j--)
            {
                Console.WriteLine(invertedMas[j]);
            }


            Console.ReadKey();
        }
    }
}
