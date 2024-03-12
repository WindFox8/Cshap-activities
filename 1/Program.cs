/* Write a program that receives a character inputted by the user and determines whether the character is an uppercase letter, a lowercase letter, a number, or a special symbol. */

bool repeat = true;

while (repeat)
{
    CheckChar();
    
    string repeatEntry = "";

    do
    {
        Console.Write("Would you like to check another character? [y/n]: ");
        repeatEntry = Console.ReadLine();
    } while (repeatEntry != "y" && repeatEntry != "n");

    repeat = repeatEntry == "y" ? true : false;
}

void CheckChar()
{
    string inputString = "";

    do
    {
        Console.WriteLine("");
        Console.Write("ENTER A VALID CHARACTER FOR VERIFICATION: ");
        inputString = Console.ReadLine();
    } while (inputString.Length != 1);

    char InputChar = inputString[0];

    if (char.IsDigit(InputChar))
    {
        Console.WriteLine("The entered character is a number.");
    }

    else if (char.IsLetter(InputChar))
    {
        if (char.IsUpper(InputChar))
        {
            Console.WriteLine("The entered character is an uppercase letter.");
        } 
        else
        {
            Console.WriteLine("The entered character is a lowercase letter.");
        }
    } 

    else
    {
        Console.WriteLine("The entered character is a special character.");
    }

    Console.WriteLine("");
}
