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

            FileLogger.LogMessage("Starting calculation");

            try
            {
                BerResult berResult = (new BerCalculator(inputFileOne, inputFileTwo)).CalculateBer();
                PrintResult(berResult);
                LogResult(berResult);
            } catch (Exception exception)
            {
                Console.WriteLine("Error occured. Check input files.");
                return;
            }

            FileLogger.LogMessage("Calculation closed");
        }
        static void PrintResult(BerResult berResult)
        {
            Console.WriteLine("Ber: " + berResult.Result);
            Console.WriteLine("Total number of bits: " + berResult.TotalNumberOfBits);
            Console.WriteLine("Error bits: " + berResult.ErrorBits);
            Console.WriteLine("Time elapsed: " + GetCalculationTimeInMiliseconds(berResult) + "ms");
        }

        static void LogResult(BerResult berResult)
        {
            FileLogger.LogMessage("Ber: " + berResult.Result);
            FileLogger.LogMessage("Total number of bits: " + berResult.TotalNumberOfBits);
            FileLogger.LogMessage("Error bits: " + berResult.ErrorBits);
            FileLogger.LogMessage("Time elapsed: " + GetCalculationTimeInMiliseconds(berResult) + "ms");
        }

        static string GetCalculationTimeInMiliseconds(BerResult berResult)
        {
            TimeSpan elapsed = berResult.EndTime - berResult.StartTime;

            return elapsed.TotalMilliseconds.ToString();
        }
    }
}