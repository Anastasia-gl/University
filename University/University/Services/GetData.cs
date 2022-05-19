namespace University.Services
{
    internal class GetData:Interfaces.Services.IGetData
    {
        public void GetInfo(Interfaces.Services.IMakeTable print)
        {
            print.FillTable();
            print.Print();
        }

        public void GetPrint(Interfaces.Services.IPrint persInfo)
        {
            persInfo.Print();
        }

        public void GetTotal(Interfaces.Services.ICountTotal countTotal)
        {
            countTotal.CountTotalMark();
            countTotal.Print();
        }
    }
}
