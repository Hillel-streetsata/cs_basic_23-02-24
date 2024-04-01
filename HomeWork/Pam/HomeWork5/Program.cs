using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        FirstTask();
        SecondTask();
        ThirdTask();
        FourthTask();
        FifthTask();
        SixthTask();
        SeventhTask();
    }

    static void FirstTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 1
        Console.WriteLine("Завдання 1".PadLeft((Console.WindowWidth + "Завдання 1".Length) / 2));

        Console.WriteLine("Введіть число для виведення таблиці множення:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Таблиця множення для числа {number}:");

        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
            i++;
        }

    }

    static void SecondTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 2
        Console.WriteLine("Завдання 2".PadLeft((Console.WindowWidth + "Завдання 2".Length) / 2));

        int number;
        bool CorrectNumber;

        do
        {
            Console.WriteLine("Введіть число:");
            string input = Console.ReadLine();

            
            CorrectNumber = int.TryParse(input, out number);

            if (!CorrectNumber)
            {
                Console.WriteLine("Неправильний формат числа. Будь ласка, введіть ЧИСЛО.");
            }
        }
        while (!CorrectNumber);

        Console.WriteLine($"Ви ввели правильний формат числа: {number}");

    }

    static void ThirdTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 3
        Console.WriteLine("Завдання 3".PadLeft((Console.WindowWidth + "Завдання 3".Length) / 2));

        int rows;
        Console.WriteLine("Введіть кількість рядків для піраміди:");
        while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
        {
            Console.WriteLine("Неправильне введення. Будь ласка, введіть ціле число більше за нуль.");
        }

        // Внешний цикл для кількості рядків
        for (int i = 1; i <= rows; i++)
        {
            // Пробіл для вирівнювання рядків
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Зірочки для кожного рядка
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            // Перехід на новий рядок
            Console.WriteLine();
    }    }
    static void FourthTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 4
        Console.WriteLine("Завдання 4".PadLeft((Console.WindowWidth + "Завдання 4".Length) / 2));

        Console.WriteLine("Введіть число:");
        string number = Console.ReadLine();

        int sum = 0;
        foreach (char numerChar in number)
        {
            if (char.IsDigit(numerChar))
            {
                int numer = int.Parse(numerChar.ToString());
                sum += numer;
            }
        }

        Console.WriteLine($"Сума всіх цифр у числі {number} дорівнює {sum}");
    }
    static void FifthTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 5
        Console.WriteLine("Завдання 5".PadLeft((Console.WindowWidth + "Завдання 5".Length) / 2));

        int number;
        bool numer;

        do
        {
            Console.WriteLine("Введіть число:");
            numer = int.TryParse(Console.ReadLine(), out number);

            if (!numer || number < 0)
            {
                Console.WriteLine("Неправильне введення. Будь ласка, введіть невід'ємне ціле число.");
            }
        } while (!numer || number < 0);

        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Факторіал числа {number} дорівнює {factorial}");
    }
    static void SixthTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 6
        Console.WriteLine("Завдання 6".PadLeft((Console.WindowWidth + "Завдання 6".Length) / 2));

        Random random = new Random();
        bool playAgain;

        do
        {
            
            int user1 = random.Next(1, 7);
            int user2 = random.Next(1, 7);
            int computer1 = random.Next(1, 7);
            int computer2 = random.Next(1, 7);
            int UserSum = user1 + user2;
            int ComputerSum = computer1 + computer2;

            Console.WriteLine($"Викиньте кубики!\nВаші кубики: {UserSum}\nКубики комп'ютера: {ComputerSum}");

            
            if (UserSum > ComputerSum)
            {
                Console.WriteLine("Ви виграли!");
            }
            else if (UserSum < ComputerSum)
            {
                Console.WriteLine("Комп'ютер виграв!");
            }
            else
            {
                Console.WriteLine("Нічия!");
            }

            
            Console.WriteLine("Хочете грати знову? (так/ні)");
            string input = Console.ReadLine().ToLower();

            playAgain = (input == "так");
            Console.WriteLine();
        } while (playAgain);

        Console.WriteLine("Гра завершена.");
    }
    static void SeventhTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 7
        Console.WriteLine("Завдання 7".PadLeft((Console.WindowWidth + "Завдання 7".Length) / 2));

        List<int> numbers = new List<int> { 45, 509, 123, 49, 12, 1, 902, 1304, 11, 19, 8, 7, 3, 0 };

        int max = int.MinValue;
        int min = int.MaxValue;

        
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }
 
        Console.WriteLine($"Найбільше значення: {max}");
        Console.WriteLine($"Найменше значення: {min}");

    }
}
