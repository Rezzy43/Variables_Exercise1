namespace Variables_Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring and Initializing Variables
            string name = "Michael";
            int age = 43;
            char middleInitial = 'J';
            bool isOver18 = true;
            double currentTemp = 91.2;
            decimal currentPrice = 29.99m;

            // Writing the variables to the Console
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Is Over 18: {isOver18}");
            Console.WriteLine($"Current Temp: {currentTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");
        }
    }
}
