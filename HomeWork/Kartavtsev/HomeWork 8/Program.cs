//HomeWork8
    internal class Program
    {
        static void Main(string[] args)
        {
            game_words();
        }
        static void game_words()
        {
            string[] strings = { "чашка", "качка", "термос", "бутилка", "браузер", "зошит", "арбуз", "слово", "окуляри", "телеграма" };
            int rounds = 0;
            Console.WriteLine("Давайте пограємо в гру в слова?");
            Console.WriteLine("Вгадай слово. У тебе є 6 невiрних спроб. Good luck!");
            Console.Write("Введiть скiльки раундiв ви хочете зiграти: ");
            try
            {
                rounds = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            for (int x = 0; x < rounds; x++)
            {
                Console.WriteLine($"Раунд {x+1}");
                Console.WriteLine();
                int random = new Random().Next(0, 10);
                string GuessWord = new string('_', strings[random].Length);
                string GuessLetter = "";
                char[] guessChars = GuessWord.ToCharArray();
                int count = 6, count2 = 6, countInc=0;
                List<string> IncorLet = new List<string>(countInc);
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Ваше слово: {GuessWord}\n");
                    if (countInc > 0)
                    {
                        Console.Write("Невiрнi лiтери: ");
                        for (int l = 0; l < countInc; l++)
                        {
                            Console.Write(IncorLet[l] + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.Write("Вгадайте букву: ");
                    try
                    {
                        GuessLetter = Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    if (GuessLetter.Length == 1)
                    {
                        char letter = GuessLetter[0];
                        bool found = false;
                        for (int j = 0; j < strings[random].Length; j++)
                        {
                            if (strings[random][j] == GuessLetter[0])
                            {
                                guessChars[j] = letter;
                                found = true;
                            }
                        }
                        GuessWord = new string(guessChars);
                        if (found)
                        {
                            Console.WriteLine($"Ви вгадали, буква {GuessLetter} є в словi");
                            count++;
                        }
                        if (!found)
                        {
                            count2--;
                            Console.WriteLine($"У вас лишилось {count2} спроб");
                            countInc++;
                            IncorLet.Add(GuessLetter);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ви ввели некоректнi данi");
                    }
                    if (GuessWord == strings[random])
                    {
                        Console.WriteLine($"Ви вгадали слово {GuessWord}\nВiтаємо!");
                        Console.Write("Натиснiть \"Enter\" для наступного раунда");
                        Console.ReadLine();
                        break;
                    }
                    if (count2 == 0)
                    {
                        Console.WriteLine("Ви програли, у вас скiнчились спроби( ");
                        Console.Write("Натиснiть \"Enter\" для наступного раунда");
                        Console.ReadLine();
                        break;
                    }
                }
                Console.Clear();
            }
        }
    }
}