using System.Text;
using System.Threading.Channels;

namespace HomeWork6
{
    internal class Program
    {
        static void Divider()
        {
            Console.WriteLine(new string('-', 12));
        }

        static void TaskOne()
        {
            Console.WriteLine("TaskOne");
            Divider();

            int[] array = new int[8];

            array[0] = 37;
            array[1] = 0;
            array[2] = 50;
            array[3] = 46;
            array[4] = 34;
            array[5] = 46;
            array[6] = 0;
            array[7] = 13;

            Console.WriteLine("Елементи масиву \n");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Елемент {i + 1}: {array[i]}\n");
            }
        }
        static void TaskTwo()
        {
            Console.WriteLine("TaskTwo");
            Divider();

            Random rnd = new Random();
            int[] haightArray = new int[12];

            for (int i = 0; i < haightArray.Length; i++)
            {
                haightArray[i] = rnd.Next(163, 191);
            }

            for (int i = 0; i < 10; i++)
            {
                haightArray[i] = i + 1;
            }
            Console.WriteLine("Елементи масиву з парними індексами \n");
            for (int i = 0; i < haightArray.Length; i += 2)
            {

                Console.WriteLine($"Елемент {i}: {haightArray[i]}\n");
            }
        }
        static void TaskThree()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            Console.WriteLine("Елемент масиву з парними індексами: ");

            for (int i = 0; i < array.Length; i += 2)
            {
                Console.WriteLine("Елемент з {0}: {1}", i, array[i]);
            }
        }
        static void TaskFour()
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Елементи масиву у зворотоному порядку: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void TaskFive()
        {
            int[] array = new int[12];

            Console.WriteLine("Введіть початкові значення для масиву");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Елемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Сума всіх елементів масиву: {sum}");
        }
        static void TaskSix()
        {
            double[] resistances = new double[20];

            Console.Write("Введіть опір кожног о елмента: ");

            for (int i = 0; i < resistances.Length; i++)
            {
                Console.Write($"Опір {i + 1}: ");
                resistances[i] = double.Parse(Console.ReadLine());
            }
            double totalResistances = 0;
            foreach (double resistance in resistances)
            {
                totalResistances += 1 / resistance;
            }
            totalResistances = 1 / resistances.Length;
            Console.WriteLine($"Загальний опір ланцюга: {totalResistances}");
        }
        static void TaskSeven()
        {
            int[] array = { 2, -5, 7, 3, 1 };

            int sum = 0;

            foreach (int num in array)
            {
                sum += num;
            }
            bool isNonNegative = sum >= 0;

            if (isNonNegative)
            {
                Console.WriteLine("Сума елементів масиву є невід'ємним числом.");
            }
            else
            {
                Console.WriteLine("Сума елементів масиву не є невід'ємним числом.");
            }
        }
        static void TaskEleven()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int m = 2;
            int n = 8;

            int temp = array[m - 1];
            array[m - 1] = array[n - 1];
            array[n - 1] = temp;

            Console.WriteLine($"Масив після обміну місцями {0}-го і {1}-го елементів: ", m, n);
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
        static void One()
        {
            Random random = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 11);
            }
            Console.WriteLine("Заповнений масив: ");
            foreach (int number in array)
            {
                Console.WriteLine(number + " ");
            }
        }
        static void Two()
        {
            int[,] array = new int[,]
        {
            {1 ,2 ,3},
            {4, 5, 6 },
            {7, 8, 9},
        };
            int Right = array[0, array.GetLength(1) - 1];
            Console.WriteLine("Елеиент в правому верхньому кутку: " + Right);

            int Left = array[array.GetLength(0) - 1, 0];
            Console.WriteLine("Елемент в лівому нижньому кутку: " + Left);
        }
        static void Three()
        {
            int[,] array = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9},
                {10, 11, 12},
                {13, 14, 15},
            };
            int rowToChange = 4;
            int columnToChange = 1;
            array[rowToChange, columnToChange] = 1949;

            int a = 999;
            int row = 2;
            int column = 2;
            array[row, column] = a;

            Console.WriteLine("Оновлений двовимірний масив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Four()
        {
            int rows = 9;
            int columns = 9;

            int[,] multiplicationTable = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }
            Console.WriteLine("Табличка множення");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(multiplicationTable[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Five() 
        {
            int[,] array = new int[,]
            {
                {1 ,2 ,3 ,4 },
                {5 ,6 ,7 ,8 },
                {9, 10 ,11 ,12 },
            };
            
            int row = 2;
            
            Console.WriteLine("Елемент третього рядка, починаючи з останього:");
            
            for (int j = array.GetLength(1) - 1; j >= 0; j--)
            {
                Console.WriteLine(array[row,j] + " ");
            }
            Console.WriteLine();

            int column = 1;
            Console.WriteLine($"Елемент {0}-го стовпця, починаючи з нижнього:" , column);
            
            for (int i = array.GetLength(0) - 1; i >= 0; i--) 
            {
                Console.WriteLine(array[i,column] + " ");
            }
        }
        static void Six() 
        {
            int[,] array = new int[,]
            {
                {1 ,2 ,3 ,4 },
                {5 ,6 ,7 ,8 },
                {9, 10 ,11 ,12 },
            };
            int rowSum = 0;
            int row = 2;
            
            for(int  j = 0; j < array.GetLength(1); j++) 
            {
            rowSum += array[row,j];
            }           
            Console.WriteLine("Сума всіх елементів третього рядка масиву: " + rowSum);

            int columnSum = 0;
            int column = 1;
            for (int i = 0;  i < array.GetLength(0); i++) 
            { 
                columnSum += array[i,column];
            }           
            Console.WriteLine($"Сума всіх елементів {0}-го стовпця масиву: {1}", column, columnSum);
        }
        static void Seven() 
        {
            int[,] array = new int[,]
            {
                {1 ,2 ,3 ,4 },
                {5 ,6 ,7 ,8 },
                {9, 10 ,11 ,12 },
            };
            int columnSum = 0;
            int column = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                columnSum += array[column, i];
            }
            Console.WriteLine("Сума всіх елементів третього рядка масиву: " + columnSum);

            int rowSum = 0;
            int row = 1;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                columnSum += array[j, column];
            }
            Console.WriteLine($"Сума всіх елементів {0}-го стовпця масиву: {1}", row, rowSum);
        }
        static void Eight() 
        {
            int[,] array = new int[,]
            {
                {1 ,2 ,3 ,4 },
                {5 ,6 ,7 ,8 },
                {9, 10 ,11 ,12 },
            };
            int row = 1;
            int rowSquaredSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
               rowSquaredSum += array[row, j] * array[row, j];
            }
            Console.WriteLine("Сума всіх елементів третього рядка масиву: " + rowSquaredSum);

            int column = 2;
            int columnSquaredSum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                columnSquaredSum += array[i, column] * array[i, column];
            }
            Console.WriteLine($"Сума всіх елементів {0}-го стовпця масиву: {1}", column, columnSquaredSum);
        }
        static void Nine() 
        {
            int[,] array = new int[,]
            {
                {1 ,2 ,3 ,4 },
                {5 ,6 ,7 ,8 },
                {9, 10 ,11 ,12 },
            };
            int maxElement = int.MinValue;

            foreach(int element in array) 
            {
                if(element > maxElement) 
                {
                maxElement = element;
                }
            }
            Console.WriteLine("Максимальний елемент масиву: " + maxElement);

            int minElement = int.MaxValue;

            foreach(int element in array)
            {
                if (element < minElement)
                {
                    minElement = element;
                }

            }
            Console.WriteLine("Мінімальний елемент масиву: " + minElement);

            int minRowindex = 0;
            int minColumnIndex = 0;

            for(int i = 0; i > array.GetLength(0); i++) 
            {
            for(int j = 0; j < array.GetLength(1); j++) 
                {
                if (array[i, j] == minElement) 
                    {
                    minRowindex = i;
                    minColumnIndex = j;
                    }
                }
            }
            Console.WriteLine("Координати мінімального елемента масиву: [{0}, {1}]" , minRowindex, minColumnIndex);

            int maxRowIndex = 0;
            int maxColumnIndex = 0;
            for(int i = 0; i < array.GetLength(0); i++) 
            {
            for(int j = 0; j < array.GetLength(1); j++) 
                {
                    if (array[i, j] == maxElement) 
                    {
                        maxRowIndex = i;
                        maxColumnIndex = j;
                    }
                }
            }
            Console.WriteLine("Координати максимального елемента масиву: [{0,{1}]", maxRowIndex, maxColumnIndex);
        }
        static void Main(string[] args)
        {
            Console.Title = "Home Work #6";

            Console.OutputEncoding = UTF8Encoding.UTF8;

            Console.WriteLine("Слайд №7\n");

            Divider();
            TaskOne();

            Divider();
            TaskTwo();
            Divider();

            TaskThree();
            Divider();
            TaskFour();

            Divider();
            TaskFive();
            Divider();

            TaskSix();
            Divider();
            TaskSeven();

            Divider();
            TaskEleven();
            Divider();

            Console.WriteLine("Слайд №10");

            Divider();
            One();
            Divider();

            Two();
            Divider();
            Three();
            
            Divider();
            Four();
            Divider();
            
            Five();
            Divider();
            Six();
            Divider();

            Seven();
            Divider();
            Eight();
            Divider();
            Nine();
            Divider();
        }
    }
}
