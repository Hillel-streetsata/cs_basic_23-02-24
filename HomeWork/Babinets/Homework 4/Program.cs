using System;
using System.Diagnostics.CodeAnalysis;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n 1. Створіть програму, яка використовує цикл while для виведення на екран таблиці множення для введеного користувачем числа.");
                Console.WriteLine("Please enter number to calculate.");
                int i = Convert.ToInt32(Console.ReadLine());
                int j = 0;
                while (j < 10)
                {
                    j++;
                    Console.Write($"{i} x {j} = {i * j} \n");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ви ввели некоректне значення." + ex);
            }
            DoWhile();
        }
        static void DoWhile()
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n 2. Напишіть програму, яка використовує цикл do-while для запиту у користувача числа, поки він не введе правильне значення.");
                int enigma = 5;
                int attempt;
                do
                {
                    Console.WriteLine("Please guess the number from one to ten?");
                    attempt = Convert.ToInt32(Console.ReadLine());
                    if (attempt != enigma)
                    {
                        Console.WriteLine("Please try it again.");
                    }
                }
                while (attempt != enigma);
                Console.WriteLine("You are right. :) " + attempt + ":" + enigma);
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Ви ввели некоректне значення." + ex);
            }
            Stars();
        }
        static void Stars()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n 3. Реалізуйте програму, яка використовує вкладені цикли для створення піраміди з зірочок на екрані.");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" \t ");
                }
                for (int k = 0; k < (5 - i); k++)
                {
                    Console.Write("\t *");
                }
                Console.WriteLine();
            }
            ForEach();
        }

        static void ForEach()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n 4.Створіть програму, яка знаходить суму всіх цифр в заданому числі, використовуючи цикл foreach. Може бути як 9, або 181547785.");
            int sum = 0;
            int n = new Random().Next(9, 181547786);
            string num = n.ToString();
            foreach (char digitChar in num)
            {
                int digit = Convert.ToInt32(digitChar.ToString());
                sum += digit;
            }
            Console.WriteLine($"Number =  {n}, suma =  {sum}");
            Faktorial();
        }
    
    static void Faktorial()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n 5.Напишіть програму, яка використовує цикл for для знаходження факторіалу введеного користувачем числа.");
            int value = 1;
            Console.WriteLine("Please to enter the number to calculate factorial_");
            int user = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= user; i++)
            {
                {
                    value *= i;
                    Console.WriteLine($"{user}! = {value}" + "\t");
                }
            }
            Console.WriteLine("final");
        }
        catch (Exception ex)
        {
            Console.WriteLine(" Ви ввели некоректне значення." + ex);
        }
        Cube();
    }
    static void Cube()
    {
        try
        {

            Console.WriteLine("\n 6.Створіть програму, яка використовує цикл do-while для гри в кубики з користувачем, доки він не вирішить припинити гру.");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t IF YOU WANT TO EXIT PRESS SPACE");
            Console.WriteLine("\n\t\t\t IF YOU WANT TO CONTINUE PRESS ANY KEY");
            Console.WriteLine("\n\t\t\t START \n");
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n\t Player 1.Please enter to throw the cube ");
                int player1 = Convert.ToInt32(Console.ReadLine());
                int player2 = new Random().Next(1, 7);
                Console.WriteLine("Player 2.My attempt " + player2);
                Console.ForegroundColor = ConsoleColor.Green;
                if (player1 > player2)
                {
                    Console.WriteLine("Player 1 WIN.");
                }
                else if (player1 < player2)
                { Console.WriteLine("Player 2 WIN."); }
                else
                { Console.WriteLine("Draw"); }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Spacebar);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Game Over.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(" Ви ввели некоректне значення." + ex);
        }
        ListInt();
    }
    // Тут Вам також самостійно треба дізнатися за List<int> (проходити ми будемо його трохи пізніше, а ви додатково познайомитесь зараз))))
    static void ListInt()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\n 7. Реалізуйте програму, яка використовує цикл foreach для пошуку найбільшого та найменшого значень у списку чисел.");
        List<int> numbers = new List<int>();
        numbers.Add(new Random().Next(1, 100));
        numbers.Add(new Random().Next(1, 100));
        numbers.Add(new Random().Next(1, 100));
        Console.WriteLine("List of numbers:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
        int MaxNum = numbers.Max();
        int MinNum = numbers.Min();
        Console.WriteLine($"\n{MaxNum} = max number. \t\t {MinNum} = min number.");
        Console.WriteLine();
    }

}

}


