
using System;

class Program
{
    static void Main ()
    {
        FirstTask();
        SecondTask();
        ThirdTask();
        FourthTask();
        FifthTask();
        SixthTask();
        SeventhTask();


    }

    //1.Знайдіть суму додатних непарних чисел менше 50.

    static void FirstTask()
    {
        //int sum = 0;
        //int num;

        //for (num = 1; num < 50; num += 2)
        //{
        //    sum += num;
        //}
        //Console.WriteLine("Сума додатних непарних чисел менше 50:  " + sum);
    }

    //2. Обчисліть суму натуральних чисел від a до b, кратних чотирьом.
    static void SecondTask() 
    {
        //try
        //{
        //    int a = 1;
        //    int sum = 0;

        //    Console.Write(" Введіть число для позначення кінця відрізка:  ");
        //    int b = Convert.ToInt32(Console.ReadLine());

        //    int i = a;

        //    while (i <= b)
        //    {
        //        if (i % 4 == 0)
        //        {
        //            sum += i;
        //        }

        //        i++;

        //    }
        //    Console.WriteLine("сумa натуральних чисел від a до b, кратних чотирьом:  " + sum);
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);

        //}
    }


    //3. Знайти: а) всі двозначні числа, сума квадратів цифр яких ділиться на 13;
    //б) всі двозначні числа, які мають наступну властивість:
    //якщо до суми цифр числа додати квадрат цієї суми, то знову вийде шукане число.

    static void ThirdTask()
    {
         //for (int i = 10; i < 100; i++)
         //{
         //   int digit1 = i / 10; 
         //   int digit2 = i % 10; 

         //   int sumOfSquares = digit1 * digit1 + digit2 * digit2; 

         //    if (sumOfSquares % 13 == 0)
         //    {
         //        Console.WriteLine("Двозначні числа, сума квадратів цифр яких ділиться на 13: " + i);
         //    }

         //   int sumOfDigit = digit1 + digit2;
         //   int squareOfSum = sumOfDigit * sumOfDigit;

         //   if (squareOfSum == i)
         //   {
         //       Console.WriteLine("Двозначне число, сума цифр та квадрат суми цифр якого знову видає число: " + i);
         //   }
         //}
    }

    //4. Дано два цілих числа A і B (A < B). Знайдіть суму та добуток усіх цілих чисел від A до B включно.


    static void FourthTask()
    {
     
        
            //try
            //{
            //    int a = new Random().Next(1, 10);
            //    Console.WriteLine("Випадкове число А:  " + a);

            //    int b = new Random().Next(a + 1, 20); 
            //    Console.WriteLine("Випадкове число B:  " + b);

            //    int sum = 0;
            //    int product = 1;

            //    for (int i = a; i < b; i++)
            //    {
            //        sum += i;
            //        product *= i;
            //    }

            //    Console.WriteLine("Сума чисел від A до B: " + sum);
            //    Console.WriteLine("Добуток чисел від A до B: " + product);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        

    }

    //5. Дано два цілих числа A і B (A < B). Вивести в порядку зростання всі цілі числа,
    //розташовані між A і B (включаючи самі числа A і B), а також число N цих чисел.

    static void FifthTask ()
    {
        //try
        //{
        //    Console.Write("Введіть ціле число А:  ");
        //    int numA = Convert.ToInt32 (Console.ReadLine());

        //    Console.Write("Введіть ціле число B:  ");
        //    int numB = Convert.ToInt32(Console.ReadLine());

        //    int number = 0;
        //    while (numA < numB)
        //    {
        //        numA++;
        //        number++;
        //        Console.WriteLine("Числа на даному проміжку:  " + numA);

        //    }
        //    Console.WriteLine("Кількість цілих чисел між A і B: " + number);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }
    //6. Наводиться реальна цифра - ціна 1 кг цукерок. Зніміть вартість 1,2, 1,4, ..., 2 кг цукерок.
    static void SixthTask ()
    {
        //try
        //{
        //    Console.Write("Введіть ціну за 1 кг:  ");
        //    int price = Convert.ToInt32 (Console.ReadLine());

        //    float kilos = 1;

        //    while (kilos <= 2)
        //    {
        //        kilos += 0.2f;
        //       float resPrice = price * kilos;
        //        Console.WriteLine ("Ціна за кожні наступні 0,2 кілограма:  " + resPrice);
        //    }


        //}

        //catch (Exception ex) 
        //{
        //    Console.WriteLine(ex.Message);
        //}

    }

    //7. Задаються натуральні числа А і В (А < В). Відображати всі цілі числа від А до Б включно;
    //При цьому кожне число має відображатися стільки разів, скільки його значення (наприклад, цифра 3 відображається 3 рази).

    static void SeventhTask ()
    {
        //int secondNumberB = new Random().Next(1, 10);
        //Console.WriteLine("Число В:  " + secondNumberB);

        //int firstNumberA = new Random().Next(1, secondNumberB);
        //Console.WriteLine("Число А:  " + firstNumberA);

        //for (int i = firstNumberA; i <=secondNumberB; i++)
        //{
         
        //    for (int j = 0; j < i; j++)
        //    {
        //        Console.WriteLine("Всі числа від А до В з потрібною к-стю повторів:  " + i);
        //    }

        //}

    }

}

