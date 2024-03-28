namespace Zharskyi_Nazar_Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.Write("Enter how many tasks there are: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            for (int i = 0; i < num; i++)
            {
                beauty();
            }
        }
        static void beauty()
        {
            Console.Write("Enter the number of task: ");
            int task_num = 0;
            try
            {
                task_num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (task_num == 1)
            {
                Console.WriteLine("Task " + task_num);
                table();
            }
            else if (task_num == 2)
            {
                Console.WriteLine("Task " + task_num);
                GuessNumber();
            }
            else if (task_num == 3)
            {
                Console.WriteLine("Task " + task_num);
                pyramide();
            }
            else if (task_num == 4)
            {
                Console.WriteLine("Task " + task_num);
                SumOfNums();
            }
            else if (task_num == 5)
            {
                Console.WriteLine("Task " + task_num);
                factorial();
            }
            else if (task_num == 6)
            {
                Console.WriteLine("Task " + task_num);
                dice();
            }
            else if (task_num == 7)
            {
                Console.WriteLine("Task " + task_num);
                MaxAndMinFromList();
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect task");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
        }
        static void table()
        {
            int num = 0;
            Console.Write("Enter the number: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int counter = 1;
            while (counter < 10)
            {
                Console.Write($"{num} x {counter} = {num * counter}\n");
                counter++;
            }
        }
        static void GuessNumber()
        {
            int num = new Random().Next(0, 10);
            int guess = 0;
            bool TF = false;
            Console.WriteLine(num);
            do
            {
                Console.Write("Guess the number from 0 to 10: ");
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (guess >= 0 && guess <= 10)
                {
                    if (guess == num)
                    {
                        TF = true;
                    }
                    if (TF == false)
                    {
                        Console.WriteLine("You`re wrong( Try again!");
                    }
                    else if (TF == true)
                    {
                        Console.WriteLine("You guessed the number! Our congratulations!");
                    }
                }
                else
                {
                    Console.WriteLine("You`ve entered incorrect data");
                }
            }
            while (guess != num);
        }
        static void pyramide()
        {
            int num = 0;
            Console.Write("Enter the number: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 1; i <= num; i++)
            {
                for (int j = i; j <= num; j++)
                {
                    Console.Write(" ");
                }
                for (int x = 1; x < i * 2; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void SumOfNums()
        {
            string num = "";
            int counter = 0, num1 = 0;
            Console.Write("Enter the number: ");
            try
            {
                num = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                num1 = Convert.ToInt32(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (int i in num)
            {
                counter += num1 % 10;
                num1 /= 10;
            }
            Console.WriteLine($"The sum of digits is {counter} (first solve) ");
            counter = 0;
            foreach (char i in num)
            {
                if (char.IsDigit(i))
                {
                    int x=Convert.ToInt32(i.ToString());
                    counter += x;
                }
            }
            Console.WriteLine($"The sum of digits is {counter} (second solve)");
        }
        static void factorial()
        {
            int fact = 0;
            decimal counter = 1;
            Console.Write("Enter the number: ");
            try
            {
                fact = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 1; i <= fact; i++)
            {
                counter*= i;
            }
            Console.WriteLine($"The factorial of {fact} is equal to {counter}");
        }
        static void dice()
        {
            int rand1=0,rand2=0;
            string str1 = "", str2 = "", str = "";
            bool TF = true;
            do
            {
                Console.WriteLine("If you want to play enter \"Play\" \nIf you want to finish enter \"Finish\"");
                Console.Write("Enter here: ");
                try
                {
                    str = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (str == "Play")
                {
                    do
                    {
                        Console.WriteLine("1 Player turn");
                        Console.WriteLine("If you want to finish playing, enter: \"Finish\"");
                        Console.Write("Enter \"Throw\" to throw the cubes: ");
                        try
                        {
                            str1 = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        if (str1 == "Finish")
                            goto l1;
                        else if (str1 == "Throw")
                        {
                            rand1 = new Random().Next(1, 12);
                            Console.WriteLine($"You`ve got {rand1} points");
                        }
                        else
                        {
                            Console.WriteLine("Try to enter again");
                        }
                    }
                    while (str1 != "Throw");
                    do
                    {
                        Console.WriteLine("2 Player turn");
                        Console.WriteLine("If you want to finish playing, enter: \"Finish\"");
                        Console.Write("Enter \"Throw\" to throw the cubes: ");
                        try
                        {
                            str2 = Console.ReadLine();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        if (str2 == "Finish")
                            goto l1;
                        else if (str2 == "Throw")
                        {
                            rand2 = new Random().Next(1, 12);
                            Console.WriteLine($"You`ve got {rand2} points");
                        }
                        else
                        {
                            Console.WriteLine("Try to enter again");
                        }
                    }
                    while (str2 != "Throw");
                    if (rand1 < rand2)
                    {
                        Console.WriteLine("Player 2 won");
                    }
                    else if (rand2 < rand1)
                    {
                        Console.WriteLine("Player 1 won");
                    }
                    else if(rand1 == rand2)
                    {
                        Console.WriteLine("That`s draw");
                    }
                    else
                    {
                        Console.WriteLine("Caught an exception");
                    }
                }
                else if (str == "Finish")
                {
                    goto l1;
                }
                else
                {
                    Console.WriteLine("Try to enter again");
                }
            }
            while (true);
        l1:;
        }
        static void MaxAndMinFromList()
        {
            int len=new Random().Next(1,10);
            Console.WriteLine($"The length of list is: {len}");
            List<int> digits = new List<int>();
            for (int i = 0; i < len; i++)
            {
                digits.Add(new Random().Next(1,10));
            }
            Console.Write("The list of digits: ");
            for (int i = 0;i < len; i++)
            {
                Console.Write(digits[i] + " ");
            }
            int max = digits[0], min = digits[0];
            foreach (int digit in digits)
            {
                if (digit > max)
                {
                    max = digit;
                }
                if(digit < min)
                {
                    min = digit;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Max number in list is {max}, Min number is {min}");
        }
    }
}
