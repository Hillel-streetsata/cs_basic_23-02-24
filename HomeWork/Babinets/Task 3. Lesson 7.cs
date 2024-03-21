namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("1.Знайдіть суму додатних непарних чисел менше 50.");
            try
            {
                int number = 1;
                int i1 = 0;
                int limit = 51;
         
                while (number < limit)
                {
                    if (number % 2 != 0)
                    {
                        i1 += number;
                    }
                    number++;
                }
                Console.WriteLine("Sum =" + i1 + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            TwoNumbers();
         
        }
        static void TwoNumbers()
        {
            try
            {
                int c = 10;
                Console.WriteLine("3. Знайти всі двозначні числа, сума квадратів цифр яких ділиться на 13; " +
                    "б) всі двозначні числа, які мають наступну" + " властивість: якщо до суми цифр числа додати " +
                    "квадрат цієї суми, то знову вийде шукане число.");
                while (c < 100)
                {
                    int num1 = c / 10;
                    int num2 = c % 10;
                    int squares = num1 * num1 + num2 * num2;
                    int sum1 = num1 + num2;
                    int squares2 = sum1 * sum1;
                    int results = sum1 + squares2;
                    if (squares % 13 == 0)
                    {
                        Console.WriteLine("a) result " + squares + ", c= " + c);
                    }
                    if (results == c)
                    {
                        Console.WriteLine("b) found value c = " + c);
                    }
                    c++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            SumValue();
        }
        static void SumValue()
        {
            try
            {
                Console.WriteLine("\n 2.Обчисліть суму натуральних чисел від a до b, кратних чотирьом.");
                int a = 1;
                int b = 20;
                while (a <= b)
                {
                    int sum = a + b;
                    if (sum % 4 == 0)
                    {
                        Console.WriteLine("Sum a multiple of four = " + sum);
                    }
                    a++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            SumProductValue();
        }
     
        static void SumProductValue()
        {
            Console.WriteLine("\n 4.Дано два цілих числа A і B(A < B).Знайдіть суму та добуток усіх цілих чисел від A до B включно.");
            try
            {
                int AA = 0;
                int BB = 20;
                while (AA <= BB)
                {
                    int suma = AA + BB;
                    int product = AA * BB;
                    Console.WriteLine("Sum= " + suma + ", Product= " + product);
     
                    AA++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            AscendingOrder();
        }
        static void AscendingOrder()
        {
            try
            {
                Console.WriteLine("\n 5.Дано два цілих числа A і B(A < B).Вивести в порядку зростання всі цілі числа, розташовані між A і B(включаючи самі числа A і B), а також число N цих чисел.");
                int A1 = 0;
                int B1 = 10;
                Console.WriteLine("A = " + A1);
                while (A1 <= B1)
                {
                    Console.WriteLine("N = " + A1);
                    A1++;
                }
                Console.WriteLine("B = "+ B1);
              // не знаю, як краще
                int Aa = 0;
                int Bb = 10;
                Console.WriteLine("B = " + Bb);
                while (Bb >= Aa)
                {
                    Console.WriteLine("N = " + Bb);
                    Bb--;
                }
                Console.WriteLine("A = " + Aa);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Price();
        }
        static void Price()
        {
            try
            {
                Console.WriteLine("\n 6.Наводиться реальна цифра - ціна 1 кг цукерок. Зніміть вартість 1,2, 1,4, ..., 2 кг цукерок.");
                double valuesweets = 15.66;
                double begin = 1;
                double over = 2;
                while (begin < over)
                {
     
                    double result = valuesweets * begin;
                    string format = result.ToString("0.00");
                    string format2 = begin.ToString("0.00");
                    Console.WriteLine("Cost sweets " + format2 + "kg = " + format + "$");
                    begin += 0.2;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            TwoNaturalNumber();
        }
        static void TwoNaturalNumber()
        {
            try
            {
                Console.WriteLine("\n 7.Задаються натуральні числа А і В(А<В). Відображати всі цілі числа від А до Б включно; При цьому кожне число має відображатися стільки разів, скільки його значення(наприклад, цифра 3 відображається 3 рази).");
                int A2 = 1;
                int B2 = 10;
                while (A2 <= B2)
                {
                    for (int i = 0; i < A2; i++)
                        Console.WriteLine("A = " + A2);
                    A2++;
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex);
            }
        }
    }



}
