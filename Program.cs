using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Задача 2---------------------");
            Console.WriteLine("Создать массив размера N элементов, ");
            Console.WriteLine("заполнить его произвольными целыми значениями");
            Console.Write("Введите размер массива: n = ");
            int n = int.Parse(Console.ReadLine());
            int i, max_pos, min_pos, summ = 0;
            double midsum;
            int[] arr = new int[n];
            Console.Write("Array = [");
            for (i = 0; i < n; i++) {
                arr[i] = (int) new Random().Next();
                Console.Write($"{arr[i]}  ");
            }
            Console.Write("] \n");
            max_pos = 0;
            min_pos = 0;
            summ += arr[0];
            for(i = 1; i < n; i++) {
                if (arr[i] > max_pos) {
                    max_pos = i;   
                }
                if (arr[i] < min_pos) {
                    min_pos = i;
                }
                summ += arr[i];
            }
            midsum = summ / n;
            Console.WriteLine($"MAX = {arr[max_pos]} ");
            Console.WriteLine($"MIN = {arr[min_pos]}");
            Console.WriteLine($"SUM = {summ}");
            Console.WriteLine($"MIDSUM = {midsum}");
            Console.Write($"Нечётные элементы: ");
            for(i = 0; i < n; i++) {
                if (arr[i] % 2 == 1) {
                    Console.Write($"{arr[i]} ");
                }
            } 
        }
    }
}
