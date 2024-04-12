using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        // 7 Слайд
        FirstTask_7();
        SecondTask_7();
        ThirdTask_7();
        FourthTask_7();
        FifthTask_7();
        SixthTask_7();
        SeventhTask_7();
        EigthTask_7();

        // 10 Слайд
        FirstTask_10();
        SecondTask_10();
        ThirdTask_10();
        FourthTask_10();
        FifthTask_10();
        SixthTask_10();
        SeventhTask_10();
        EigthTask_10();
        NinethTask_10();
    }

    static void FirstTask_7()
    {
        Console.WriteLine("Перший слайд".PadLeft((Console.WindowWidth + "Перший слайд".Length) / 2));
        Console.WriteLine();

        // Завдання 1
        Console.WriteLine("Завдання 1".PadLeft((Console.WindowWidth + "Завдання 1".Length) / 2));

        int[] numbers = new int[8];

        numbers[0] = 37;
        numbers[1] = 0;
        numbers[2] = 50;
        numbers[3] = 46;
        numbers[4] = 34;
        numbers[5] = 46;
        numbers[6] = 0;
        numbers[7] = 13;


        Console.WriteLine("Елементи масиву:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void SecondTask_7()
    {

        // Завдання 2
        Console.WriteLine("Завдання 2".PadLeft((Console.WindowWidth + "Завдання 2".Length) / 2));


        int[] heights = new int[12]; // Оголошення масиву


        Random random = new Random(); // Рандомні числа


        for (int i = 0; i < heights.Length; i++) // Випадкове заповнення числами від 163 до 191
        {
            heights[i] = random.Next(163, 191);
        }


        Console.WriteLine("Значення висоти:");

        foreach (int height in heights)
        {
            Console.WriteLine(height);
        }
    }
    static void ThirdTask_7()
    {

        // Завдання 3
        Console.WriteLine("Завдання 3".PadLeft((Console.WindowWidth + "Завдання 3".Length) / 2));


        int[] array = new int[10];


        for (int i = 1; i < array.Length; i++)
        {
            array[i] = i + 1;
        }


        Console.WriteLine("Парні елементи:");
        for (int i = 1; i < array.Length; i += 2)
        {
            Console.WriteLine($"елемент {i}: {array[i]}");
        }

    }
    static void FourthTask_7()
    {

        // Завдання 4
        Console.WriteLine("Завдання 4".PadLeft((Console.WindowWidth + "Завдання 4".Length) / 2));


        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Оголошення масивів


        Console.WriteLine("Елементи масиву в зворотному порядку:"); // Виведення масивів в зворотньому порядку
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }


    }
    static void FifthTask_7()
    {

        // Завдання 5
        Console.WriteLine("Завдання 5".PadLeft((Console.WindowWidth + "Завдання 5".Length) / 2));


        int[] array = new int[12]; // Оголошення масиву


        Console.WriteLine("Введіть значення для масиву:"); // Заповнення масивів значеннями

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                array[i] = value;
            }
            else
            {
                Console.WriteLine("Неправильне значення. Будь ласка, введіть ціле ЧИСЛО.");
                i--;
            }
        }


        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }


        Console.WriteLine($"Сума значень масиву: {sum}");



    }
    static void SixthTask_7()
    {

        // Завдання 6
        Console.WriteLine("Завдання 6".PadLeft((Console.WindowWidth + "Завдання 6".Length) / 2));



        double[] resistances = new double[20]; // Оголошення масиву


        Console.WriteLine("Введіть значення опорів:"); // Введення значення

        for (int i = 0; i < resistances.Length; i++)
        {
            Console.Write($"Опір {i + 1}: ");
            if (double.TryParse(Console.ReadLine(), out double resistance))
            {
                resistances[i] = resistance;
            }
            else
            {
                Console.WriteLine("Некоректне значення. Будь ласка, введіть дійсне число.");
                i--;
            }
        }


        double totalResistance = 0;
        foreach (double resistance in resistances) // Обчислення загального опору ланцюга
        {
            totalResistance += 1 / resistance;
        }
        totalResistance = 1 / totalResistance;


        Console.WriteLine($"Загальний опір ланцюга: {totalResistance}");
    }
    static void SeventhTask_7()
    {

        // Завдання 7
        Console.WriteLine("Завдання 7".PadLeft((Console.WindowWidth + "Завдання 7".Length) / 2));


        int[] array = { 1, 2, 3, 4, 5 };


        int sum = 0;
        foreach (int element in array)
        {
            sum += element;
        }


        if (sum >= 0)  // Перевірка, чи є сума невід'ємним числом
        {
            Console.WriteLine("Сума елементів масиву є невід'ємним числом.");
        }
        else
        {
            Console.WriteLine("Сума елементів масиву є від'ємним числом.");
        }
    }
    static void EigthTask_7()
    {

        // Завдання 8
        Console.WriteLine("Завдання 8".PadLeft((Console.WindowWidth + "Завдання 8".Length) / 2));

        // Оголошення масиву та змінних
        int[] places = new int[10];
        Random rnd = new Random();
        int temp;
        int index1;
        int index2;

        // Заповнення масиву та їх виведення
        Console.WriteLine("Перший масив:");
        for (int i = 0; i < places.Length; i++)
        {
            places[i] = rnd.Next(1, 100);
            Console.WriteLine("\t" + places[i]);
        }

        // Обмін місцями другого та п'ятого елементів масиву
        temp = places[1];
        places[1] = places[4];
        places[4] = temp;

        // Виведення масиву після обміну
        Console.WriteLine("Масив після обміну другого та п'ятого елементів:");
        foreach (int place in places)
        {
            Console.WriteLine("\t\t" + place);
        }

        // Обмін місцями m-го та n-го елементів масиву
        index1 = rnd.Next(0, places.Length);
        index2 = rnd.Next(0, places.Length);
        temp = places[index1];
        places[index1] = places[index2];
        places[index2] = temp;

        // Виведення масиву після другого обміну
        Console.WriteLine("Масив після обміну елементів за індексами:");
        foreach (int place in places)
        {
            Console.WriteLine("\t" + place);
        }
    }

    static void FirstTask_10()
    {
        Console.WriteLine("Другий слайд".PadLeft((Console.WindowWidth + "Другий слайд".Length) / 2));
        Console.WriteLine();

        // Завдання 1
        Console.WriteLine("Завдання 1".PadLeft((Console.WindowWidth + "Завдання 1".Length) / 2));


        Random random = new Random(); // Рандомні числа


        int[] array = new int[10]; // Масив з 10 елементами


        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-10, 11);
        }


        Console.WriteLine("Масив з випадковими числами в інтервалі [-10..10]:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void SecondTask_10()
    {

        // Завдання 2
        Console.WriteLine("Завдання 2".PadLeft((Console.WindowWidth + "Завдання 2".Length) / 2));

        // Масив 3х3
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Відображення елемента, розташованого в правому верхньому кутку масиву 
        int UpRight = array[0, array.GetLength(1) - 1];
        Console.WriteLine("Елемент, розташований в правому верхньому кутку масиву: " + UpRight);

        // Відображення елемента, розташованого в лівому нижньому кутку масиву 
        int LowLeft = array[array.GetLength(0) - 1, 0];
        Console.WriteLine("Елемент, розташований в лівому нижньому кутку масиву: " + LowLeft);

    }
    static void ThirdTask_10()
    {

        // Завдання 3
        Console.WriteLine("Завдання 3".PadLeft((Console.WindowWidth + "Завдання 3".Length) / 2));


        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12},
            {13, 14, 15}
        };

        // а) Заміна значення будь-якого елемента п'ятого рядка масиву числом 1949
        int replace = 4;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[replace, column] = 1949;
        }

        // б) Заміна значення будь-якого елемента масиву числом 'a'
        int newValue = 99; // Приклад нового значення
        int rowIndex = 2; // Приклад індексу рядка 
        int columnIndex = 1; // Приклад індексу стовпця 
        array[rowIndex, columnIndex] = newValue;

        // Виведення масиву на екран для перевірки
        Console.WriteLine("Масив після заміни:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

    }
    static void FourthTask_10()
    {

        // Завдання 4
        Console.WriteLine("Завдання 4".PadLeft((Console.WindowWidth + "Завдання 4".Length) / 2));


        int[,] multiplication = new int[9, 9];

        // Заповнення масиву таблицією множення
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                multiplication[i, j] = (i + 1) * (j + 1);
            }
        }

        // Вивод таблиці на екран
        Console.WriteLine("Таблиця множення:");
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(multiplication[i, j] + "\t");
            }
            Console.WriteLine();

        }
    }
    static void FifthTask_10()
    {

        // Завдання 5
        Console.WriteLine("Завдання 5".PadLeft((Console.WindowWidth + "Завдання 5".Length) / 2));


        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        // а) Відображення всіх елементів третього рядка масиву, починаючи з останнього елемента цього рядка
        int row = 2; // третій рядок (індексація починається з 0)
        Console.WriteLine("Елементи третього рядка масиву, починаючи з останнього:");
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            Console.Write(array[row, j] + " ");
        }
        Console.WriteLine();

        // б) Відображення всіх елементів k-го стовпця масиву, починаючи з нижнього елемента цього стовпця
        int column = 1; // k-й стовпець 
        Console.WriteLine($"Елементи {column + 1}-го стовпця масиву, починаючи з нижнього:");
        for (int i = array.GetLength(0) - 1; i >= 0; i--)
        {
            Console.Write(array[i, column] + " ");
        }
        Console.WriteLine();
    }
    static void SixthTask_10()
    {

        // Завдання 6
        Console.WriteLine("Завдання 6".PadLeft((Console.WindowWidth + "Завдання 6".Length) / 2));


        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        // а) Сума всіх елементів третього рядка масиву
        int Row = 2; // третій рядок 
        int SumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow += array[Row, j];
        }
        Console.WriteLine("Сума елементів третього рядка масиву: " + SumRow);

        // б) Сума всіх елементів s-го стовпця масиву
        int Column = 1; // s-й стовпець 
        int SumColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            SumColumn += array[i, Column];
        }
        Console.WriteLine($"Сума елементів {Column + 1}-го стовпця масиву: " + SumColumn);


    }
    static void SeventhTask_10()
    {

        // Завдання 7
        Console.WriteLine("Завдання 7".PadLeft((Console.WindowWidth + "Завдання 7".Length) / 2));

        
        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        // а) Сума всіх елементів другого стовпця масиву
        int Column = 1; // другий стовпець 
        int SumColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            SumColumn += array[i, Column];
        }
        Console.WriteLine($"Сума елементів {Column + 1}-го стовпця масиву: " + SumColumn);

        // б) Сума всіх елементів k-го рядка масиву
        int Row = 2; // k-й рядок 
        int SumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow += array[Row, j]; // Виправлено Column на j
        }
        Console.WriteLine("Сума елементів " + (Row + 1) + "-го рядка масиву: " + SumRow);
    }
    static void EigthTask_10()
    {

        // Завдання 8
        Console.WriteLine("Завдання 8".PadLeft((Console.WindowWidth + "Завдання 8".Length) / 2));


        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        // а) Сума квадратів елементів другого рядка масиву
        int Row = 1; // другий рядок 
        int SumSquareRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int element = array[Row, j];
            SumSquareRow += element * element;
        }
        Console.WriteLine("Сума квадратів елементів другого рядка масиву: " + SumSquareRow);

        // б) Сума квадратів елементів c-го стовпця масиву
        int Column = 2; // третій стовпець 
        int SumSquareColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int element = array[i, Column];
            SumSquareColumn += element * element;
        }
        Console.WriteLine($"Сума квадратів елементів {Column + 1}-го стовпця масиву: " + SumSquareColumn);

    }
    static void NinethTask_10()
    {

        // Завдання 9
        Console.WriteLine("Завдання 9".PadLeft((Console.WindowWidth + "Завдання 9".Length) / 2));

        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        // а) Знаходження максимального елемента масиву
        int MaxElement = array[0, 0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > MaxElement)
                {
                    MaxElement = array[i, j];
                }
            }
        }
        Console.WriteLine("Максимальний елемент масиву: " + MaxElement);

        // б) Знаходження мінімального елемента масиву
        int MinElement = array[0, 0];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < MinElement)
                {
                    MinElement = array[i, j];
                }
            }
        }
        Console.WriteLine("Мінімальний елемент масиву: " + MinElement);

        // в) Знаходження координат мінімального елемента масиву
        int MinRow = 0, MinColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == MinElement)
                {
                    MinRow = i;
                    MinColumn = j;
                }
            }
        }
        Console.WriteLine("Координати мінімального елемента масиву: [" + MinRow + ", " + MinColumn + "]");

        // г) Знаходження координат максимального елемента масиву
        int MaxRow = 0, MaxColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == MaxElement)
                {
                    MaxRow = i;
                    MaxColumn = j;
                    break; // Зупиняємо пошук після першого входження максимального елемента
                }
            }
        }
        Console.WriteLine("Координати максимального елемента масиву: [" + MaxRow + ", " + MaxColumn + "]");


    }
}


