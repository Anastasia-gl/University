namespace University.Services
{
    internal class CountTotal: Interfaces.Services.ICountTotal
    {

        MarkTable mark = new MarkTable();
        Models.Person person = new Models.Person();

        public void CountTotalMark()
        {
            mark.FillTable();
            for (int i = 0; i < mark.Items.GetLength(0); i++)
            {
                person.TotalMark += int.Parse(mark.Items[i, 1]);
            }
        }

        public void Print()
        {
            Console.WriteLine("\nTotal mark: " + person.TotalMark);
        }
    }
}
