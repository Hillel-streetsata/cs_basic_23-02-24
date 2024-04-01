using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zharskyi_Nazar_HW_6
{
    public class SecondHW6Part
    {
        public void task_1S()
        {
            int[,] arr = new int[10, 10];
            for (int i = 0;i<arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(-10, 11);
                }
            }
            for(int i = 0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void task_2S()
        {
            int[,] arr = new int[10,10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(-10, 11);
                }
            }
            Console.WriteLine("Full massive: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"Right height element is {arr[0,9]} ");
            Console.WriteLine();
            Console.Write($"Left low element is {arr[9, 0]} ");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void task_3S()
        {
            int[,] arr = new int[10, 10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(-10, 11);
                }
            }
            Console.WriteLine("Full massive: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter the number of element which to change in 5th line(from 0 to 9)");
            int el1 = 0;
            arr[4, el1] = 1949;
            try
            {
                el1 = Convert.ToInt32(Console.ReadLine());
                if (el1 >= 0 && el1 < 10)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            Console.Write(arr[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            Console.WriteLine();
            Console.WriteLine();
            int num = 0, line = 0;
            int num1 = 0;
            
            Console.Write("Enter the line of element which to change(from 0 to 9): ");
            try
            {
                line = Convert.ToInt32(Console.ReadLine());
                if(line >= 0 && line<10) 
                {
                    Console.Write("Enter the number of element which to chang(from 0 to 9): ");
                    try
                    {
                        num = Convert.ToInt32(Console.ReadLine());
                        if(num >= 0 && num<10) 
                        {
                            Console.Write("Enter the number for element: ");
                            try
                            {
                                num1 = Convert.ToInt32(Console.ReadLine());
                                arr[line, num] = num1;
                                for (int i = 0; i < arr.GetLength(0); i++)
                                {
                                    for (int j = 0; j < arr.GetLength(1); j++)
                                    {
                                        Console.Write(arr[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }

                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }         
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
            
        }
        public void task_4S()
        {
            int[,] arr = new int [10, 10];
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    arr[i, j] = i*j;
                    Console.Write($"{i} x {j} = {arr[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        public void task_5S()
        {
            int[,] arr = new int[10, 10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(-10, 11);
                }
            }
            Console.WriteLine("Full massive: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 2; i < 3; i++)
            {
                for (int j = arr.GetLength(0) - 1; j >= 0; j--)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int k = 0;
            Console.Write("Enter number from 0 to 9: ");
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
                if (k >= 0 && k < 10)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = k; j < k+1; j++)
                        {
                            Console.WriteLine(arr[i, j] + " ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You entered incorrect data");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void task_6S()
        {
            int[,] arr = new int[10, 10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1,10);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int counter = 0;
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    counter += arr[i, j];
                }
            }
            Console.WriteLine("The sum of 3rd line = " + counter);
            counter = 0;
            int s = 0;
            Console.Write("Enter the number from 0 to 9: ");
            try
            {
                s=Convert.ToInt32(Console.ReadLine());
                if (s >= 0 && s < 10)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = s; j < s+1; j++)
                        {
                            counter += arr[i, j];
                        }
                    }
                    Console.Write("The sum is "+counter);
                }
                else
                {
                    Console.WriteLine("You`ve entered incorrect data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void task_7S()
        {
            int[,] arr = new int[10, 10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int counter = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < 2; j++)
                {
                    counter += arr[i, j];
                }
            }
            Console.WriteLine("The sum is " + counter);
            int k = 0;
            counter = 0;
            Console.Write("Enter the number from 0 to 9: ");
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
                if (k >= 0 && k < 10)
                {
                    for (int i = k; i < k+1; i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            counter += arr[i, j];
                        }
                    }
                    Console.Write("The sum is " + counter);
                }
                else
                {
                    Console.WriteLine("You`ve entered incorrect data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void task_8S()
        {
            int[,] arr = new int[10, 10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int counter = 0;
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    counter += arr[i, j] * arr[i, j];
                }
            }
            Console.WriteLine("The sum is " + counter);
            Console.WriteLine();
            counter = 0;
            int c = 0;
            Console.Write("Enter the number from 0 to 9: ");
            try
            {
                c = Convert.ToInt32(Console.ReadLine());
                if (c >= 0 && c < 10)
                {
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        for (int j = c; j < c + 1; j++)
                        {
                            counter += arr[i, j] * arr[i, j];
                        }
                    }
                    Console.Write("The sum is " + counter);
                }
                else
                {
                    Console.WriteLine("You`ve entered incorrect data");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void task_9S()
        {
            int max = 0, min = 0, cor1 = 0, cor2 = 0, cor3 = 0, cor4 = 0;
            int[,] arr = new int[10, 10];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            max = min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            for(int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max= arr[i, j];
                        cor1 = i;
                        cor2 = j;
                    }
                    if (min >= arr[i, j])
                    {
                        min= arr[i, j];
                        cor3=i; 
                        cor4 = j;
                    }
                }
            }
            Console.WriteLine($"Max element = {max}, coordinates: [{cor1},{cor2}] ");
            Console.WriteLine($"Min element = {min}, coordinates: [{cor3},{cor4}] ");
        }
    }
}
