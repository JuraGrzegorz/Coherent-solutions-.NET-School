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

            int resSize = 0;
            for (int i = 0; i < arraySize; i++)
            {
                int j;
                for (j = 0; j < resSize; j++)
                {
                    if (outputValues[j] == userDigits[i])
                    {
                        break;
                    }
                }
                if (j == resSize)
                {
                    outputValues[resSize++] = userDigits[i];
                }
            }

            for (int i = 0; i < resSize; i++)
            {
                Console.Write(outputValues[i]+" ");
            }

        }

    }   
}
