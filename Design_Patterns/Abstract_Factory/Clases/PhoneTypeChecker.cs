namespace Abstract_Factory.Clases
{
    using Interfaces;
    using System;

    public enum MANUFACTURERS
    {
        SAMSUNG,
        HTC,
        NOKIA
    }

    public class PhoneTypeChecker
    {
        private IPhoneFactory factory;
        private readonly MANUFACTURERS manu;

        public PhoneTypeChecker(MANUFACTURERS m)
        {
            manu = m;
        }

        public void CheckProducts()
        {
            switch (manu)
            {
                case MANUFACTURERS.SAMSUNG:
                    factory = new SamsungFactory();
                    break;

                case MANUFACTURERS.HTC:
                    factory = new HTCFactory();
                    break;

                case MANUFACTURERS.NOKIA:
                    factory = new NokiaFactory();
                    break;
            }

            Console.WriteLine(manu.ToString() + ":\nSmart Phone: " + factory.GetSmart().Name() + "\nDumb Phone: " + factory.GetDumb().Name());
        }
    }
}