namespace University.Interfaces.Services
{
    public interface ISort : IPrint
    {
        public string Sorting(string[,] subject, string result, int min, int max);
    }
}
