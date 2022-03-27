// See https://aka.ms/new-console-template for more information
string digit = "";
Console.WriteLine("digit:");
while (true)
{
    try
    {
        digit = Console.ReadLine();
    }
    catch (Exception ex)
    {
        continue;
    }
    if (digit != null)
    {
        break;
    }
}
string letter = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"; //62
Random random = new Random();
string ID = "";
for (int i = 0; i < int.Parse(digit); i++)
{
    ID += letter[random.Next(1, 63)];
}
Console.WriteLine(ID);