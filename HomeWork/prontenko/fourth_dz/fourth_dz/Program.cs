namespace fourth_dz
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


            int sum = 0;
            for (int i = 1; i < 50; i += 2)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }   //+
        static void second_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int a, b, sum = 0;

            Console.WriteLine("enter first numeric");
            string input = Console.ReadLine();
            bool succes = int.TryParse(input, out a);

            Console.WriteLine("enter second numeric");
            input = Console.ReadLine();
            succes = int.TryParse(input, out b);

            if (succes)
            {
                for (; a < b; a++)
                {
                    if(a % 4 == 0)
                    {
                        sum += a;
                        
                    }
                    else
                    {
                        continue;
                    }
                    Console.WriteLine(a);

                }    
            }
            else
            {
                Console.WriteLine("error!");
            }


        }  //+
        static void third_task()
        {
            Little_bit_beauty() ;
            Console.WriteLine();

       
            for (int i = 10; i < 100; i++)
            {
                int sumOfSquares = (i / 10) * (i / 10) + (i % 10) * (i % 10);
                if (sumOfSquares % 13 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            
            for (int i = 10; i < 100; i++)
            {
                int sumOfDigits = i / 10 + i % 10;
                if (sumOfDigits + sumOfDigits * sumOfDigits == i)
                {
                    Console.WriteLine(i);
                }
            }

        }   //+
        static void fourth_task() 
        {
            Little_bit_beauty() ;
            Console.WriteLine();

            int a, b, sum = 0;
            int product = 1;

            Console.WriteLine("enter first numeric: ");
            string input = Console.ReadLine();
            bool succes = int.TryParse(input, out a);

            Console.WriteLine("enter second numeric: ");
            input = Console.ReadLine();
            succes = int.TryParse(input, out b);

            if(succes)
            {
                for (; a <= b; a++)
                {
                    sum += a;
                    product *= a;
                }
                Console.WriteLine("sum = " + sum);
                Console.WriteLine("product = " + product);
            }
            else { Console.WriteLine("error!"); }

        } //+
        static void fifth_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int a, b, sum = 0;

            Console.WriteLine("enter first numeric");
            string input = Console.ReadLine();
            bool sucess = int.TryParse(input, out a);

            Console.WriteLine("enter second numeric");
            input = Console.ReadLine();
            sucess = int.TryParse(input, out b);

            if (sucess)
            {
                for (int i = a; i <= b ; i++)
                {
                    Console.Write("-" + i);
                    sum += i;
                }
                Console.WriteLine("sum: " + sum);
            }
            else { Console.WriteLine("error!"); }
        }  //+
        static void sixth_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            double price_per_kg;

            Console.WriteLine("enter price per Kg");
            string input = Console.ReadLine();
            bool sucess = double.TryParse(input, out price_per_kg);
            
            if (sucess)
            {
                for (double weight = 1.2; weight <= 2; weight += 0.2)
                {
                    double cost = price_per_kg * weight;
                    Console.WriteLine($"Вартість {weight} кг цукерок: {cost}");
                }
            }
            else
            {
                Console.WriteLine("error!");
            }
        }   //+
        static void seventh_task()
        {
            Little_bit_beauty();
            Console.WriteLine();

            int a, b;

            Console.WriteLine("enter first numeric");
            string input = Console.ReadLine();
            bool sucess = int.TryParse(input, out a);

            Console.WriteLine("enter second numeric");
            input = Console.ReadLine();
            sucess = int.TryParse(input, out b);

            Console.WriteLine();

            if (sucess)
            {
                for (; a <= b; a++)
                {
                    for (int i = 0; i < a; i++) 
                    {
                        Console.WriteLine(a);
                    }
                }
            }

        } //+
    }
}
