namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}. Nice to meet you!");
        }
    }
}