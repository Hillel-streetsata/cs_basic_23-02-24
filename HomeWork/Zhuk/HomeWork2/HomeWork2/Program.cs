using System;


class Program
{
    static void Main()
    {
        FirstTask();
        SecondTask();
        ThirdTask();
        FourthTask();
        FifthTask();
        //SixthTask();
        SeventhTask();
        EighthTask();
    }

    //1.Задається ціле число. Якщо воно позитивне, додайте до нього 1; якщо негативне, 
    //відніміть з нього 2; Якщо нуль, то замініть його на 10. Виведіть отримане число
    static void FirstTask()
    {
        //int num = new Random().Next(-5, 5);

        //if (num > 0) 
        //{
        //    num++;
        //    Console.WriteLine("Число є позитивним  " + num);
        //}
        //else if (num < 0) 
        //{
        //    num -= 2;
        //    Console.WriteLine("Число є негативним  " + num);
        //}
        //else
        //{
        //    Console.WriteLine("10");
        //}
    }

    //2. Дано три цілих числа. Знайдіть кількість додатних чисел у вихідному наборі
    static void SecondTask()
    {
        //Console.Write("Введіть число:  ");
        //int firstNum = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Введіть наступне число:  ");
        //int secondNum = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Введіть третє число: ");
        //int thirdNum = Convert.ToInt32(Console.ReadLine());

        //int count = 0;

        //if (firstNum > 0)
        //    count++;

        //if (secondNum > 0)
        //    count++;

        //if (thirdNum > 0)
        //    count++;

        //Console.WriteLine("Кількість додатних чисел: " + count);
    }

    //3. Дано три цілих числа. Знайдіть число позитивних і кількість негативних чисел у вихідному наборі. 
    static void ThirdTask()
    {
        //    Console.Write("Введіть число:  ");
        //    int num1 = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Введіть наступне число:  ");
        //    int num2 = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Введіть третє число: ");
        //    int num3 = Convert.ToInt32(Console.ReadLine());

        //    int positiv = 0;
        //    int negativ = 0;

        //    if (num1 > 0)
        //    {
        //        positiv++;
        //    }
        //    else
        //    {
        //        negativ++;
        //    }
        //    if (num2 > 0)
        //    {
        //        positiv++;
        //    }
        //    else
        //    {
        //        negativ++;
        //    }
        //    if (num3 > 0)
        //    {
        //        positiv++;
        //    }
        //    else
        //    {
        //        negativ++;
        //    }
        //    Console.WriteLine("Кількість додатних чисел: " + positiv);
        //    Console.WriteLine("Кількість негативних чисел: " + negativ);
    }

    //4. Дано дві змінні цілочисельного типу: A і B. Якщо їх значення не рівні, 
    //то призначте суму цих значень кожній змінній, а якщо вони є,
    //то привласніть змінним нульові значення.Вивести нові значення змінних A і B.
    static void FourthTask()

    {
        //int A = new Random().Next(-10, 10);
        //Console.WriteLine("Перше число:  " + A);

        //int B = new Random().Next(-10, 10);
        //Console.WriteLine("Друге число:  " + B);

        //if (A != B)
        //{ 
        //    A = A + B;
        //    B = B + A;  
        //}
        //else 
        //{
        //    A = B = 0;
        //}
        //Console.WriteLine("Нове значення змінної А:  " + A);
        //Console.WriteLine("Нове значення змінної В:  " + B);
    }

    //5/ Напишіть програму, яка перевіряє число на парність.
    static void FifthTask()
    {

        //try
        //{
        //    Console.Write("Введіть число:  ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    if (num % 2 == 0)
        //    {
        //        Console.WriteLine("Число парне");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Число непарне");
        //    }
        //}
        //catch (Exception e) 
        //{
        //    Console.WriteLine(e.Message);
        //}
    }

    //6. Одиниці довжини нумеруються наступним чином: 1 - дециметр, 2 - кілометр, 
    //3 - метр, 4 - міліметр, 5 - сантиметр.Наведено номер одиниці довжини
    //(ціле число в діапазоні 1-5) і довжину відрізка в цих одиницях(дійсне число).
    //Знайдіть довжину відрізка в метрах.

    //static double SixthTask()
    //{
    //    Console.Write("Введіть число від 1-5:  ");
    //    int number = Convert.ToInt32(Console.ReadLine());

    //    if (number < 1 || number > 5)
    //    {
    //        Console.WriteLine("Будь ласка, введіть число з проміжку 1 - 5");
    //        return 0;
    //    }
    //    Console.Write("Введіть довжину відрізка: ");
    //    double lenght = Convert.ToDouble(Console.ReadLine());

    //    double lengthInMeters = 0;

    //    switch (number)
    //    {
    //        case 1: //дециметр
    //            lengthInMeters = lenght / 10;
    //            break;
    //        case 2: //кілометр
    //            lengthInMeters = lenght * 1000;
    //            break;
    //        case 3: //метр
    //            lengthInMeters = lenght;
    //            break;
    //        case 4: //міліметр
    //            lengthInMeters = lenght / 1000;
    //            break;
    //        case 5: //сантиметр
    //            lengthInMeters = lenght / 100;
    //            break;

    //    }

    //    Console.WriteLine("Довжина відрізка в метрах:  " + lengthInMeters);

    //    return lengthInMeters;
    //}

    //7. Робот може рухатися в чотирьох напрямках(північ, захід, південь, схід) і отримувати
    //три цифрові команди: 0 - продовжувати рух, 1 - повернути ліворуч, -1 - повернути праворуч.
    // Символ C - початковий напрямок робота, а ціле число N - послана йому команда.
    //Відобразіть напрямок робота після виконання отриманої команди.
    static void SeventhTask()
    {
        //try
        //{
        //    Console.Write("Введіть початковий напрямок (N, W, S або E):  ");
        //    char direction = Convert.ToChar(Console.ReadLine());

        //    Console.Write("Введіть команду (0, 1 або -1):  ");
        //    int command = Convert.ToInt32(Console.ReadLine());

        //    char newDirection = 'C';

        //    switch (command)
        //    {
        //        case 0: //продовжити рух в тому ж напрямку
        //            newDirection = direction;
        //            break;
        //        case 1: //повернути ліворуч
        //            switch (direction)
        //            {
        //                case 'N':
        //                    newDirection = 'W'; // З Півночі на Захід
        //                    break;
        //                case 'W':
        //                    newDirection = 'S'; // З Заходу на Південь
        //                    break;
        //                case 'S':
        //                    newDirection = 'E'; // З Півдня на Схід
        //                    break;
        //                case 'E':
        //                    newDirection = 'N'; // Зі Сходу на Північ
        //                    break;
        //            }
        //            break;
        //        case -1: // повернути праворуч
        //            switch (direction)
        //            {
        //                case 'N':
        //                    newDirection = 'E'; // З Півночі на Схід
        //                    break;
        //                case 'W':
        //                    newDirection = 'N'; // Зі Заходу на Північ
        //                    break;
        //                case 'S':
        //                    newDirection = 'W'; // З Півдня на Захід
        //                    break;
        //                case 'E':
        //                    newDirection = 'S'; // Зі Сходу на Південь
        //                    break;
        //            }
        //            break;
        //    }
        //    Console.WriteLine("Новий напрямок: " + newDirection);
        //}
        //catch (Exception ex) 
        //{
        //    Console.WriteLine(ex.Message); 
        //}
    }




    //8. Дано ціле число в діапазоні 20-69, яке визначає вік(в роках).
    //Виведіть рядок опису зазначеного віку, забезпечивши правильне узгодження числа зі словом «рік», 
    //наприклад: 20 - «двадцять років», 32 - «тридцять два роки», 41 - «сорок один рік»
    static void EighthTask()
    {
        //Console.Write("Введіть число, що позначає вік від 20 до 69: ");
        //int year = Convert.ToInt32(Console.ReadLine());

        //if (year < 20 || year > 69)
        //{
        //    Console.WriteLine("Будь ласка, введіть число з проміжку 20 - 69");
        //    return;
        //}

        //else if (year == 21 || year == 31 || year == 41 || year == 51 || year == 61)
        //{
        //    Console.WriteLine(year + " рік ");
        //}
        //else if ((year >= 22 && year <= 24)
        //    || (year >= 32 && year <= 34)
        //    || (year >= 42 && year <= 44)
        //    || (year >= 52 && year <= 54)
        //    || (year >= 62 && year <= 64))
        //{
        //    Console.WriteLine(year + " роки ");
        //}
        //else
        //{
        //    Console.WriteLine(year + " років ");
        //}

    }
} 

