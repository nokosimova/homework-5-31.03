using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem 2:
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
                arr[i] = (int) new Random().Next(-100,100);//для удобства я решила егерировать числа от -100 до 100
                Console.Write($"{arr[i]}  ");
            }
            Console.Write("] \n");
            max_pos = 0;
            min_pos = 0;
            summ += arr[0];
            for(i = 1; i < n; i++) {
                if (arr[i] > arr[max_pos]) {
                    max_pos = i;   
                }
                if (arr[i] < arr[min_pos]) {
                    min_pos = i;
                }
                summ += arr[i];
            }
            midsum = (double)summ / n;
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
            //problem 3:
            Console.WriteLine("\n-----------------Задача 3---------------------");
            Console.WriteLine($"Задайте через пробел массив произвольной длины: ");
            string[] p = Console.ReadLine().Split();
            int l = p.Length, t;
            int[] arr1 = new int[l];
            for (int j = 0; j < l; j++) {
                arr1[j] = int.Parse(p[j]);
            }
            for (i = 0; i < l/2; i++) {
                t = arr1[i];
                arr1[i] = arr1[l-1-i];
                arr1[l-1-i] = t;
            }
            Console.WriteLine("Инвертированный массив:");
            foreach (int item in arr1)
            {
                Console.Write($"{item} ");
            } 
        
        //problem 4:
            int count, index;
            Console.WriteLine("\n-----------------Задача 4---------------------");
            Console.Write("Введите размер массива: n = ");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            Console.Write("Array = [");
            for (i = 0; i < n; i++) {
                arr[i] = (int) new Random().Next(-100,100);//для удобства я решила егерировать числа от -100 до 100
                Console.Write($"{arr[i]}  ");
            }
            Console.WriteLine("]");
            Console.Write("Введите count = ");
            count = int.Parse(Console.ReadLine());
            Console.Write("\nВведите index = ");
            index = int.Parse(Console.ReadLine());
            int[] new_arr = new int[count];
            for (i = 0; i < count; i++) {
                if (i+index < n) {
                    new_arr[i] = arr[i+index];
                } else {
                    new_arr[i] = 1;
                }
            }
            Console.WriteLine("Новый массив:");
            foreach (int item in new_arr)
            {
                Console.Write($"{item} ");
            }             
        }
    }
}
