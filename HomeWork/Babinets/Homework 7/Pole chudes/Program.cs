namespace Pole_Chudes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.InputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Давайте пограємо в гру в слова? Вгадай моє таємне слово. Містить 6 букв. Причому вгадувати можна по одній букві за раз. Вам дано 6 неправильних здогадок.");
                bool continues = true;
                while (continues)
                {
                    string[] word = { "п", "р", "и", "в", "і", "т" };
                    string[] guesspace = { "_", "_", "_", "_", "_", "_" };

                    int maxattempt = 6;
                    int actualattempt = word.Length * maxattempt;

                    for (int i = 0; i < word.Length; i++)
                    {
                        int attemptfirst = maxattempt;

                        while (attemptfirst > 0)
                        {
                            Console.WriteLine("Ваше слово: " + string.Join(" ", guesspace));
                            Console.WriteLine($"Введіть, будь ласка, {i + 1}-у літеру.");
                            string input = Console.ReadLine();
                            if (input == word[i])
                            {
                                guesspace[i] = input;
                                Console.WriteLine("Правильно!");
                                break;
                            }
                            else
                            {
                                attemptfirst--;
                                Console.WriteLine($" Неправильно! Спробуйте ще. Залишилось {attemptfirst} неправильних варіантів.");

                                if (i != word.Length - 1 && attemptfirst == 0)
                                {
                                    Console.WriteLine($"Ви використали всі спроби для літери {word[i]}. Переходимо до наступної літери.");
                                    break;
                                }
                            }

                        }

                        if (Array.IndexOf(guesspace, "_") == -1)
                        {
                            Console.WriteLine("Вітаємо! Ви виграли. Ваше слово: " + string.Join("", guesspace));
                            break;
                        }

                        if (i == word.Length - 1)
                        {
                            Console.WriteLine("Ви програли. Спробуйте наступного разу!. Натисніть клавішу Enter .");
                            ConsoleKeyInfo key1 = Console.ReadKey();
                            if (key1.Key != ConsoleKey.Enter)
                            {
                                return;
                            }
                        }
                    }

                    Console.Clear();

                    Console.WriteLine(" Якщо бажаєте продовжити натисніть пробіл. Для виходу натисніть E.  ");
                    ConsoleKeyInfo keywin = Console.ReadKey();
                    if (keywin.Key == ConsoleKey.Spacebar)
                    {
                        continues = true;
                    }
                    else if (keywin.Key == ConsoleKey.E)
                    {
                        Environment.Exit(0);

                    }
                    else
                    {
                        Console.WriteLine("Натиснуто невідому клавішу. Спробуйте ще раз.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Ви ввели некоректне значення.");
            }
        }
    }
}






