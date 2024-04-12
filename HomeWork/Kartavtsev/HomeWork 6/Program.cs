namespace HW6
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;

        
        FirstTask_7();
        SecondTask_7();
        ThirdTask_7();
        FourthTask_7();
        FifthTask_7();
        SixthTask_7();
        SeventhTask_7();
        EigthTask_7();

        
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
        Console.WriteLine("Перший слайд");
        Console.WriteLine();

        // Завдання 1
        Console.WriteLine("Завдання 1");

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
        Console.WriteLine("Завдання 2");


        int[] heights = new int[12]; 


        Random random = new Random(); 


        for (int i = 0; i < heights.Length; i++)
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
        Console.WriteLine("Завдання 3");


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
        Console.WriteLine("Завдання 4");


        int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 


        Console.WriteLine("Елементи масиву в зворотному порядку:"); 
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i]);
        }


    }
    static void FifthTask_7()
    {

        // Завдання 5
        Console.WriteLine("Завдання 5");


        int[] array = new int[12]; 

        Console.WriteLine("Введіть значення для масиву:"); 

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
        Console.WriteLine("Завдання 6");



        double[] resistances = new double[20]; 


        Console.WriteLine("Введіть значення опорів:"); 

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
        foreach (double resistance in resistances) 
        {
            totalResistance += 1 / resistance;
        }
        totalResistance = 1 / totalResistance;


        Console.WriteLine($"Загальний опір ланцюга: {totalResistance}");
    }
    static void SeventhTask_7()
    {

        // Завдання 7
        Console.WriteLine("Завдання 7");


        int[] array = { 1, 2, 3, 4, 5 };


        int sum = 0;
        foreach (int element in array)
        {
            sum += element;
        }


        if (sum >= 0)  
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
        Console.WriteLine("Завдання 8");

        
        int[] places = new int[10];
        Random rnd = new Random();
        int temp;
        int index1;
        int index2;

        
        Console.WriteLine("Перший масив:");
        for (int i = 0; i < places.Length; i++)
        {
            places[i] = rnd.Next(1, 100);
            Console.WriteLine("\t" + places[i]);
        }

       
        temp = places[1];
        places[1] = places[4];
        places[4] = temp;

        
        Console.WriteLine("Масив після обміну другого та п'ятого елементів:");
        foreach (int place in places)
        {
            Console.WriteLine("\t\t" + place);
        }

       
        index1 = rnd.Next(0, places.Length);
        index2 = rnd.Next(0, places.Length);
        temp = places[index1];
        places[index1] = places[index2];
        places[index2] = temp;

       
        Console.WriteLine("Масив після обміну елементів за індексами:");
        foreach (int place in places)
        {
            Console.WriteLine("\t" + place);
        }
    }

    static void FirstTask_10()
    {
        Console.WriteLine("Другий слайд");
        Console.WriteLine();

        // Завдання 1
        Console.WriteLine("Завдання 1");


        Random random = new Random(); 


        int[] array = new int[10]; 


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
        Console.WriteLine("Завдання 2");

        
        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

       
        int UpRight = array[0, array.GetLength(1) - 1];
        Console.WriteLine("Елемент, розташований в правому верхньому кутку масиву: " + UpRight);

        // Відображення елемента, розташованого в лівому нижньому кутку масиву 
        int LowLeft = array[array.GetLength(0) - 1, 0];
        Console.WriteLine("Елемент, розташований в лівому нижньому кутку масиву: " + LowLeft);

    }
    static void ThirdTask_10()
    {

        // Завдання 3
        Console.WriteLine("Завдання 3");


        int[,] array = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12},
            {13, 14, 15}
        };

        
        int replace = 4;
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[replace, column] = 1949;
        }

        
        int newValue = 99; 
        int rowIndex = 2; 
        int columnIndex = 1; 
        array[rowIndex, columnIndex] = newValue;

        
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
        Console.WriteLine("Завдання 4");


        int[,] multiplication = new int[9, 9];

       
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                multiplication[i, j] = (i + 1) * (j + 1);
            }
        }

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
        Console.WriteLine("Завдання 5");


        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        
        int row = 2; 
        Console.WriteLine("Елементи третього рядка масиву, починаючи з останнього:");
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            Console.Write(array[row, j] + " ");
        }
        Console.WriteLine();

        
        int column = 1; 
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
        Console.WriteLine("Завдання 6");


        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

      
        int Row = 2; 
        int SumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow += array[Row, j];
        }
        Console.WriteLine("Сума елементів третього рядка масиву: " + SumRow);

        
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
        Console.WriteLine("Завдання 7");


        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        
        int Column = 1; 
        int SumColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            SumColumn += array[i, Column];
        }
        Console.WriteLine($"Сума елементів {Column + 1}-го стовпця масиву: " + SumColumn);

        
        int Row = 2; 
        int SumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow += array[Row, j]; 
        }
        Console.WriteLine("Сума елементів " + (Row + 1) + "-го рядка масиву: " + SumRow);
    }
    static void EigthTask_10()
    {

        // Завдання 8
        Console.WriteLine("Завдання 8");


        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        
        int Row = 1; 
        int SumSquareRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int element = array[Row, j];
            SumSquareRow += element * element;
        }
        Console.WriteLine("Сума квадратів елементів другого рядка масиву: " + SumSquareRow);

       
        int Column = 2;
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
        Console.WriteLine("Завдання 9");

        int[,] array = {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
        };

        
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

        
        int MaxRow = 0, MaxColumn = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == MaxElement)
                {
                    MaxRow = i;
                    MaxColumn = j;
                    break; 
                }
            }
        }
        Console.WriteLine("Координати максимального елемента масиву: [" + MaxRow + ", " + MaxColumn + "]");


    }
}