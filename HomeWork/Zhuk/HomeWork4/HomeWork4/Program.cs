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
        SixthTask();
        SeventhTask();
    }

    //1. Створіть програму, яка використовує цикл while для виведення на 
    //екран таблиці множення для введеного користувачем числа.
    static void FirstTask()
    {
        //try
        //{
        //    Console.Write("Введіть число: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    int i = 1;

        //    while (i <= 10)
        //    {
        //        Console.WriteLine(num + " * " + i + " = " + (num * i));
        //        i++;
        //    }
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}

    }

    //2. Напишіть програму, яка використовує цикл do-while для запиту
    //у користувача числа, поки він не введе правильне значення.

    static void SecondTask() 
    {
        //int number;

        //do
        //{
        //    Console.WriteLine("Введіть число на проміжку від -5 до 5:");
        //} while (!int.TryParse(Console.ReadLine(), out number ) || number < -5 || number > 5); //якщо не вдалося перетворити у ціле число,
                                                                                                 //або не відповідає проміжку, тоді false і все починається спочатку
        //Console.WriteLine("Ви ввели правильне число: " + number);
    }

    // Реалізуйте програму, яка використовує вкладені цикли 
    //для створення піраміди з зірочок на екрані.
    static void ThirdTask()
    {
        //int rows;

        //Console.Write("Введіть кількість рядків у піраміді: ");
        //while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
        //{
        //    Console.WriteLine("Неправильне значення. Будь ласка, введіть додатнє ціле число: ");
        //}

        //for (int i = 1; i <= rows; i++)


        //{
        //    for (int j = 1; j <= rows - i; j++)
            
        //    {
            
                
        //        Console.Write(" ");
        //    }
        //    for (int k = 1; k <= 2 * i - 1; k++)
        //    {

        //        Console.Write("*");
        //    }

        //    Console.WriteLine(); 
        //}


    }

    //4. Створіть програму, яка знаходить суму всіх цифр в заданому числі, 
    //використовуючи цикл foreach. Може бути як 9, або 181547785. Программа має це прорахувати.

    static void FourthTask ()
    {
        //try
        //{
        //    Console.Write("Введіть число: ");
        //    int yourNumber = Convert.ToInt32(Console.ReadLine());

        //    string numberAsString = yourNumber.ToString();

        //    int count = 0;
        //    int sum = 0;

        //    foreach (char digitChar in numberAsString)
        //    {
        //        int digit = int.Parse(digitChar.ToString());
        //        count++;
        //        Console.WriteLine("Цифра #{0}: {1}", count, digit);
        //        sum += digit;
        //    }
        //    Console.WriteLine("Кількість елементів в масиві: {0}", count);
        //    Console.WriteLine("Сума елементів: " + sum);
        //}

        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }


    //5. Напишіть програму, яка використовує цикл for для знаходження
    //факторіалу введеного користувачем числа.

    static void FifthTask()
    {
    //    try
    //    {
    //        Console.Write("Введіть число: ");
    //        int numForFactorial = Convert.ToInt32(Console.ReadLine());

    //        if (numForFactorial < 0)
    //        {
    //            Console.WriteLine("Факторіал визначений лише для додатніх чисел.");
    //            return; 
    //        }

    //        int factorial = 1;

    //        for(int i = 1; i <= numForFactorial; i++)
    //        {
    //            factorial *= i;
    //            Console.WriteLine("Факторіал вашого числа:  " + factorial);
    //        }
    //    }
    //    catch (Exception ex)
    //    { 
    //        Console.WriteLine(ex.Message); 
    //    }
        
    }


    //6.Створіть програму, яка використовує цикл do-while для гри в кубики 
    //з користувачем, доки він не вирішить припинити гру.

    static void SixthTask()
    {
        //int randomDiceNum1 = new Random().Next(1, 7);
        //int randomDiceNum2 = new Random().Next(1, 7);

        //int count = 0;
        //int sum = 0; 

        //do
        //{
        //    Console.WriteLine("Натисніть Enter, щоб кинути кубики:");
        //    Console.ReadLine();

        //    int currentSum = randomDiceNum1 + randomDiceNum2; 

        //    Console.WriteLine($"Ви кинули кубики: {randomDiceNum1} та {randomDiceNum2}");
        //    Console.WriteLine($"Сума: {currentSum}");

        //    sum += currentSum; 
        //    count++; 
        //}
        //while (Console.ReadKey().Key != ConsoleKey.S);

        //Console.WriteLine($"\nГра завершена. Загальна сума: {sum}. Кількість кидків: {count}");

    }


    //7. Реалізуйте програму, яка використовує цикл foreach для
    //пошуку найбільшого та найменшого значень у списку чисел.Тут Вам також самостійно
    //треба дізнатися за List<int> (проходити ми будемо його трохи пізніше, а ви додатково познайомитесь зараз))))


    static void SeventhTask()
    {
    //    List<int> numbers = new List<int> { 19, 45, 8, 3, 74 };

    //    int min = numbers[0];
    //    int max = numbers[0];

    //    foreach (int number in numbers)
    //    {
    //        if (number < min)
    //        {
    //            min = number;
    //        }

    //        if (number > max)
    //        {
    //            max = number;
    //        }

    //        Console.WriteLine("Найменше значення: " + min);
    //        Console.WriteLine("Найбільше значення: " + max);
    //    }
    }

}
