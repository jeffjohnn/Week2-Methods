using System.Linq.Expressions;

CreateMenu();

void CreateMenu()
{
    try
    {
        // Construct the menu
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Say Hello ");
        Console.WriteLine("2. Add Numbers ");
        Console.WriteLine("3. Exit ");
        Console.Write("Choose an option: "); // Input data 

        // Accept the user's choice 
        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                SayHello();
                break;
            case "2":
                AddNumbers();
                break;
            case "3":
                break;
            default:
                Console.WriteLine("Invalid choice, please try again");
                break;
            }
        }
        catch (Exception ex)
    {
            Console.WriteLine($"Error. {ex.Message}");
        }
    }

static void SayHello()
{
    Console.WriteLine("Hello World");
}

static void AddNumbers()
{
    Console.WriteLine("Enter the first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int result = firstNumber + secondNumber;
    Console.WriteLine($"The result is: {result}");
}
