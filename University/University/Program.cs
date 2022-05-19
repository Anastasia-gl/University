namespace University
{
    class Program
    {
        public static void Main(String[] args)
        {
            var getData = new Services.GetData();
            getData.GetPrint(new Services.PersonInfo());
            getData.GetInfo(new Services.MarkTable());
            getData.GetTotal(new Services.CountTotal());
            Console.WriteLine("\nSorted:");
            getData.GetPrint(new Services.Sort());
        }
    }
}