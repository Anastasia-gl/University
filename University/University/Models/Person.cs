namespace University.Models
{
    internal class Person
    {
        internal readonly string Name;

        internal readonly string Surname;

        internal readonly string Group;

        public string[] Subject { get; set; } = new string[] { "Operate system", "C++ and C", "Java advanced", "DataSciens", "Prof. English" };

        public int[] Mark { get; set; } = new int[5] { 78, 60, 80, 95, 65 };

        public int TotalMark { get; set; }

        public Person()
        {
            Name = "Anastasia";
            Surname = "Glusenko";
            Group = "PI-20-9";
        }
    }
}
