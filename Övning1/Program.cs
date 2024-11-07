using System.Runtime.ConstrainedExecution;

string User;
string Pass;
string WriteNum;
int Num = 0;
int UserNum;
bool Suceed;

if (6 >= 3)
{
    System.Console.WriteLine("Hello World!");
}
while(true)
{
    System.Console.Write("Username: ");
    User = Console.ReadLine();
    System.Console.Write("Password: ");
    Pass = Console.ReadLine();

    if (User == "noname" && Pass == "nopass")
    {
        System.Console.WriteLine($"Welcome {User}!");
        Console.ReadLine();
        break;
    }
    else
    {
        System.Console.WriteLine("Wrong username or password.");
        continue;
    }
}

// for (int i = 0; i < 32; i++)
// {
//     System.Console.WriteLine("Hello, World");
// }
// Console.ReadLine();

while(Num < 5)
{
    System.Console.Write("Write a number: ");
    WriteNum = Console.ReadLine();
    Suceed = int.TryParse(WriteNum, out UserNum);

    if (!Suceed)
    {
        System.Console.WriteLine("That isn't number. Try again");
        continue;
    }
    Num++;
    if (UserNum > 5)
    {
        System.Console.WriteLine("Higher than 5!");
    }
    else
    {
        System.Console.WriteLine("Less than 5!");
    }

    System.Console.WriteLine(UserNum);
    
}

Console.ReadLine();
Console.Clear();

System.Console.WriteLine("You passed test.");
UserNum = 0;
int r = Random.Shared.Next(1, 10);
while(true)
{
    System.Console.WriteLine("\nGuess a number between 1 and 10.");

    WriteNum = Console.ReadLine();
    Suceed = int.TryParse(WriteNum, out UserNum);

    if(!Suceed)
    {
        System.Console.WriteLine("Please enter a number.");
    }

    if(UserNum == r)
    {
        System.Console.WriteLine("You guessed right!");
        break;
    }
    else if(UserNum > r)
    {
        System.Console.WriteLine("The number is lower. Try again.");
    }
    else if (UserNum < r)
    {
        System.Console.WriteLine("The number is higher. Try agian");
    }
    else if (UserNum > 10)
    {
        System.Console.WriteLine("Please input number between 1 and 10");
    }


}
Console.ReadLine();