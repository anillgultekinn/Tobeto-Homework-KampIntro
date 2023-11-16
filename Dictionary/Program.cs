namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> person = new MyDictionary<int, string>();
            person.Add(1, "Messi");
            person.Add(2, "Ronaldo");

        }
    }
}