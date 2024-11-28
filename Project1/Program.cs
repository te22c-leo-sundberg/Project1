using System.Numerics;
int choice;

Console.WriteLine("Choose a number from 0 to infinite and I'll write it out for you");
choice = GetNumber();
Console.WriteLine(choice);
Console.ReadLine();

static int GetNumber()
{
    bool success = false; 
    string input;
    int result = 0;
    while (!success)
    {
        input = Console.ReadLine();
        success = int.TryParse(input, out result);
        if (result < 0)
        {
            success = false;
        }
    }
        return result;
}
static bool GetBool()
{
    bool success = false;
    string input = "";
    while (!success)
    {
        Console.WriteLine("[Yes] or [No]?");
        input = Console.ReadLine().ToUpper();
        if (input == "YES")
        {
            return true;
        }
        else if (input == "NO")
        {
            return false;
        }
    }
    return false;
}