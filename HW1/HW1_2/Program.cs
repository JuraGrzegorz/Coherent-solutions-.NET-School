using System.Diagnostics;

namespace HW1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string of 9 digit characters");

            string digits=Console.ReadLine();

            int numberOfDigits=digits.Length;
            int sum = 0;

            for (int i = 0; i<numberOfDigits; i++)
            {
                int charVal = int.Parse(digits[i].ToString());
                sum=sum+charVal*(numberOfDigits+1-i);
            }
            
            string checkDigit;
            sum = sum %11;
 
            if (11-sum == 10)
            {
                checkDigit = 'X'.ToString();
            }
            else
            {
                checkDigit=(11-sum).ToString();
            }
            Console.WriteLine(digits + checkDigit);

        }
    }
}
