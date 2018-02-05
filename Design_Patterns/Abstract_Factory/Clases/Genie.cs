namespace Abstract_Factory.Clases
{
    using Interfaces;

    public class Genie : IDumb
    {
        public string Name()
        {
            return "Genie";
        }
    }
}