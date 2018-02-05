namespace Abstract_Factory.Clases
{
    using Interfaces;

    public class SamsungFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new GalaxyS2();
        }

        public IDumb GetDumb()
        {
            return new Primo();
        }
    }
}