using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_the_first_acquaintance
{
    public class StringExamples
    {
        // .Net -> System.Int32  ---- Common Types System
        // C#   -> int (abbr)
        // VB   -> Integer (abbr)

        //float f = 0f;
        //System.Single s = 0f;

        public void FunWithString()
        {
            //int? i = null; 
            //string nullString = null;

            //string strEmpty = string.Empty;
            //string path = "C:\\Windows\\System32"; // @ - at serhii@gmail.com
            //string path2 = @"SELECT *
            //                 FROM Employee
            //                 WHERE id = 5"; // SQL-Queries

            //int a = 9; int b = 10;

            //string plus = string.Format("{0} + {1} = {2}", a, b, a + b); // data | view

            //string interpolation = $"{a} + {b} = {a + b}"; // data | view

            //Console.WriteLine(interpolation);

            string str = "Hello"; // 25 mb
            string anotherString = str; // + 25 mb

            Console.WriteLine(str.GetHashCode());
            Console.WriteLine(anotherString.GetHashCode());

            string answer = Console.ReadLine();

            Console.WriteLine(answer.GetHashCode()); // 

        }
    }
}
