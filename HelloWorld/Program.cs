namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Howdy Y'all!!");
             Console.ReadKey(); // What happens if you run the app without this line?*/

            //Add a feature to your application that will only print animal names that have 5 characters or more.
            /*var animals = new string[] { "Triceratops", "Cat", "Gorilla", "Corgi", "Toucan", "Bird" };

            foreach (var animal in animals)
            {
                if (animal.Length >= 5)
                {
                Console.WriteLine(animal);
                }
            }*/

            // Add a feature to your application that will accept an input that asks the user to pick from at least 3 different greetings.
            // Obviously the default option should be "Southern"

            Console.WriteLine(@$"Please Pick a Time of Greeting
1. Southern
2. Northern
3. Western");
            string input = Console.ReadLine();

            if (input == "2")
            {
                Console.Clear();
                Console.WriteLine("Good Day!");
                Console.ReadLine();
            }
            else if (input == "3")
                {
                Console.Clear();
                Console.WriteLine("What Up!");
                Console.ReadLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Howdy Y'all!!");
                Console.ReadLine();
            }

        }
    }
}