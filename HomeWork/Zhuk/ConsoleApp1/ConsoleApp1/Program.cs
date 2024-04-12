namespace Zharskyi_homework_7
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
            else if (task_num == 9)
            {
                task_9();
            }
            else if (task_num == 10)
            {
                task_10();
            }
            else if (task_num == 11)
            {
                task_11();
            }
            else if (task_num == 12)
            {
                task_12();
            }
            else if (task_num == 13)
            {
                task_13();
            }
            else if (task_num == 14)
            {
                task_14();
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
        }
        static void task_1()
        {
            string str = "";
            Console.Write("Enter the word: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (str.Length >= 3)
            {
                Console.Write("3rd symbol is ");
                for (int i = 0; i < str.Length; i++)
                {
                    if (i == 2)
                    {
                        Console.Write(str[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("You`ve entered too short word");
            }
        }
        static void task_2()
        {
            string str = "", str2 = "", str4 = "";
            Console.Write("Enter the word: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (str.Length >= 4)
            {
                if (str[1] == str[3])
                {
                    Console.Write("2nd and 4th symbols are equal");
                }
                else
                {
                    Console.Write("2nd and 4th symbols are not equal");
                }
            }
            else
            {
                Console.WriteLine("You`ve entered too short word");
            }
        }
        static void task_3()
        {
            string str = "";
            Console.Write("Enter the name of the club: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (char i in str)
            {
                Console.WriteLine(i);
            }
        }
        static void task_4()
        {
            string str = "", str2 = "";
            Console.Write("Enter the word: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < str.Length; i += 2)
            {
                str2 += str[i];
            }
            Console.WriteLine(str2);
        }
        static void task_5()
        {
            string str = "";
            int counter1 = 0, counter2 = 0;
            Console.Write("Enter the text: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+')
                {
                    counter1++;
                }
                if (str[i] == '*')
                {
                    counter2++;
                }
            }
            Console.WriteLine($"There are {counter1} \'+\' and  {counter2} \'*\'");
        }
        static void task_6()
        {
            string str = "", str2 = "";
            Console.Write("Enter the text: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'e')
                {
                    str2 += 'i';
                }
                else
                {
                    str2 += str[i];
                }
            }
            Console.WriteLine("Text after changing of e to i");
            Console.WriteLine(str2);
        }
        static void task_7()
        {
            string str = "", str2 = "";
            Console.Write("Enter the text: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    str2 += '_';
                }
                else
                {
                    str2 += str[i];
                }
            }
            Console.WriteLine("Text after changing of all the spaces in  \'_\'");
            Console.WriteLine(str2);
        }
        static void task_8()
        {
            string str = "", str2 = "";
            Console.Write("Enter the text: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (char i in str)
            {
                if (Char.IsDigit(i))
                {
                    str2 += i;
                }
            }
            Console.WriteLine("All the digits of the text:");
            Console.WriteLine(str2);
        }
        static void task_9()
        {
            string str = "";
            int counter = 0, maxDig = 0, dig = 0;
            Console.Write("Enter the text: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (char i in str)
            {
                if (Char.IsDigit(i))
                {
                    dig = Convert.ToInt32(i.ToString());
                    counter += dig;
                    if (dig > maxDig)
                    {
                        maxDig = dig;
                    }
                }
            }
            Console.WriteLine("Max digit of the text is " + maxDig);
            Console.WriteLine("The sum of digits is " + counter);
        }
        static void task_10()
        {
            string country = "", capital = "";
            int count1 = 0;
            Console.Write("Enter how many countries and capitals will you enter: ");
            try
            {
                count1 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string[] arr1 = new string[count1];
            string[] arr2 = new string[count1];
            for (int i = 0; i < count1; i++)
            {
                Console.Write("Enter the country: ");
                try
                {
                    country = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Write($"Enter the capital of {country}: ");
                try
                {
                    capital = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                arr1[i] = country;
                arr2[i] = capital;
            }
            for (int i = 0; i < count1; i++)
            {
                Console.WriteLine($"{arr2[i]} is the capital of {arr1[i]} ");
            }
        }
        static void task_11()
        {
            string str1 = "", str2 = "", str3 = "";
            Console.Write("Enter first word with the capital letter: ");
            try
            {
                str1 = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter second word with the capital letter: ");
            try
            {
                str2 = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Enter third word with the capital letter: ");
            try
            {
                str3 = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string str = "";
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (char.IsUpper(str1[i]))
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str1[i] == str[j])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        str += str1[i];
                    }
                }
                count = 0;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                if (char.IsUpper(str2[i]))
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str2[i] == str[j])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        str += str2[i];
                    }
                }
                count = 0;
            }
            for (int i = 0; i < str3.Length; i++)
            {
                if (char.IsUpper(str3[i]))
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (str3[i] == str[j])
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                        str += str3[i];
                    }
                }
                count = 0;
            }
            Console.WriteLine("Capital letters from 3 strings in one word: " + str);
        }
        static void task_12()
        {
            string[] arr = new string[10];
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter {i + 1} word: ");
                try
                {
                    str = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                arr[i] = str;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{i + 1} word is {arr[i]}\n");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        static void task_13()
        {
            string str = "";
            Console.Write("Enter the text: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int n = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    n++;
                }
            }
            string[] strings = new string[n];
            strings = str.Split(' ');
            for (int i = strings.Length - 1; i >= 0; i--)
            {
                Console.Write(strings[i] + ' ');
            }
        }
        static void task_14()
        {
            string str = "";
            Console.Write("Enter the text: ");
            try
            {
                str = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int n = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    n++;
                }
            }
            string[] strings = new string[n];
            strings = str.Split(' ');
            int counter = -1;
            int CountN = 0, countP = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                counter = strings[i].IndexOf('н');
                if (counter == 0)
                {
                    CountN++;
                }
                counter = -1;
                counter = strings[i].IndexOf('р');
                if (counter == strings[i].Length - 1)
                {
                    countP++;
                }
                counter = -1;
            }
            Console.WriteLine($"В текстi {CountN} слова починаючихся з букви н i {countP} слiв, що закiнчуються на букву р");
        }
    }
}
