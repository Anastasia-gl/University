namespace University.Services
{
    internal class PersonInfo : Interfaces.Services.IPrint
    {
        public void Print()
        {
            Models.Person a = new Models.Person();
            Console.WriteLine(a.Name + " " + a.Surname + " " + a.Group);
        }
    }
}
