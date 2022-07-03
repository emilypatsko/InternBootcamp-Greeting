namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there! What is your first name?");
            var firstName = Console.ReadLine();
            Console.WriteLine("And what is your surname?");
            var lastName = Console.ReadLine();
            if (String.IsNullOrEmpty(lastName))
            {
                if (String.IsNullOrEmpty(firstName))
                {
                    Console.WriteLine("Well, that's just not very helpful, is it.");
                    return;
                }
                Console.WriteLine($"Hello, {firstName}! I see you only have one name, but that's fine!");
                return;
            }
            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }
    }
}