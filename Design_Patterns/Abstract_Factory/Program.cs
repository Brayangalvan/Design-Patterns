namespace Abstract_Factory
{
    using Clases;
    using System;

    public class Program
    {
        private static void Main(string[] args)
        {
            PhoneTypeChecker checker = new PhoneTypeChecker(MANUFACTURERS.SAMSUNG);

            checker.CheckProducts();

            Console.ReadLine();

            checker = new PhoneTypeChecker(MANUFACTURERS.HTC);

            checker.CheckProducts();
            Console.ReadLine();

            checker = new PhoneTypeChecker(MANUFACTURERS.NOKIA);

            checker.CheckProducts();
            Console.Read();
        }
    }
}