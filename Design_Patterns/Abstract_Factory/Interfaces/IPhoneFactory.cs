namespace Abstract_Factory.Interfaces
{
    public interface IPhoneFactory
    {
        ISmart GetSmart();

        IDumb GetDumb();
    }
}