namespace University.Interfaces.Services
{
    public interface IGetData
    {
        public void GetInfo(IMakeTable print);

        public void GetPrint(IPrint person);

        public void GetTotal(ICountTotal count);
    }
}
