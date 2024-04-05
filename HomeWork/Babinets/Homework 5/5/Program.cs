using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;
using System.Xml.Schema;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n 1.Заповніть масив з восьми елементів наступними значеннями: перший елемент масиву - 37, другий - 0, третій - 50, четвертий - 46, п'ятий - 34, шостий - 46, сьомий - 0, а восьмий - 13. Відобразити на екрані.");
            int[] task1 = new int[8] { 37, 0, 50, 46, 34, 46, 0, 13 };
            task1[0] = 37;
            task1[1] = 0;
            task1[2] = 50;
            task1[3] = 46;
            task1[4] = 34;
            task1[5] = 46;
            task1[6] = 0;
            task1[7] = 13;
            Console.WriteLine($"{task1[0]}, {task1[1]}, {task1[2]},  {task1[3]}, {task1[4]}, {task1[5]}, {task1[6]}, {task1[7]}");
            TwelvePersons();
        }

        static void TwelvePersons()
        {
            Console.WriteLine("\n 2.Масив призначений для зберігання значень висоти дванадцяти чоловік.  Використовуючи випадкові числа, заповніть масив цілими значеннями в діапазоні від 163 до 190 включно.");
            int[] height = new int[12];
            Random rnd = new Random();
            for (int i = 0; i < height.Length; i++)
            {
                height[i] = rnd.Next(163, 191);
                Console.WriteLine(height[i]);
            }
            EvenNumber();
        }
        static void EvenNumber()
        {
            Console.WriteLine("\n 3.Присвоюються початкові значення від 1, 2, 3,... , до 10 елементам масиву і відобразити елементи масиву з парним індексом.");
            int[] even = new int[10];
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
            Elements10();
        }
        static void Elements10()
        {
            Console.WriteLine("\n 4.Створіть масив розмірністю 10 елементів, відобразіть всі елементи масиву в зворотному порядку.");
            int[] elements = new int[10];
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Elements12();
        }
        static void Elements12()
        {
            try
            {
                Console.WriteLine("\n 5.Створіть масив розмірністю 12 елементів, підсумуйте значення. Підсумовування робиться в тілі петлі for.\n Значення, які використовуються в якості початкових значень для масиву A, вводяться в програму користувачем з клавіатури.");
                int[] A = new int[12];
                int sum = 0;
                int enter;
                for (int i = 0; i < A.Length; i++)
                {
                    Console.WriteLine($" Введіть будь ласка {i} елемент масиву ");
                    enter = Convert.ToInt16(Console.ReadLine());
                    sum += enter;
                }
                Console.WriteLine("Cума масиву = " + sum);
            }
            catch (Exception)
            {
                Console.WriteLine("Ви ввели некоректне значення.");
            }
            Resistance();
        }
        static void Resistance()
        {
            Console.WriteLine("\n 6.У масиві зберігається інформація про опір кожного з 20 елементів електричного кола.Всі елементи з'єднуються паралельно.\n Визначити загальний опір ланцюга. (1 / R(1) + 1 / R(2)… 1 / R(n))");
            int[] resist = new int[20];
            double value;
            double general = 0;
            double personal;
            Random rnd = new Random();
            for (int i = 0; i < resist.Length; i++)
            {
                value = rnd.Next(0, 100);
                personal = 1 / value;
                general += personal;
                Console.WriteLine($" R {i} = {value}");
            }
            Console.WriteLine("General resistance = " + general);
            IntegralNumber();
        }
        static void IntegralNumber()
        {
            Console.WriteLine("\n 7.З'ясуємо, чи правда, що сума елементів масиву є невід'ємним числом.");
            int[] integral = new int[10];
            int sum = 0;
            Random rnd = new Random();
            for (int i = 0; i < integral.Length; i++)
            {
                integral[i] = rnd.Next(-5, 5);
                Console.WriteLine($"# {i} = {integral[i]}");
                sum += integral[i];
            }
            if (sum < 0)
            {
                Console.WriteLine(" The sum is negative " + sum);
            }
            if (sum > 0)
            {
                Console.WriteLine(" The sum is positive " + sum);
            }
            SwapPlaces();
        }
        static void SwapPlaces()
        {
            Console.WriteLine("\n 8.Заданий масив.Поміняйте місцями: а) другий і п'ятий елементи; б) m-й і n-й елементи");
            int[] places = new int[10];
            Random rnd = new Random();
            int order;
            int order1;
            int m;
            int i;
            int n;
            for (i = 0; i < places.Length; i++)
            {
                places[i] = rnd.Next(1, 100);
                Console.WriteLine(" \t" + places[i]);
            }
            order = places[1];
            places[1] = places[4];
            places[4] = order;
            for (i = 0; i < places.Length; i++)
            {
                Console.WriteLine("\t\t" + places[i]);
            }
            Random rnd2 = new Random();
            m = rnd2.Next(0, places.Length);
            n = rnd2.Next(0, places.Length);
            order1 = places[m];
            places[m] = places[n];
            places[n] = order1;
            for (i = 0; i < places.Length; i++)
            {
                Console.WriteLine(" " + places[i]);
            }
            Random10();
        }
        static void Random10()
        {
            Console.WriteLine("\n 9.Заповніть масив з 10 елементів випадковими числами в інтервалі [-10..10]\r\n");
            int[,] rand = new int[5, 2];
            Random rnd3 = new Random();
            for (int i = 0; i < rand.GetLength(0); i++)
            {
                for (int j = 0; j < rand.GetLength(1); j++)
                { 
                rand[i, j] = rnd3.Next(-10, 10);
                Console.Write("\t"+rand[i, j]);
            }
            Console.WriteLine();   
        }
            TwodimensionalArray();
        }
        static void TwodimensionalArray()
        {
            Console.WriteLine("\n 10.Заданий двовимірний масив.а) Відображення елемента, розташованого в правому верхньому кутку масиву.\n б) Відображення елемента, розташованого в лівому нижньому кутку масиву.");
            int i, k;
            int[,] dimensional = new int[3, 4];
            for (i = 0; i < dimensional.GetLength(0); i++)
            {
                for (k = 0; k < dimensional.GetLength(1); k++)
                {
                    dimensional[i, k] = (k * 4) + i + 1;
                    Console.Write(dimensional[i, k] + " ");
                }
                Console.WriteLine();
            }
            int rightup = dimensional[0, 3];
            int leftdown = dimensional[2, 0];
            Console.WriteLine("\n Value right up " + rightup + "\t Value  left down " + leftdown);
            FifthElements();
        }
        static void FifthElements()
        {
            try
            {
                Console.WriteLine("\n 11.Складіть програму: а) Заміна значення будь-якого елемента п'ятого рядка двовимірного масиву числом 1949; \n б) який замінює значення будь-якого елемента двовимірного масиву числом a.");
                int i, k, a;
                int[,] fiftharray = new int[5, 5];
                Random rnd = new Random();
                for (i = 0; i < fiftharray.GetLength(0); i++)
                {
                    for (k = 0; k < fiftharray.GetLength(1); k++)
                    {
                        fiftharray[i, k] = rnd.Next(0, 2000);
                        Console.Write(fiftharray[i, k] + " \t");
                    }
                    Console.WriteLine();
                }
                int column = rnd.Next(0, fiftharray.GetLength(1));
                int value = 1949;
                for (i = 0; i < fiftharray.GetLength(0); i++)
                {
                    fiftharray[4, column] = value;
                }
                Console.WriteLine("With value 1949.");
                for (i = 0; i < fiftharray.GetLength(0); i++)
                {
                    for (k = 0; k < fiftharray.GetLength(1); k++)
                    {
                        Console.Write(fiftharray[i, k] + " \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Please enter the value of a (0-2000).");
                a = Convert.ToInt32(Console.ReadLine());
                for (i = 0; i < fiftharray.GetLength(0); i++)
                {
                    for (k = 0; k < fiftharray.GetLength(1); k++)
                    {
                        int randomrows = rnd.Next(0, fiftharray.GetLength(0));
                        int randomcolumns = rnd.Next(0, fiftharray.GetLength(1));
                        fiftharray[randomrows, randomcolumns] = a;
                        Console.Write(fiftharray[i, k] + " \t");
                    }
                    Console.WriteLine();

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ви ввели некоректне значення.");
            }
            MultiplicationTable();
        }
        static void MultiplicationTable()
        {
            Console.WriteLine("\n 12.Заповніть двовимірний масив результатами таблиці множення\n (в першому рядку слід записати добутки кожного з чисел від 1 до 9 на 1, в останньому - 2, ..., а в останньому - 9)");
            int[,] table = new int[10, 10];
            int i, k;

            for (i = 1; i < table.GetLength(0); i++)
            {
                for (k = 1; k < table.GetLength(1); k++)
                {
                    table[i, k] = i * k;
                    Console.Write(table[i, k] + "\t");
                }
                Console.WriteLine();
            }
            ColumnK();
        }

        static void ColumnK()
        {
            try
            {
                Console.WriteLine("\n 13.Задано двовимірний масив.Відображення: а) всіх елементів третього рядка масиву, починаючи з останнього елемента цього рядка;\n b) Всі елементи k-го стовпця масиву, починаючи з нижнього елемента цього стовпця.");
                int[,] column = new int[9, 9];
                int i, k;
                Random rnd = new Random();
                for (i = 0; i < 9; i++)
                {
                    for (k = 0; k < 9; k++)
                    {
                        column[i, k] = rnd.Next(-10, 10);
                        Console.Write(column[i, k] + " \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (k = 0; k < 9; k++)
                {
                    int thirdline = column[2, k];
                    Console.Write(thirdline + " \t");
                }
                Console.WriteLine();
                Console.WriteLine(" Введіть будь ласка номер стовпця(0-8) для виведення на екран.");
                int colum = Convert.ToInt32(Console.ReadLine());
                for (i = 9 - 1; i >= 0; i--)
                {
                    for (k = 0; k < 9; k++)
                    {
                        if (colum == k)
                        {
                            Console.Write(column[i, k] + "\t");
                        }
                    }
                }
                Console.WriteLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Ви ввели некоректне значення.");
            }

            SumThirtyLine();
        }
        static void SumThirtyLine()
        {
            Console.WriteLine("\n 14.Заданий двовимірний масив. Визначити: а) Сума всіх елементів третього рядка масиву; б) Сума всіх елементів s-го стовпця масиву.");
            int[,] sum = new int[5, 5];
            int t, i, s;
            int sumaofthirthrow = 0;
            int sumaofscolumn = 0;
            Random rnd = new Random();
            for (t = 0; t < sum.GetLength(0); ++t)
            {
                for (i = 0; i < sum.GetLength(1); ++i)
                {
                    sum[t, i] = rnd.Next(0, 5);
                    Console.Write(sum[t, i] + "\t");

                }
                Console.WriteLine();
            }
            for (i = 0; i < sum.GetLength(0); ++i)
            {
                sumaofthirthrow += sum[2, i];
            }
            Console.WriteLine($" Sum of thirth row = {sumaofthirthrow}");
            Console.WriteLine();
            s = new Random().Next(0, 4);// dont like it 
            for (t = 0; t < sum.GetLength(0); t++)
            {
                sumaofscolumn += sum[t, s];
            }
            Console.WriteLine($"Sum of {s} column = {sumaofscolumn}, if we count from zero");
            SumofSecondColumn();
        }
        static void SumofSecondColumn()
        {
            try
            {
                Console.WriteLine("\n 15.Задано двовимірний масив.Визначити: а) сума всіх елементів другого стовпця масиву; б) Сума всіх елементів k-го рядка масиву.");
                int[,] secondcolumn = new int[5, 5];
                Random rnd = new Random();
                int s, l, k;
                int sumofsecondcolumn = 0;
                int sumofkrow = 0;
                for (s = 0; s < secondcolumn.GetLength(0); ++s)
                {
                    for (l = 0; l < secondcolumn.GetLength(1); ++l)
                    {
                        secondcolumn[s, l] = rnd.Next(1, 9);
                        Console.Write(secondcolumn[s, l] + "\t ");
                    }
                    Console.WriteLine();
                }
                for (s = 0; s < secondcolumn.GetLength(0); ++s)
                {
                    sumofsecondcolumn += secondcolumn[s, 1];
                }
                Console.WriteLine($"Сума елементів другого стовпця = {sumofsecondcolumn}");
                Console.WriteLine("Please enter the number of rows (0-4) .");
                k = Convert.ToInt32(Console.ReadLine());
                for (l = 0; l < secondcolumn.GetLength(1); ++l)
                {
                    sumofkrow += secondcolumn[k, l];
                }
                Console.WriteLine($" Сума елементів {k}  рядка = {sumofkrow}");
            }
            catch (Exception)
            {
                Console.WriteLine("Ви ввели некоректне значення.");
            }
            SquaresArray();
        }
        static void SquaresArray()
        {
            try
            {
                Console.WriteLine("\n 16.Задано двовимірний масив.Визначити: а) Сума квадратів елементів другого рядка масиву; б) Сума квадратів елементів c-го стовпця масиву.");
                int s, l, c;
                int k = 0;
                int squaresArray, squaresArrayc, columnc = 0;
                int[,] squares = new int[5, 5];
                Random smth = new Random();
                for (s = 0; s < squares.GetLength(0); s++)
                {
                    for (l = 0; l < squares.GetLength(1); ++l)
                    {
                        squares[s, l] = smth.Next(0, 5);
                        Console.Write($"{squares[s, l]}  ");
                    }
                    Console.WriteLine();
                }
                for (l = 0; l < squares.GetLength(1); ++l)
                {
                    squaresArray = squares[1, l] * squares[1, l];
                    k += squaresArray;
                }
                Console.WriteLine($" Squares  sum of second row = {k} ");
                Console.WriteLine(" Please enter the number of column (0-4).");
                c = Convert.ToInt32(Console.ReadLine());
                for (s = 0; s < squares.GetLength(1); s++)
                {
                    squaresArrayc = squares[s, c] * squares[s, c];
                    columnc += squaresArrayc;
                }
                Console.WriteLine($"Сума квадратів елементів {c} стовпця = {columnc}");
            }
            catch (Exception)
            {
                Console.WriteLine("Ви ввели некоректне значення.");
            }
            MinMaxArray();
        }
        static void MinMaxArray()
        {
            Console.WriteLine("\n 17. Задано двовимірний масив.Визначити: \n а) Максимальний елемент масиву;\n б) Мінімальний елемент масиву;\n в) Координати мінімального елемента  масиву.Якщо елементів з мінімальним значенням кілька, то необхідно знайти координати самого нижнього і правого з них; \n г) Координати максимального елемента масиву.Якщо елементів з максимальним значенням кілька, то необхідно знайти координати самого верхнього і крайнього");   // з них.
            int i = 0; int j = 0;
            int minValue = 0; int maxValue = 0;
            int mini = 0; int minj = 0; int maxi = 0; int maxj = 0;
            int[,] Array = new int[5, 5];
            Random newr = new Random();
            while (i < Array.GetLength(0))
            {
                j = 0;
                while (j < Array.GetLength(1))
                {
                    Array[i, j] = newr.Next(-15, 15);
                    Console.Write(Array[i, j] + "  \t");
                    if (maxValue < Array[i, j])
                    {
                        maxValue = Array[i, j];
                        maxi = i;
                        maxj = j;
                    }
                    else if (Array[i, j] == maxValue)
                    {
                        if (i < maxi || (i == maxi && j < maxj))
                        {
                            maxi = i;
                            maxj = j;
                        }
                    }
                    if (minValue > Array[i, j])
                    {
                        minValue = Array[i, j];
                        mini = i;
                        minj = j;
                    }
                    else if (Array[i, j] == minValue)
                    {
                        if (i < mini || (i == mini && j < minj))
                        {
                            mini = i;
                            minj = j;
                        }
                    }

                    j++;
                }
                i++;
                Console.WriteLine();
            }
            Console.WriteLine("\t\t\t Min value = " + minValue + " index [ " + mini + "," + minj + "].");
            Console.WriteLine("\t\t\t Max value = " + maxValue + " index [ " + maxi + "," + maxj + "].");
        }

    }

}
