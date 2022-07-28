namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Number");

            MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            int integerOutput = maximumNumberCheck.MaximumIntegerNumber(99, 110, 150);
            Console.WriteLine(integerOutput);
        }
    }
}