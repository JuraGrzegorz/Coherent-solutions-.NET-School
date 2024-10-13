namespace HW1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numericalSystem = 12;
            int numberPosition = 11-1;
            int numberOfOccurrence = 2;

            Console.WriteLine("enter two integers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            for (int i = a; i <=b; i++)
            {
                int numerator = i;
                int counter = 0;
                while (numerator !=0)
                {
                    if (numerator % numericalSystem == numberPosition)
                    {
                        counter++;
                    }
                    numerator = numerator / numericalSystem;
                }
                if (counter == numberOfOccurrence)
                    Console.Write(i + " ");
            }
        }
    }
}
