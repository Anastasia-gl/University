namespace University.Services
{
    internal class MarkTable : Interfaces.Services.IMakeTable
    {
        Models.Person person = new Models.Person();

        public string[,] Items { get; set; } = new string[5, 2];

        public void FillTable()
        {
            int index = 0;
            int indexNum = 0;
            for (int i = 0; i < Items.GetLength(0); i++)
            {
                Items[i, 0] += person.Subject[index++];
                Items[i, 1] = person.Mark[indexNum++].ToString();
            }
        }

        public void Print()
        {
            for (int i = 0; i < Items.GetLength(0); i++)
            {
                for (int j = 0; j < Items.GetLength(1); j++)
                {
                    Console.Write(Items[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }
    }
}
