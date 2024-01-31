// See https://aka.ms/new-console-template for more information
string userChoice = "";
Console.WriteLine("Hello, World!");
do
{
    Console.WriteLine("Would you like to continue (y/n)?");
    userChoice = Console.ReadLine().ToLower().Trim();
    switch (userChoice)
    {
        case "y":
            Console.WriteLine("Hello, World!");
            break;
        case "n":
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Enter 'y' or 'n'");
            break;
    }

} while (userChoice == "y");

Console.WriteLine("-------------------------------------------------------------------------");

bool willContinue = true;
while (willContinue)
{
    Console.Write("Please enter a number: ");
    userChoice = Console.ReadLine();
    bool success = int.TryParse(userChoice, out int userNumber);
    if (success)
    {
        for (int i = userNumber; i >= 0; i--) { Console.Write(i + " "); }
        Console.WriteLine("");
        for (int i = 0; i <= userNumber; i++) { Console.Write(i + " "); }
        Console.WriteLine(" ");
        Console.WriteLine("Would you like to continue? (y/n)");
        string toContinue = Console.ReadLine().ToLower().Trim();
        switch (toContinue)
        {
            case "y":
                willContinue = true;
                break;
            case "n":
                Console.WriteLine("Goodbye!");
                willContinue = false;
                break;
            default:
                Console.WriteLine("Invalid entry. Enter 'y' or 'n' only");
                willContinue = false;
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid Entry. Please enter a number.");
    }
}
Console.WriteLine("-------------------------------------------------------------------------");

string passWord = "";
bool isCorrect = false;
int counter = 0;
while (isCorrect == false)
{
    Console.WriteLine("Please enter your combination: ");
    passWord = Console.ReadLine().Trim();
    if (passWord != "13579")
    {
        counter++;
        if (counter == 5)
        {
            Console.WriteLine("There are too many incorrect attempt. Goodbye!");
            break;
        }
        Console.WriteLine($"Incorrect Combination. Please try again! You have {5 - counter} attempt(s) left.");
    }
    else
    {
        Console.WriteLine("Welcome!");
        isCorrect = true;
    }
}
Console.WriteLine("--------------------------------------------------------------------------------");
do
{
    Console.WriteLine("Please enter your combination: ");
    passWord = Console.ReadLine().Trim();
    if (passWord != "13579")
    {
        counter++;
        if (counter == 5)
        {
            Console.WriteLine("There are too many incorrect attempt. Goodbye!");
            break;
        }
        Console.WriteLine($"Incorrect Combination. Please try again! You have {5 - counter} attempt(s) left.");
    }
    else
    {
        Console.WriteLine("Welcome!");
        isCorrect = true;
    }
} while (isCorrect == false);
Console.Read(); 
static bool GrantAcess()
{
    string passWord = "";
    bool isCorrect = false;
    int counter = 0;
    while (isCorrect == false)
    {
        Console.WriteLine("Please enter your combination: ");
        passWord = Console.ReadLine().Trim();
        if (passWord != "13579")
        {
            counter++;
            if (counter == 5)
            {
                Console.WriteLine("There are too many incorrect attempt. Goodbye!");
                break;
            }
            Console.WriteLine($"Incorrect Combination. Please try again! You have {5 - counter} attempt(s) left.");
        }
        else
        {
            Console.WriteLine("Welcome!");
            isCorrect = true;
        }
    }
    return isCorrect;
}
GrantAcess();