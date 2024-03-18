

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // string userName;
            Console.WriteLine("Vvvedit svoje imja:");
            string userName = Console.ReadLine();
         //   int number;
            Console.WriteLine("vvedit svoje chyslo:");
            double number = Convert.ToDouble(Console.ReadLine());
            string id = userName + number;
            Console.WriteLine(" vash identyf"+id);

        }

    }


}

