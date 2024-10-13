namespace HW1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements in the integer array");

            int arraySize=int.Parse(Console.ReadLine());

            int[] userDigits= new int[arraySize];
            int[] outputValues= new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                userDigits[i]=int.Parse(Console.ReadLine());
            }

            int index = 0;
            for (int i = 0; i < arraySize; i++)
            {
                int j;
                for (j = 0; j < arraySize; j++)
                {
                    if (i!=j && userDigits[i] == userDigits[j])
                    {
                        break;
                    }
                }
                if (j == arraySize)
                {
                    outputValues[index++] = userDigits[i];
                }
            }

            for (int i = 0; i < index; i++)
            {
                Console.Write(outputValues[i]+" ");
            }

        }

    }   
}
