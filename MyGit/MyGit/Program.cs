namespace MyGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            bool _ = int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine($"Hello {name}, Your Age Is: {age}");
        }
    }
}
