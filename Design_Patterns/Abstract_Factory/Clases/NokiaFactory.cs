namespace Abstract_Factory.Clases
{
    using Interfaces;

    public class NokiaFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Lumia();
        }

        public IDumb GetDumb()
        {
            return new Asha();
        }
    }
}