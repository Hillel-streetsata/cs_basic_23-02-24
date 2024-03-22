using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        // Завдання 1
        Console.WriteLine("Завдання 1".PadLeft((Console.WindowWidth + "Завдання 1".Length) / 2));

        Console.WriteLine("Введіть ціле число");
        int number = Convert.ToInt32(Console.ReadLine());

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
        Console.WriteLine("Отримане число:" + number);

        // Завдання 2
        Console.WriteLine("Завдання 2".PadLeft((Console.WindowWidth + "Завдання 2".Length) / 2));

        Random rnd = new Random();

        int number1 = rnd.Next(-10, 11); // Генеруємо 3 числа
        int number2 = rnd.Next(-10, 11); // Генеруємо 3 числа
        int number3 = rnd.Next(-10, 11); // Генеруємо 3 числа

        Console.WriteLine($"Згенеровані числа: {number1}, {number2}, {number3}"); // Виводимо згенеровані числа

        int positiveCount = 0; // Рахує позитивні числа

        if (number1 > 0)
        {
            positiveCount++;
        }
        if (number2 > 0)
        {
            positiveCount++;
        }
        if (number3 > 0)
        {
            positiveCount++;
        }
        Console.WriteLine("Кількість додатних чисел:" + positiveCount);

        // Завдання 3
        Console.WriteLine("Завдання 3".PadLeft((Console.WindowWidth + "Завдання 3".Length) / 2));

        Random rand = new Random(); // Генеруємо три випадкові цілі числа

        int[] num = new int[3];
        for (int i = 0; i < 3; i++)
        {
            num[i] = rand.Next(-10, 11);
        }

        Console.WriteLine($"Згенеровані числа: {num[0]}, {num[1]}, {num[2]}");

        int PositiveCount = 0; // Лічильники позитивних чисел
        int NegativeCount = 0; // Лічильники негативних чисел
        int ZeroCount = 0; // Лічильник 0

        for (int i = 0; i < 3; i++)
        {
            if (num[i] > 0)
            {
                PositiveCount++;
            }
            else if (num[i] < 0)
            {
                NegativeCount++;
            }
            else
            {
                ZeroCount++;
            }
        }

        Console.WriteLine("Кількість позитивних чисел: " + PositiveCount); // Виводимо результати
        Console.WriteLine("Кількість негативних чисел: " + NegativeCount); // Виводимо результати
        Console.WriteLine("Кількість нулів: " + ZeroCount); // Виводимо результати

        // Завдання 4
        Console.WriteLine("Завдання 4".PadLeft((Console.WindowWidth + "Завдання 4".Length) / 2));

        Console.WriteLine("Введіть значення для змінної A:");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть значення для змінної B:");
        int B = Convert.ToInt32(Console.ReadLine());

        if (A != B)
        {
            A += B;
            B = A;
        }
        else
        {
            A = 0;
            B = 0;
        }

        Console.WriteLine("Нове значення для змінної A: " + A);
        Console.WriteLine("Нове значення для змінної B: " + B);

        // Завдання 5
        Console.WriteLine("Завдання 5".PadLeft((Console.WindowWidth + "Завдання 5".Length) / 2));

        Console.WriteLine("Введіть ціле число:");
        int numbers = Convert.ToInt32(Console.ReadLine());

        if (numbers % 2 == 0) // Перевіряємо залишок
        {
            Console.WriteLine("Число є парним.");
        }
        else
        {
            Console.WriteLine("Число є непарним.");

        }

        // Завдання 6
        Console.WriteLine("Завдання 6".PadLeft((Console.WindowWidth + "Завдання 6".Length) / 2));

        Console.WriteLine("Введіть номер одиниці довжини (1 - дециметр, 2 - кілометр, 3 - метр, 4 - міліметр, 5 - сантиметр):");
        int unit = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть довжину відрізка в цих одиницях:");
        double length = Convert.ToDouble(Console.ReadLine());

        double lengthInMeters = 0;

        switch (unit)
        {
            case 1: // дециметр
                lengthInMeters = length * 0.1;
                break;
            case 2: // кілометр
                lengthInMeters = length * 1000;
                break;
            case 3: // метр
                lengthInMeters = length;
                break;
            case 4: // міліметр
                lengthInMeters = length * 0.001;
                break;
            case 5: // сантиметр
                lengthInMeters = length * 0.01;
                break;
            default:
                Console.WriteLine("Неправильно введений номер одиниці довжини.");
                return;
        }
        Console.WriteLine($"Довжина відрізка в метрах: {lengthInMeters} м");

        // Завдання 7
        Console.WriteLine("Завдання 7".PadLeft((Console.WindowWidth + "Завдання 7".Length) / 2));

        Console.WriteLine("Введіть початковий напрямок робота (N, W, S, E):");
        char direction = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        int currentDirection = 0; // 0 - північ, 1 - захід, 2 - південь, 3 - схід

        switch (direction)
        {
            case 'N':
                currentDirection = 0;
                break;
            case 'W':
                currentDirection = 1;
                break;
            case 'S':
                currentDirection = 2;
                break;
            case 'E':
                currentDirection = 3;
                break;
            default:
                Console.WriteLine("Неправильно введений початковий напрямок робота.");
                return;
        }

        Console.WriteLine("Введіть команду для робота (0 - продовжити рух, 1 - повернути ліворуч, -1 - повернути праворуч):");
        int command = Convert.ToInt32(Console.ReadLine());

        switch (command)
        {
            case 0:
                break;
            case 1:
                currentDirection = (currentDirection + 1) % 4; // повернути ліворуч
                break;
            case -1:
                currentDirection = (currentDirection + 3) % 4; // повернути праворуч
                break;
            default:
                Console.WriteLine("Неправильно введена команда.");
                return;
        }

        char newDirection = ' ';
        switch (currentDirection)
        {
            case 0:
                newDirection = 'N';
                break;
            case 1:
                newDirection = 'W';
                break;
            case 2:
                newDirection = 'S';
                break;
            case 3:
                newDirection = 'E';
                break;
        }

        Console.WriteLine($"Напрямок робота після виконання команди: {newDirection}");

        // Завдання 8
        Console.WriteLine("Завдання 8".PadLeft((Console.WindowWidth + "Завдання 8".Length) / 2));

        Console.WriteLine("Введіть вік (від 20 до 69 років):");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 20 || age > 69)
        {
            Console.WriteLine("Неправильно введений вік. Введіть вік від 20 до 69 років.");
            return;
        }

        string[] numb = { "двадцять", "тридцять", "сорок", "п'ятдесят", "шістдесят" };

        int tens = age / 10;
        int ones = age % 10;

        string description = "";

        if (tens > 2)
        {
            description = numb[tens - 2];
        }
        else if (tens == 2)
        {
            description = "двадцять";
        }

        if (ones > 0)
        {
            string[] units = { "один", "два", "три", "чотири", "п'ять", "шість", "сім", "вісім", "дев'ять" };
            description += " " + units[ones - 1];
        }

        description += " рік";

        Console.WriteLine($"Опис віку: {description}");

    }
}