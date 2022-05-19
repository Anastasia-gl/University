namespace University.Services
{
    internal class Sort:Interfaces.Services.ISort
    {
        MarkTable markTable = new MarkTable();
        Models.Marks marks = new Models.Marks();

        public void Print()
        {
            markTable.FillTable();

            Console.Write("\nYou have passed it on 5:\n");
            Console.WriteLine(Sorting(markTable.Items, marks.GreatMark, 90, 100));

            Console.Write("\nYou have passed it on 4:\n");
            Console.WriteLine(Sorting(markTable.Items, marks.MiddleMark, 75, 89));

            Console.Write("\nYou have passed it on 3:\n");
            Console.WriteLine(Sorting(markTable.Items, marks.LowMark, 60, 74));
        }

        public string Sorting(string[,] subject, string result, int min, int max)
        {
            int mark = 0;
            int count = 0;

            for (int i = 0; i < subject.GetLength(0); i++)
            {
                mark = int.Parse(subject[i, 1]);

                if (min <= mark && mark <= max)
                {
                    count++;
                    if (count == 1)
                    {
                        result = subject[i, 0] + "\n";
                    }
                    else if (count > 1)
                    {
                        result += subject[i, 0];
                    }
                }
            }

            return result;
        }
    }
}
