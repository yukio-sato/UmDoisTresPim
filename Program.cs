    Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Jogo do 1 2 3 PIM.");
int i = 0;

while (i < 40)
{
    i++;
if (i%4 != 0)
{
        Console.ForegroundColor = ConsoleColor.White;
Console.Write($"{i}, ");
}
else if (i < 40)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write($"PIM,\n");
}
else if (i == 40)
{
        Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"PIM.\n");
}
}
Console.ResetColor();