namespace Abstract_Factory.Clases
{
    using Interfaces;

    public class HTCFactory : IPhoneFactory
    {
        public ISmart GetSmart()
        {
            return new Titan();
        }

        public IDumb GetDumb()
        {
            return new Genie();
        }
    }
}