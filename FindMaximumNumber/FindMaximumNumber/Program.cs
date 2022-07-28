namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find Maximum Number");


            //MaximumNumberCheck maximumNumberCheck = new MaximumNumberCheck();
            //int integerOutput = maximumNumberCheck.MaximumIntegerNumber(99, 110, 150);
            //Console.WriteLine(integerOutput);

            //double doubleOutput = maximumNumberCheck.MaximumFloatNumber(111.1567, 234.5466, 668.9890);
            //Console.WriteLine(doubleOutput);

            //string stringOutput = maximumNumberCheck.MaximumStringNumber("22", "33", "44");
            //Console.WriteLine(stringOutput);

            int[] intArray = { 12, 45, 67, 20, 90, 47 };
            GenericMaximum<int> genericMaximum = new GenericMaximum<int>(intArray);
            genericMaximum.PrintMaxValue();

            double[] doubleArray = { 120.12, 340.45, 45.65, 680.43, 765.52 };
            GenericMaximum<double> genericMaximum1 = new GenericMaximum<double>(doubleArray);
            genericMaximum1.PrintMaxValue();

            string[] strings = { "44", "22", "66", "555", "999" };
            GenericMaximum<string> genericMaximum2 = new GenericMaximum<string>(strings);
            genericMaximum2.PrintMaxValue();
        }
    }
}