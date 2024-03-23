namespace Zharskyi_Nazar_homework_2
{
    internal class homework_2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter how many tasks there are: ");
            int num = 0;
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
            Console.WriteLine("Task " + task_num);
            if (task_num == 1)
            {
                task_1();
            }
            else if (task_num == 2)
            {
                task_2();
            }
            else if (task_num == 3)
            {
                task_3();
            }
            else if (task_num == 4)
            {
                task_4();
            }
            else if (task_num == 5)
            {
                task_5();
            }
            else if (task_num == 6)
            {
                task_6();
            }
            else if (task_num == 7)
            {
                task_7();
            }
            else if (task_num == 8)
            {
                task_8();
            }
            else
            {
                Console.WriteLine("You`ve entered incorrect task");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
        }
        static void task_1()
        {
            int number = 0;
            Console.Write("Enter a number: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (number > 0)
            {
                ++number;
                Console.WriteLine(number);
            }
            else if (number < 0)
            {
                number -= 2;
                Console.WriteLine(number);
            }
            else if (number == 0)
            {
                number += 10;
                Console.WriteLine(number);
            }
        }
        static void task_2()
        {
            int number1 = 0, number2 = 0, number3 = 0, counter = 0;
            Console.Write("Enter first number: ");
            try
            {
                number1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Enter second number: ");
            try
            {
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Enter third number: ");
            try
            {
                number3 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (number1 > 0)
            {
                counter++;
            }
            if (number2 > 0)
            {
                counter++;
            }
            if (number3 > 0)
            {
                counter++;
            }
            Console.WriteLine("There are " + counter + " positive numbers");
        }
        static void task_3()
        {
            int number1 = 0, number2 = 0, number3 = 0, counter1 = 0, counter2 = 0;
            Console.Write("Enter first number: ");
            try
            {
                number1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Enter second number: ");
            try
            {
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Enter third number: ");
            try
            {
                number3 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (number1 > 0)
            {
                counter1++;
            }
            else if (number1 < 0)
            {
                counter2++;
            }
            if (number2 > 0)
            {
                counter1++;
            }
            else if (number2 < 0)
            {
                counter2++;
            }
            if (number3 > 0)
            {
                counter1++;
            }
            else if (number3 < 0)
            {
                counter2++;
            }
            Console.WriteLine("There are " + counter1 + " positive" + " and " + counter2 + " negative numbers");
        }
        static void task_4()
        {
            int number1 = 0, number2 = 0, num = 0;
            Console.Write("Enter first number: ");
            try
            {
                number1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Enter second number: ");
            try
            {
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (number1 != number2)
            {
                num = number1;
                number1 = number1 + number2;
                number2 = number2 + num;
            }
            else if (number1 == number2)
            {
                number1 = 0;
                number2 = 0;
            }
            Console.WriteLine("A = " + number1);
            Console.WriteLine("B = " + number2);
        }
        static void task_5()
        {
            int number = 0;
            bool TrueOrFalse = false;
            string IsOrIsNot;
            Console.Write("Enter a number: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (number % 2 == 0)
            {
                TrueOrFalse = true;
            }
            else
            {
                TrueOrFalse = false;
            }
            if (TrueOrFalse)
            {
                IsOrIsNot = " is ";
            }
            else
            {
                IsOrIsNot = " is not ";
            }
            Console.WriteLine("Number " + number + IsOrIsNot + "even number");
        }
        static void task_6()
        {
            int num1 = 0;
            string OdVymir = "";
            Console.WriteLine(" 1 - дециметр\n 2 - кiлометр\n 3 - метр\n 4 - мiлiметр\n 5 - сантиметр\n");
            Console.Write("Введiть число вiд 1 до 5, щоб обрати одиницi вимiрювання: ");
            try
            {
                num1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Введiть число у цих одиницях вимiрювання: ");
            double num2 = 0, num3 = 0;
            try
            {
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            num3 = num2;
            if (num1 > 5 || num1 < 1)
            {
                Console.WriteLine("Ви обрали неправильне число, спробуйте перезапустити програму і ще раз ввести чило від 1 до 5");
            }
            else if (num1 == 1)
            {
                num2 /= 10;
                OdVymir = "дц";
                Console.WriteLine(num3 + OdVymir + " " + " = " + num2 + "m");
            }
            else if (num1 == 2)
            {
                num2 *= 1000;
                OdVymir = "km";
                Console.WriteLine(num3 + OdVymir + " " + " = " + num2 + "m");
            }
            else if (num1 == 3)
            {
                OdVymir = "m";
                Console.WriteLine(num3 + OdVymir + " " + " = " + num2 + "m");
            }
            else if (num1 == 4)
            {
                num2 /= 1000;
                OdVymir = "mm";
                Console.WriteLine(num3 + OdVymir + " " + " = " + num2 + "m");
            }
            else if (num1 == 5)
            {
                num2 /= 100;
                OdVymir = "cm";
                Console.WriteLine(num3 + OdVymir + " " + " = " + num2 + "m");
            }
        }
        static void task_7()
        {
            int C = 0;
            int num = 0;
            Console.WriteLine(" 1 - North\n 2 - West \n 3 - South \n 4 - East");
            Console.Write("Enter the initial direction of movement: ");
            try
            {
                C = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (C == 1)
            {
                num = 1;
            }
            else if (C == 2)
            {
                num = 2;
            }
            else if (C == 3)
            {
                num = 3;
            }
            else if (C == 4)
            {
                num = 0;
            }
            else
            {
                Console.WriteLine("Incorrect data, restart the program");
                num = 10;
            }
            if (num != 10)
            {
                int num2 = 0;
                Console.WriteLine(" 0 - continue movement\n 1 - turn left\n -1 - turn right");
                Console.Write("Enter where to move: ");
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                if (num2 == 0)
                {
                    num += 0;
                }
                else if (num2 == 1)
                {
                    ++num;
                }
                else if (num2 == -1)
                {
                    --num;
                }
                if (num == 4)
                {
                    num = 0;
                }
                if (num == -1)
                {
                    num = 3;
                }
                if (num == 0)
                {
                    Console.WriteLine("Robot is moving on East");
                }
                else if (num == 1)
                {
                    Console.WriteLine("Robot is moving on North");
                }
                else if (num == 2)
                {
                    Console.WriteLine("Robot is moving on West");
                }
                else if (num == 3)
                {
                    Console.WriteLine("Robot is moving on South");
                }
            }
        }
        static void task_8()
        {
            int age = 0;
            Console.Write("Введiть вiк вiд 20 до 69 рокiв: ");
            try
            {
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            if (age < 20 || age >= 70)
            {
                Console.WriteLine("Невiрний вiк, спробуйте перезапустити програму");
            }
            else if (age >= 20 || age <= 69)
            {
                int age1 = 0;
                if (age < 30)
                {
                    age1 += 20;
                    age -= 20;
                }
                else if (age >= 30 && age < 40)
                {
                    age1 += 30;
                    age -= 30;
                }
                else if (age >= 40 && age < 50)
                {
                    age1 += 40;
                    age -= 40;
                }
                else if (age >= 50 && age < 60)
                {
                    age1 += 50;
                    age -= 50;
                }
                else if (age >= 60 && age < 70)
                {
                    age1 += 60;
                    age -= 60;
                }
                if (age == 0 || age == 5 || age == 6 || age == 7 || age == 8 || age == 9)
                {
                    Console.WriteLine("Ваш вiк " + (age1 + age) + " рокiв");
                }
                else if (age == 1)
                {
                    Console.WriteLine("Ваш вiк " + (age1 + age) + " рiк");
                }
                else if (age == 2 || age == 3 || age == 4)
                {
                    Console.WriteLine("Ваш вiк " + (age1 + age) + " роки");
                }
            }

        }
    }
}