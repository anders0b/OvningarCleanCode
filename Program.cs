namespace OvningarCleanCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testMethods = new TestMethods();
            testMethods.InvertedStringMethod("Megabanan");
            Console.WriteLine("------");
            //testMethods.Calculator();
            Console.WriteLine("------");
            testMethods.SortedArray(new List<int> { 1, 100, 7, 602354, 23, 25 });
            Console.WriteLine("------");
            testMethods.Palindrome("madam");
            Console.WriteLine("------");
            testMethods.ConvertTemperature("100");


        }
    }
}
