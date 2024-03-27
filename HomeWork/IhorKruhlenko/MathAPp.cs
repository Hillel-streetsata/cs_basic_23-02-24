using System;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
    }

    static void Task1()
    {
        Console.WriteLine("Task 1:");
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            number += 1;
        }
        else if (number < 0)
        {
            number -= 2;
        }
        else
        {
            number = 10;
        }

        Console.WriteLine("Resulting number: " + number);
    }

    static void Task2()
    {
        Console.WriteLine("\nTask 2:");
        Console.WriteLine("Enter three integers:");
        int positiveCount = 0;

        for (int i = 0; i < 3; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                positiveCount++;
            }
        }

        Console.WriteLine("Number of positive integers: " + positiveCount);
    }

    static void Task3()
    {
        Console.WriteLine("\nTask 3:");
        Console.WriteLine("Enter three integers:");
        int positiveCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < 3; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                positiveCount++;
            }
            else if (num < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Number of positive integers: " + positiveCount);
        Console.WriteLine("Number of negative integers: " + negativeCount);
    }

    static void Task4()
    {
        Console.WriteLine("\nTask 4:");
        Console.WriteLine("Enter two integers:");
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());

        if (A != B)
        {
            A += B;
            B = A;
        }
        else
        {
            A = B = 0;
        }

        Console.WriteLine("A: " + A);
        Console.WriteLine("B: " + B);
    }

    static void Task5()
    {
        Console.WriteLine("\nTask 5:");
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }

    static void Task6()
    {
        Console.WriteLine("\nTask 6:");
        Console.WriteLine("Enter unit number (1-5) and length:");
        int unitNumber = int.Parse(Console.ReadLine());
        double length = double.Parse(Console.ReadLine());

        switch (unitNumber)
        {
            case 1:
                length *= 0.1;
                break;
            case 2:
                length *= 1000;
                break;
            case 3:
                // длина в метрах
                break;
            case 4:
                length *= 0.001;
                break;
            case 5:
                length *= 0.01;
                break;
            default:
                Console.WriteLine("Invalid unit number.");
                return;
        }

        Console.WriteLine("Length in meters: " + length);
    }

    static void Task7()
    {
        Console.WriteLine("\nTask 7:");
        Console.WriteLine("Enter initial direction (N/W/S/E) and command (0/1/-1):");
        char initialDirection = char.ToUpper(Console.ReadLine()[0]);
        int command = int.Parse(Console.ReadLine());

        char newDirection = initialDirection;

        switch (command)
        {
            case 0:
                // Continue moving in the same direction
                break;
            case 1:
                newDirection = TurnLeft(initialDirection);
                break;
            case -1:
                newDirection = TurnRight(initialDirection);
                break;
            default:
                Console.WriteLine("Invalid command.");
                return;
        }

        Console.WriteLine("New direction: " + newDirection);
    }

    static char TurnLeft(char direction)
    {
        switch (direction)
        {
            case 'N':
                return 'W';
            case 'W':
                return 'S';
            case 'S':
                return 'E';
            case 'E':
                return 'N';
            default:
                return direction;
        }
    }

    static char TurnRight(char direction)
    {
        switch (direction)
        {
            case 'N':
                return 'E';
            case 'W':
                return 'N';
            case 'S':
                return 'W';
            case 'E':
                return 'S';
            default:
                return direction;
        }
    }
}