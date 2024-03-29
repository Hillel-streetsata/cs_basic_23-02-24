using System;
using System.Text;

class Program
{
    static void Main()
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
        
        int sum = 0;
        for (int i = 1; i < 50; i += 2)
        {
            sum += i;
        }
        Console.WriteLine("Рішення: " + sum);
    }

    static void SecondTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 2
        Console.WriteLine("Завдання 2".PadLeft((Console.WindowWidth + "Завдання 2".Length) / 2));
        

        int a = 1; // Початкове число
        int b = 100; // Кінцеве число
        int sum2 = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 4 == 0)
            {
                sum2 += i;
            }
        }
        Console.WriteLine($"Рішення: Сума натуральних чисел від {a} до {b}, кратних чотирьом: {sum2}");
    }

    static void ThirdTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 3
        Console.WriteLine("Завдання 3".PadLeft((Console.WindowWidth + "Завдання 3".Length) / 2));
        for (int i = 10; i < 100; i++)
        {
           int digit1 = i / 10; 
           int digit2 = i % 10; 

           int sumOfSquares = digit1 * digit1 + digit2 * digit2; 

            if (sumOfSquares % 13 == 0)
            {
                Console.WriteLine("всі двозначні числа, сума квадратів цифр яких ділиться на 13: - " + i);
            }

           int sumOfDigit = digit1 + digit2;
           int squareOfSum = sumOfDigit * sumOfDigit;

           if (squareOfSum == i)
           {
               Console.WriteLine("якщо до суми цифр числа додати квадрат цієї суми, то знову вийде шукане число: - " + i);
           }
        }
    }
    static void FourthTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 4
        Console.WriteLine("Завдання 4".PadLeft((Console.WindowWidth + "Завдання 4".Length) / 2));

        int A = 5; // Перше ціле число
        int B = 10; // Друге ціле число

        int sum = 0;
        int multiplication = 1;

        for (int i = A; i <= B; i++)
        {
            sum += i;     // Додаємо поточне число до суми
            multiplication *= i; // Множимо поточне число на добуток
        }

        Console.WriteLine($"Сума чисел від {A} до {B} включно: {sum}");
        Console.WriteLine($"Добуток чисел від {A} до {B} включно: {multiplication}");
    }
    static void FifthTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 5
        Console.WriteLine("Завдання 5".PadLeft((Console.WindowWidth + "Завдання 5".Length) / 2));

        int A = 5; // Перше ціле число
        int B = 10; // Друге ціле число

        Console.WriteLine("Цілі числа від " + A + " до " + B + " включно:");

        int count = 0; // Лічильник кількості чисел

        
        for (int i = A; i <= B; i++) // Виводимо всі цілі числа від A до B включно
        {
            Console.WriteLine(i);
            count++;
        }

        Console.WriteLine("Кількість чисел: " + count);
    }
    static void SixthTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 6
        Console.WriteLine("Завдання 6".PadLeft((Console.WindowWidth + "Завдання 6".Length) / 2));

        double pricePerKg = 105.50; // ціна за 1 кг цукерок

        Console.WriteLine("Вартість цукерок за певну кількість кілограмів:");

        for (double kg = 1.0; kg <= 2.0; kg += 0.2)
        {
            double totalCost = pricePerKg * kg;
            Console.WriteLine($"{kg.ToString("N1")} кг цукерок коштують: {totalCost.ToString("N2")}");
        }
    }
    static void SeventhTask()
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        // Завдання 7
        Console.WriteLine("Завдання 7".PadLeft((Console.WindowWidth + "Завдання 7".Length) / 2));

        int A = 1; // Початкове число
        int B = 10; // Кінцеве число

        Console.WriteLine($"Цілі числа від {A} до {B} включно з урахуванням кількості повторень:");

        for (int i = A; i <= B; i++) // Зовнішній цикл для чисел від A до B включно
        {
            for (int j = 0; j < i; j++) // Внутрішній цикл для кількості повторень числа
            {
                Console.Write(i + " "); // Виведення числа
            }
        }

       
    }
}
