using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParseConvert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.WriteLine("Enter the String");
            word=Console.ReadLine();
            try
            {
                /*int tryParsedNum;
                bool flag=int.TryParse(word,out tryParsedNum);
                Console.WriteLine($"The number is {tryParsedNum}");
                float parsedNum = float.Parse(word);
                Console.WriteLine($"The number is {parsedNum}"); */
                double convertedNum = Convert.ToDouble(word);
                Console.WriteLine($"The number is {convertedNum}");

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!!"+ex.Message);
            }
            
        }
    }
}
