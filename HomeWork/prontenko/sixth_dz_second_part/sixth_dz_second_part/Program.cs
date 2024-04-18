namespace second_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            first_task();
            second_task();
            third_task();
            fourth_task();
            fifth_task();
            sixth_task();
            seventh_task();
            eighth_task();
            nineth_task();
        }

        static void Little_bit_beauty()
        {
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                Console.Write("=");

            }
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
            for (int i = 0; i < 100; i++)
            {
                Console.Write("=");

            }
            Console.WriteLine();


        }

        static void first_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int[] arr = new int[10];
            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 10);
                Console.WriteLine(arr[i]);
            }
        } //+
        static void second_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

           
            int[,] arr = new int [3,3];
            Random rand = new Random();

            for (int i = 0;i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 5);
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            int top_right_corner = arr[0, arr.GetLength(1) - 1];
            Console.WriteLine($"Елемент у правому верхньому кутку: {top_right_corner}");

            int bott_left_corner = arr[arr.GetLength(0) - 1, 0];
            Console.WriteLine($"Елемент у лівому нижньому кутку: {bott_left_corner}");
        }  //+
        static void third_task()
        {
            Little_bit_beauty() ;
            Console.WriteLine();

            int[,] array = new int[5, 5]; 
            Random rand = new Random();

            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(1, 100);
                }
            }

           
            int columnToReplace = rand.Next(0, array.GetLength(1)); 
            array[4, columnToReplace] = 1949; 

            
            int a = 10; 
            int rowToReplace = rand.Next(0, array.GetLength(0)); 
            int columnToReplace2 = rand.Next(0, array.GetLength(1)); 
            array[rowToReplace, columnToReplace2] = a; 

            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

        } //+
        static void fourth_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int[,] multiplicationTable = new int[9, 9];

            for (int i = 0; i < multiplicationTable.GetLength(0); i++)
            {
                for (int j = 0; j < multiplicationTable.GetLength(1); j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                }
            }

            
            for (int i = 0; i < multiplicationTable.GetLength(0); i++)
            {
                for (int j = 0; j < multiplicationTable.GetLength(1); j++)
                {
                    Console.Write(multiplicationTable[i, j] + "\t");
                }
                Console.WriteLine();
            }



        } //+
        static void fifth_task()
        {
            Little_bit_beauty() ;
            Console.WriteLine();


            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };

            int k ; 

            Console.WriteLine(" ");
            string input = Console.ReadLine();
            bool succes = int.TryParse(input, out k);

            if (k > 0 && k < 4)
            {
                for (int j = array.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(array[2, j] + " ");
                }
                Console.WriteLine();


                for (int i = array.GetLength(0) - 1; i >= 0; i--)
                {
                    Console.WriteLine(array[i, k]);
                }
            }
            else
            {
                Console.WriteLine("Deleting System 32 .....") ;
            }

        } //+
        static void sixth_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            int s = 1; 

            
            int sumRow = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumRow += array[2, j];
            }
            Console.WriteLine($"Сума всіх елементів третього рядка: {sumRow}");

            
            int sumColumn = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumColumn += array[i, s];
            }
            Console.WriteLine($"Сума всіх елементів {s + 1}-го стовпця: {sumColumn}");


        } //+
        static void seventh_task()
        {
            Little_bit_beauty() ;
            Console.WriteLine();

            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            int k = 2; 

            
            int sumColumn = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumColumn += array[i, 1];
            }
            Console.WriteLine($"Сума всіх елементів другого стовпця: {sumColumn}");

            
            int sumRow = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumRow += array[k, j];
            }
            Console.WriteLine($"Сума всіх елементів {k + 1}-го рядка: {sumRow}");

        } //+
        static void eighth_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };
            int c = 2; 

            
            int sumRowSquares = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumRowSquares += array[1, j] * array[1, j];
            }
            Console.WriteLine($"Сума квадратів елементів другого рядка: {sumRowSquares}");

            
            int sumColumnSquares = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumColumnSquares += array[i, c] * array[i, c];
            }
            Console.WriteLine($"Сума квадратів елементів {c + 1}-го стовпця: {sumColumnSquares}");

        } //+
        static void nineth_task()
        {
            Little_bit_beauty() ;
            Console.WriteLine("final task");
            Little_bit_beauty() ;
            Console.WriteLine();

            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 13, 14, 15 } };

            int max = array[0, 0];
            int min = array[0, 0];
            int maxX = 0, maxY = 0, minX = 0, minY = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxX = i;
                        maxY = j;
                    }
                    else if (array[i, j] == max && i < maxX)
                    {
                        maxX = i;
                        maxY = j;
                    }
                    else if (array[i, j] == max && i == maxX && j < maxY)
                    {
                        maxY = j;
                    }

                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minX = i;
                        minY = j;
                    }
                    else if (array[i, j] == min && i > minX)
                    {
                        minX = i;
                        minY = j;
                    }
                    else if (array[i, j] == min && i == minX && j > minY)
                    {
                        minY = j;
                    }
                }
            }

            Console.WriteLine($"Максимальний елемент: {max}, координати: ({maxX + 1}, {maxY + 1})");
            Console.WriteLine($"Мінімальний елемент: {min}, координати: ({minX + 1}, {minY + 1})");

        } //+
    }
}
