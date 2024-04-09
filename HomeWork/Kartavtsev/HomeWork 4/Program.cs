﻿namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first_task();
            second_task();
            third_task();
            fourth_task();
            fifth_task();
            sixth_task();
            seventh_task();
           
        }

        static void Little_bit_beauty()
        {
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                Console.Write("=");

            }
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                Console.Write("=");

            }
            Console.WriteLine();


        } 
