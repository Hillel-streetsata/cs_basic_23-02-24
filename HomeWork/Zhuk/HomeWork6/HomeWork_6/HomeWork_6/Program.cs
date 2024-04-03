﻿
using System;


class Program
{
    static void Main()
    {
        //Одновимірні масиви

        FirstTask();
        SecondTask();
        ThirdTask();
        FourthTask();
        FifthTask();
        SixthTask();
        SeventhTask();
        EighthTask();


        //Двовимірні масиви

        FirstTask2();
        SecondTask2();
        ThirdTask2();
        FourthTask2();
        FifthTask2();
        SixthTask2();
        SeventhTask2();
        EighthTask2();
        NinthTask2();
    }

    // 1. Заповніть масив з восьми елементів наступними значеннями: перший елемент масиву - 37, другий - 0, 
    //третій - 50, четвертий - 46, п'ятий - 34, шостий - 46, сьомий - 0, а восьмий - 13. Відобразити на екрані.

    static void FirstTask()
    {
    //    int[] firstArr = { 37, 0, 50, 46, 34, 46, 0, 13 };


    //    foreach (int element in firstArr)
    //    {
    //        Console.WriteLine("Заданий масив: " + element);
    //    }
    }

    //2. Масив призначений для зберігання значень висоти дванадцяти чоловік.  Використовуючи випадкові числа,
    // заповніть масив цілими значеннями в діапазоні від 163 до 190 включно.

    static void SecondTask()
    {
        //int[] secondArr = new int[12];

        //Random random = new Random();

        //for (int i = 0; i < secondArr.Length; i++)
        //{
        //    secondArr[i] = random.Next(163, 191);
        //}

        //foreach (int height in secondArr)

        //{
        //    Console.WriteLine("Висота дванадцяти чоловік: " +height);
        //}
    }

    //3. Присвоюються початкові значення від 1, 2, 3,... , до 10 елементам масиву і відобразити елементи масиву з парним індексом.
    static void ThirdTask()
    {
        //int[] thirdArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //for (int i = 0; i < thirdArr.Length; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.WriteLine("Парні індекси масиву:  " + thirdArr[i]);
        //    }
        //}

    }

    //4. Створіть масив розмірністю 10 елементів, відобразіть всі елементи масиву в зворотному порядку.

    static void FourthTask()
    {
        //int[] fourthArr = new int[10];
        //Random random = new Random();


        //for (int i = 0; i < fourthArr.Length; i++)
        //{
        //    fourthArr[i] = random.Next(1, 20);

        //    Console.WriteLine("Масив: " + fourthArr[i]);

        //}


        //for (int i = fourthArr.Length - 1; i >= 0; i--)
        //{

        //    Console.WriteLine("Масив у зворотному порядку: " + fourthArr[i]);
        //}
    }

    //5. Створіть масив розмірністю 12 елементів, підсумуйте значення. Підсумовування 
    //робиться в тілі петлі for. Значення, які використовуються в якості початкових значень для масиву A, вводяться в програму користувачем з клавіатури.

    static void FifthTask()
    {
        //try
        //{
        //    int[] fifthArr = new int[12];

        //    for (int i = 0; i < fifthArr.Length; i++)
        //    {
        //        Console.Write($"Введіть елементи масиву. Елемент {i + 1}: ");

        //        int value;
        //        if (int.TryParse(Console.ReadLine(), out value))
        //        {
        //            fifthArr[i] = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Введене значення некоректне. Будь ласка, введіть ціле число.");
        //            i--;
        //        }
        //    }


        //    foreach (int element in fifthArr)
        //    {
        //        Console.Write("\nВведений масив:  " + element + "\n ");
        //    }

        //    int sum = 0;

        //    for (int i = 0; i < fifthArr.Length; i++)
        //    {
        //        sum += fifthArr[i];

        //    }
        //    Console.WriteLine("\nСума елементів масиву: " + sum);

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);

        //}

    }

    //6. У масиві зберігається інформація про опір кожного з 20 елементів електричного кола. Всі елементи з'єднуються паралельно. 
    //Визначити загальний опір ланцюга. (1 / R(1) + 1 / R(2)… 1 / R(n))


    static void SixthTask()

    {
        //try
        //{
        //    double[] sixthArr = new double[20];

        //    Console.WriteLine("Введіть елементи масиву:  ");

        //    for (int i = 0; i < sixthArr.Length; i++)
        //    {
        //        Console.Write($"елемент {i + 1}: ");

        //        double value;
        //        if (double.TryParse(Console.ReadLine(), out value))
        //        {
        //            sixthArr[i] = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("введене значення некоректне. будь ласка, введіть ціле число.");
        //            i--;
        //        }
        //    }
        //    Console.WriteLine("введений масив: ");

        //    foreach (int element in sixthArr)
        //    {
        //        Console.Write( element + " ");
        //    }

        //    double rTotal = 0;
        //    foreach (double r in sixthArr)
        //    {
        //        rTotal += 1 / r;
        //    }

        //    Console.WriteLine("\nЗагальний опір ланцюга: " + rTotal);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

    }

    //7. З'ясуємо, чи правда, що сума елементів масиву є невід'ємним числом.

    static void SeventhTask()
    {
        //int[] seventhArr = new int[10];

        //Random random = new Random();
        //Console.WriteLine("Масив: ");


        //for (int i = 0; i < seventhArr.Length; i++)
        //{
        //    seventhArr[i] = random.Next(-10, 10);

        //    Console.WriteLine(seventhArr[i]);

        //}

        //int sumOfArray = 0;
        //foreach (int element in seventhArr)
        //{
        //    sumOfArray += element;
        //}
        //Console.WriteLine("Сума елементів масиву:  " + sumOfArray);

        //if (sumOfArray >= 0)
        //{
        //    Console.WriteLine("Сума елементів масиву є невід'ємною");
        //}
        //else
        //{
        //    Console.WriteLine("Сума елементів масиву є від'ємною");
        //}


    }

    //8. Заданий масив.Поміняйте місцями: а) другий і п'ятий елементи; б) m-й і n-й елементи

    static void EighthTask()
    {
        //int[] eighthArr = { 7, -2, 6, 4, 3, -6, 0, -1, 5, 0 };

        //foreach (int element in eighthArr)
        //{
        //    Console.Write(element + " ");
        //}

        //int secondElement = eighthArr[1];

        //eighthArr[1] = eighthArr[4];
        //eighthArr[4] = secondElement;

        //Console.WriteLine("\nМасив після заміни:");
        //foreach (int element in eighthArr)
        //{
        //    Console.Write(element + " ");
        //}

        //Console.Write("\nВведіть число на проміжку від 0 до 9 : ");
        //int m = Convert.ToInt32(Console.ReadLine());
        //if (m < 0 || m > 9)
        //{
        //    Console.WriteLine("Ви ввели некоректне число");
        //    return;
        //}

        //Console.Write("\nВведіть число на проміжку від 0 до 9 : ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //if (n < 0 || n > 9)
        //{
        //    Console.WriteLine("Ви ввели некоректне число");
        //    return;
        //}

        //if (m >= eighthArr.Length || n >= eighthArr.Length || m < 0 || n < 0)
        //{
        //    Console.WriteLine("\nІндекси виходять за межі масиву");
        //    return;
        //}
        //int mElement = eighthArr[m];
        //eighthArr[m] = eighthArr[n];
        //eighthArr[n] = mElement;

        //Console.WriteLine("\nМасив після заміни:");
        //foreach (int element in eighthArr)
        //{
        //    Console.Write(element + " ");
        //}

    }


    //Двовимірні масиви


    //1. Заповніть масив з 10 елементів випадковими числами в інтервалі [-10..10]
    static void FirstTask2()
    {
        //int[,] randomArr = new int [5, 2];
        //Random random = new Random();

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        randomArr[i, j] = random.Next(-10, 11);
        //    }

        //}
        //Console.WriteLine("Масив:");
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 2; j++)
        //    {
        //        Console.Write(randomArr[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
    }

    //2. Заданий двовимірний масив. а) Відображення елемента, розташованого в правому верхньому кутку масиву. 
    // б) Відображення елемента, розташованого в лівому нижньому кутку масиву.

    static void SecondTask2()
    {
        //int[,] nextArr = new int[3, 3]
        //{
        //    {1, 4, 7},
        //    { 2, 5, 8},
        //    { 3, 6, 9}
        //};

        //int element = nextArr[0, 2];
        //int nextElement = nextArr[2, 0];

        //Console.WriteLine("Правий верхній елемент: " + element);
        //Console.WriteLine("Лівий нижній елемент:  " + nextElement);

    }

    //3. Складіть програму: а) Заміна значення будь-якого елемента п'ятого рядка двовимірного масиву числом 1949; 
    //б) який замінює значення будь-якого елемента двовимірного масиву числом a.

    static void ThirdTask2()
    {
        //try
        //{
        //    int[,] thirdTaskArr = new int[6, 6];
        //    Random rnd = new Random();

        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            thirdTaskArr[i, j] = rnd.Next(-20, 20);
        //        }

        //    }
        //    Console.WriteLine("\nМасив:");
        //    for (int i = 0; i < 6; i++)
        //    {
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(thirdTaskArr[i, j] + "\t ");
        //        }
        //        Console.WriteLine();
        //    }

        //    thirdTaskArr[4, 2] = 1949;


        //    int a = 666;

        //    int aElementХ = 0;
        //    int aElementY = 0;

        //    Console.WriteLine("Введіть рядок елементу масиву, який замінити на 'а' (від 0 до 5):" + aElementХ);
        //    aElementХ = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Введіть стовпець елементу масиву, який замінити на 'а' (від 0 до 5):" + aElementY);
        //    aElementY = int.Parse(Console.ReadLine());

        //    thirdTaskArr[aElementХ, aElementY] = a;


        //    Console.WriteLine("Новий масив:  ");
        //    for (int i = 0; i < 6; i++)
        //    {
        //        Console.WriteLine(" ");
        //        for (int j = 0; j < 6; j++)
        //        {
        //            Console.Write(thirdTaskArr[i, j] + "\t ");

        //        }

        //    }

        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}
    }
    


    // 4. Заповніть двовимірний масив результатами таблиці множення(в першому рядку слід записати добутки кожного
    //з чисел від 1 до 9 на 1, в останньому - 2, ..., а в останньому - 9).


    static void FourthTask2()
    {
        //int[,] multiplicationArr =new int [9, 9];

        //for (int i = 0; i < 9; i++)
        //{
        //    for (int j = 0; j < 9; j++)
        //    {
        //        multiplicationArr[i, j] = (i + 1) * (j + 1);

        //    }
        //}

        //Console.WriteLine("Таблиця множення:  ");
        //for (int i = 0;i < 9; i++)
        //{
        //    for (int j = 0;j < 9; j++)
        //    {
        //        Console.Write(multiplicationArr[i, j] + "\t");
        //    }
        //    Console.WriteLine();
        //}

    }

    //5.Задано двовимірний масив. Відображення: а) всіх елементів третього рядка масиву, починаючи з останнього 
    //елемента цього рядка; б) Всі елементи k-го стовпця масиву, починаючи з нижнього елемента цього стовпця.

    static void FifthTask2()
    {
        //int[,] reflectionArr = new int[4, 4]
        //{
        //    {7, 8, 9, 1 },
        //    {6, 5, 4, 3 },
        //    {3, 2, 1, 4 },
        //    {4, 6, 5, 1 }
        //};

        //Console.WriteLine("\nМасив:");
        //for (int i = 0; i < 4; i++)
        //{
        //    for (int k = 0; k < 4; k++)
        //    {
        //        Console.Write(reflectionArr[i, k] + "\t ");
        //    }
        //    Console.WriteLine();
        //}

        //Console.WriteLine("\nЕлементи третього рядка, починаючи з останнього:  ");
        //for (int i = reflectionArr.GetLength(1) - 1; i >= 0; i--)
        //{
        //    Console.Write(reflectionArr[2, i] + " ");
        //}

        //int kColumn = 1; 
        //Console.WriteLine("\n Елементи стовпця, починаючи з останнього:  ");
        //for (int row = reflectionArr.GetLength(0) - 1; row >= 0; row--)
        //{
        //    Console.Write(reflectionArr[row, kColumn] + " ");
        //}
    }

    //6.Заданий двовимірний масив. Визначити: а) Сума всіх елементів третього рядка масиву; б) Сума всіх елементів s-го стовпця масиву.

    static void SixthTask2()
    {


        //int[,] sumArr = new int[4, 4];
        //Random random = new Random();

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        sumArr[i, j] = random.Next(-20, 20);
        //    }
        //}

        //Console.WriteLine(" Масив:  ");
        //{
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            Console.Write(sumArr[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //int sum = 0;

        //Console.WriteLine();
        //for ( int i = 0; i <4; i++)
        //{
        //    sum += sumArr[2, i];
        //}
        //Console.WriteLine("Сума третього рядка:  " + sum);

        //int sColumnIndex = new Random().Next(0, 4);
        //Console.WriteLine("s-рядок: " + sColumnIndex);

        //int sSum = 0;

        //Console.WriteLine();
        //for ( int i = 0; i < 4; i++)
        //{
        //    sSum += sumArr[i, sColumnIndex]; 
        //}
        //Console.WriteLine("Сума s-рядка:  " + sSum);
    }

    //7. Задано двовимірний масив. Визначити: а) сума всіх елементів другого стовпця масиву; б) Сума всіх елементів k-го рядка масиву.
    static void SeventhTask2()
    {

        //int[,] secondSumArr = new int[4, 4];
        //Random random = new Random();

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        secondSumArr[i, j] = random.Next(-20, 20);
        //    }
        //}

        //Console.WriteLine(" Масив:  ");
        //{
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            Console.Write(secondSumArr[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //int arrColumnSum = 0;

        //for (int i = 0;i < 4; i++)
        //{
        //    arrColumnSum += secondSumArr[i, 1];
        //}
        //Console.WriteLine("Сума другого стовпця:  " + arrColumnSum);

        //int kRow = new Random().Next(0, 4);
        //Console.WriteLine( "k-рядок: " + kRow);

        //int kArrSum = 0;

        //for (int i = 0; i< 4 ; i++)
        //{
        //    kArrSum += secondSumArr[kRow, i];

        //}

        //Console.WriteLine("Сума  k-рядка: " + kArrSum);
    }

    //8. Задано двовимірний масив. Визначити: а) Сума квадратів елементів другого рядка масиву; б) Сума квадратів елементів c-го стовпця масиву.
    static void EighthTask2()
    {
        //int[,] sumOfSquaresArr = new int[4, 4];
        //Random random = new Random();

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        sumOfSquaresArr[i, j] = random.Next(-20, 20);
        //    }
        //}

        //Console.WriteLine(" Масив:  ");
        //{
        //    for (int i = 0; i < 4; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            Console.Write(sumOfSquaresArr[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //int squareSum = 0;

        //for (int i = 0; i < 4; i++)
        //{
        //    int element = sumOfSquaresArr[1, i];
        //    squareSum += element * element;
        //}
        //Console.WriteLine("Сума квадратів елементів другого рядка: " + squareSum);

        //int cSumColumn = 0;
        //int cColumn = new Random().Next(0,4);
        //Console.WriteLine("с-стовпець: " + cColumn);

        //for (int i = 0;i < 4;i++)
        //{
        //    int element = sumOfSquaresArr[i, cColumn];
        //    cSumColumn += element * element;
        //}
        //Console.WriteLine("Сума квадратів елементів с-стовпця: " + cSumColumn);
    }


    //9. Задано двовимірний масив. Визначити: а) Максимальний елемент масиву; б) Мінімальний елемент масиву;
    //в) Координати мінімального елемента масиву.Якщо елементів з мінімальним значенням кілька, то необхідно знайти координати самого нижнього і правого з них;
    //г) Координати максимального елемента масиву.Якщо елементів з максимальним значенням кілька, то необхідно знайти координати самого верхнього і крайнього з них.

    static void NinthTask2()
    {

        //int[,] lastArr = new int[3, 3];
        //Random random = new Random();

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        lastArr[i, j] = random.Next(-10, 10);
        //    }
        //}

        //Console.WriteLine(" Масив:  ");
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        for (int j = 0; j < 3; j++)
        //        {
        //            Console.Write(lastArr[i, j] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //int max = lastArr[0, 0];

        //int maxX = 0;
        //int maxY =0;

        //int highestX = 0;
        //int highestY = 0;


        //for (int i = 0;i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        if (max < lastArr[i, j])
        //        {
        //            max = lastArr[i, j];
        //            maxX = i;
        //            maxY = j;
        //        }
        //    }
        //}

        //for (int i = 0; i < 3; i++)
        //{
        //    for(int j = 0;j < 3; j++)
        //    {
        //        if(  lastArr[i, j] == max )
        //        {
        //            if(i > highestX || (i == highestX && j > highestY))
        //            {
        //                highestX = i;
        //                highestY = j;
        //            }
        //        }
        //    }
        //}
        //Console.WriteLine($"Максимальний елемент: {max}, Координати: [{maxX}] [ {maxY}]");
        //Console.WriteLine($"Координати крайнього верхнього максимального елемента:  [{highestX} ][ {highestY}]");



        //int lowestX = 0;
        //int lowestY = 0;

        //int minX = 0;
        //int minY = 0;

        //int min = lastArr[0, 0];
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        if (min > lastArr[i, j])
        //        {
        //            min = lastArr[i, j];
        //            minX = i;
        //            minY = j;
        //        }
        //    }
        //}

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0;j < 3; j++)
        //    {
        //        if (lastArr[i, j] == min)
        //        {
        //            if (i > lowestX || (i == lowestX && j > lowestY))
        //            {
        //                lowestX = i;
        //                lowestY = j;
        //            }
        //        }
        //    }
        //}

        //Console.WriteLine($"Мінімальний елемент: {min}, Координати: [{minX}] [ {minY}]");
        //Console.WriteLine($"Координати найнижчого та найправішого мінімального елемента:  [{lowestX} ][ {lowestY}]");


    }


}
