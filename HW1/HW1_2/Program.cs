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
            
            string checkDigitString;
            int checkDigit = (11 - sum % 11) % 11; ;

            switch (checkDigit)
            {
                case 11:
                    checkDigitString = "0";
                    break;
                case 10:
                    checkDigitString = "X";
                    break;
                default:
                    checkDigitString = checkDigit.ToString();
                    break;
            }
            Console.WriteLine(digits + checkDigitString);

        }
    }
}
