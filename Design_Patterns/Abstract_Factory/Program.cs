namespace Abstract_Factory
{
    using Clases;
    using System;

    public static class Program
    {
        private static void Main(string[] args)
        {
            PhoneTypeChecker checker = new PhoneTypeChecker(Manufactura.SAMSUNG);

            checker.CheckProducts();

            Console.ReadLine();

            checker = new PhoneTypeChecker(Manufactura.HTC);

            checker.CheckProducts();
            Console.ReadLine();

            checker = new PhoneTypeChecker(Manufactura.NOKIA);

            checker.CheckProducts();
            Console.Read();
        }
    }
}