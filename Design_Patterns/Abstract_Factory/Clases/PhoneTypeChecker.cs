namespace Abstract_Factory.Clases
{
    using Interfaces;
    using System;

    public enum Manufactura
    {
        SAMSUNG,
        HTC,
        NOKIA
    }

    public class PhoneTypeChecker
    {
        private IPhoneFactory factory;
        private readonly Manufactura manu;

        public PhoneTypeChecker(Manufactura m)
        {
            manu = m;
        }

        public void CheckProducts()
        {
            switch (manu)
            {
                case Manufactura.SAMSUNG:
                    factory = new SamsungFactory();
                    break;

                case Manufactura.HTC:
                    factory = new HtcFactory();
                    break;

                case Manufactura.NOKIA:
                    factory = new NokiaFactory();
                    break;
            }

            Console.WriteLine(manu.ToString() + ":\nSmart Phone: " + factory.GetSmart().Name() + "\nDumb Phone: " + factory.GetDumb().Name());
        }
    }
}