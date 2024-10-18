namespace HW1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numericalSystem = 12;
            int numberPosition = 10;
            int numberOfOccurrence = 2;

            Console.WriteLine("enter two integers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            
            if (a > b)
            {
                int holder=a;
                a = b;
                b = holder;
            }

            for (int i = a; i <=b; i++)
            {
                int numerator = Math.Abs(i);
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
