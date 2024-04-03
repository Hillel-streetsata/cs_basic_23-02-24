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
        public void FoundPosition(int[] arr, int elem)
        {
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == elem)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            Console.WriteLine(Array.IndexOf(arr, elem)); // First
            Console.WriteLine(Array.LastIndexOf(arr, elem)); // First
        }

        //    Напишіть програму, яка обчислює кількість входжень заданого елемента у масив.
        public void Count(int[] arr, int elem)
        {
            int count = 0;
            foreach (int item in arr)
            {
                if(item == elem)
                    count++;
            }

            Console.WriteLine(count);

            // Linq-Method
        }
        //    Зміна розміру масиву 

        //    Як скопіювати масив
        public void ArrayCopy(int[] sourceArr, ref int[] destinationArray)
        {
            for (int i = 0; i < sourceArr.Length; i++)
            {
                destinationArray[i] = sourceArr[i];
            }
        }

        //    Сортування масиву (Bubble Sort)
        public void ArraySort(int[] arr) 
        {
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        //    Пошук елементів у масиві
        public int BinSearch(int[] arr, int elem)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right) 
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == elem)
                {
                    return mid;
                }
                else if (arr[mid] < elem)
                {
                    left = mid + 1; // Шукати у правій частині масиву
                }
                else 
                {
                    right = mid - 1; // Шукати у лівій частині масиву
                }
            }


            return -1; // Method is faild || -1 NotFound
        }



    }
}
