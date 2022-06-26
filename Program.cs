using System;

namespace psiz_p_zd4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleDataGenerator.GenerateTest1("1A.bin", "1B.bin");

            Console.Write("Enter first file path: ");
            string inputFileOne;
            inputFileOne = Console.ReadLine();

            Console.Write("Enter second file path: ");
            string inputFileTwo;
            inputFileTwo = Console.ReadLine();

            try
            {
                BerResult berResult = (new BerCalculator(inputFileOne, inputFileTwo)).CalculateBer();
                Console.WriteLine("Ber: " + berResult.Result);
                Console.WriteLine("Total number of bits: " + berResult.TotalNumberOfBits);
                Console.WriteLine("Error bits: " + berResult.ErrorBits);
            } catch (Exception exception)
            {
                Console.WriteLine("Error occured. Check input files.");
                return;
            }

        }
    }
}