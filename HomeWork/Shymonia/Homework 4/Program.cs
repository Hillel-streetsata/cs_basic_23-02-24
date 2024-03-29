using System.Text;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            FirstTask();
            SecondTask();
            ThirdTaskA();
            FourthTask();
            FifthTask();
            SixthTask();


            static void FirstTask()
            {


                Console.WriteLine("_______________________________________________");
                Console.WriteLine("1. Знайдіть суму додатних непарних чисел менше 50.");

                int sum = 0;

                for (int i = 1; i < 50; i += 2)
                {
                    sum += i;
                }

                Console.WriteLine("Сума додаткових непарних чисел 50: " + sum);






            }


            static void SecondTask()
            {
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("2. Обчисліть суму натуральних чисел від a до b, кратних чотирьом.");


                int a = 1;
                int b = 100;
                int sum = 0;

                for (int i = a; i <= b; i++)
                {

                    if (i % 4 == 0)
                    {
                        sum += i;
                    }
                }

                Console.WriteLine($"cума натуральних чисел {a} до {b}, кратких чотирьом {sum}");
            }


            static void ThirdTaskA()
            {
                Console.WriteLine("_______________________________________________");
                Console.WriteLine("3(a). всі двозначні числа, сума квадратів цифр яких ділиться на 13 від 10 до 99");


                for (int i = 10; i <= 99; i++)
                {
                    int digit1 = i / 10;
                    int digit2 = i % 10;
                    int sumOfSquares = digit1 * digit1 + digit2 * digit2;

                    if (sumOfSquares % 13 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }

            }



            static void FourthTask()
            {


                Console.WriteLine("_______________________________________________");
                Console.WriteLine("4. Дано два цілих числа A і B (A < B). Знайдіть суму та добуток усіх цілих чисел від A до B включно");



                try
                {
                    Console.WriteLine("введіть ціле число А:");
                    int A = int.Parse(Console.ReadLine());

                    Console.WriteLine("тепер ціле число B (B повинно бути більше А):");
                    int B = int.Parse(Console.ReadLine());

                    if (A >= B)
                    {
                        Console.WriteLine("В повинно бути більше А.");
                        return;
                    }

                    int sum = 0;
                    int product = 1;

                    for (int i = A; i <= B; i++)
                    {
                        sum += i;
                        product *= i;
                    }

                    Console.WriteLine($"сума всіх цілих чисел від {A} до {B} = {sum}");
                    Console.WriteLine($"добуток від {A} до {B} = {product}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("введіть цілі числа");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("дуже велике або дуже мале число");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"помилка {ex.Message}");
                }

            }


            static void FifthTask()
            {

                Console.WriteLine("_______________________________________________");
                Console.WriteLine("5. Дано два цілих числа A і B (A < B). Вивести в порядку зростання всі цілі числа, розташовані між A і B (включаючи самі числа A і B), а також число N цих чисел.");

                int A = 1;
                int B = 30;


                Console.WriteLine("послідовні цілі числа:");
                for (int i = A; i <= B; i++)
                {
                    Console.WriteLine(i);
                }


                int N = B - A + 1;
                Console.WriteLine($"кількість чисел між {A} і {B} і включаючи їх самих: {N}");




            }


            static void SixthTask()
            {

                Console.WriteLine("_______________________________________________");
                Console.WriteLine("6. Наводиться реальна цифра - ціна 1 кг цукерок. Зніміть вартість 1,2, 1,4, ..., 2 кг цукерок.");

                double price = 10.0;
                double step = 0.2;

                Console.WriteLine("Вага (kg)\t Ціна");
                for (double weight = 1.0; weight <= 2.0; weight += step)
                {
                    double cost = weight * price;
                    Console.WriteLine($"{weight}\t\t {cost}");
                }








            }

        }
    }

}
