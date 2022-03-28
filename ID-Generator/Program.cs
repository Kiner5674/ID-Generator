// See https://aka.ms/new-console-template for more information
string digit = "";
string repeat = "";
string letter = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890-[]:;,./<>?_+*}`{=~|"; //82 letter
Random random = new Random();
string ID = "";

//Output system
Console.WriteLine("digit:");
while (true)
{
    try
    {
        digit = Console.ReadLine();
    }
    catch (Exception)
    {
        continue;
    }
    if (digit != null | digit.GetType() == typeof(int))
    {
        break;
    }
}

Console.WriteLine("repeat:");
while (true)
{
    try
    {
        repeat = Console.ReadLine();
    }
    catch (Exception)
    {
        continue;
    }
    if (repeat != null | repeat.GetType() == typeof(int))
    {

    }
}

//Generating system
for (int rep = 1; rep < int.Parse(repeat); rep++)
{
    for (int i = 0; i < int.Parse(digit); i++)
    {
        ID += letter[random.Next(1, 82)];
    }
    Console.WriteLine(ID + "\n");
    ID = "";
}

Console.WriteLine("\nPress any key........");
Console.ReadKey();
