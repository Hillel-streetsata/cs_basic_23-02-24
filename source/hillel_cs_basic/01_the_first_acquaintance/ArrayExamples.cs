using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_the_first_acquaintance
{
    public class ArrayExamples
    {
        //Tasks
        //    Напишіть програму, яка знаходить найбільший елемент у масиві.
        public void ArrayMaxElement(int[] arr) // { -1 -2 1 2 3 }
        {
            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }

                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"{min}\t{max}");
        }


        //    Напишіть програму, яка знаходить середнє арифметичне всіх елементів у масиві.

        public void AverageArr(int[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum / arr.Length);
        }
        //    Напишіть програму, яка обчислює суму всіх парних елементів у масиві. 

        public void SumEvenElementOfArr(int[] arr)
        {
            int sum = 0;

            for (int i = 0 /*1*/; i < arr.Length; i += 2)
            {
                //if (i % 2 != 0) // Odd Elements 
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine(sum);
        }

        //    Напишіть програму, яка перевертає масив (змінює порядок елементів на зворотний).
        public void ReverseArr(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            // -4, 1, 1, 5, 3, 7, -2 
            // -2, 7, 3, 5, 1, 1, -4
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
                /*arr[i]*/ // ?? 7 IndexOutOfRangeExaption
            }

            Array.Reverse(arr);
            Console.WriteLine();
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

        }

        //    Напишіть програму, яка перевіряє, чи масив є відсортованим у зростаючому порядку.
        public void IsSortedIntoGrowingOrder(int[] arr)
        {
            bool isSortedIntoGrowingOrder = true;
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    isSortedIntoGrowingOrder = false;
                }
                //else
                //{
                //    isSortedIntoGrowingOrder = true;
                //}
            }

            Console.WriteLine(isSortedIntoGrowingOrder);
        }

        //    Напишіть програму, яка замінює всі від'ємні елементи у масиві на нульові. 

        public void SwitchNegativeElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        //    Напишіть програму, яка знаходить позицію(індекс) заданого елемента у масиві.
        //    Напишіть програму, яка обчислює кількість входжень заданого елемента у масив.
        //    Зміна розміру масиву 
        //    Як скопіювати масив
        //    Сортування масиву (Bubble Sort)
        //    Пошук елементів у масиві



    }
}
