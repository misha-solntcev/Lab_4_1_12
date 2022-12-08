using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 12. В одномерном массиве целых чисел a1, а2, ..., an 
    найти номер первого четного числа. 
    Если четных чисел нет, то ответом может быть число 0. */

namespace Lab_4_1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    num = i;
                    break;
                }
            }
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
