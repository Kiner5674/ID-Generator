string digit = "";
string repeat = "";
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
    if (digit != null)
    {
        break;
    }
}
string letter = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"; //62 letter
Random random = new Random();
string ID = "";
for (int rep = 0; rep < 10; rep++)
{
    for (int i = 0; i < int.Parse(digit); i++)
    {
        ID += letter[random.Next(1, 62)];
    }
    Console.WriteLine(ID + "\n");
    ID = "";
}
Console.WriteLine("\nPress any key........");
Console.ReadKey();
