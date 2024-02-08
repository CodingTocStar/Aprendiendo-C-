Random random = new Random();
int heroLife = 10;
int monsterLife = 10;

do
{
    Console.WriteLine("Hero has attacked!");
    int dice = random.Next(1, 11);
    Console.WriteLine($"Hero has hit by {dice}");

    monsterLife -= dice;
    Console.WriteLine($"Monster's life remaining is {monsterLife}");

    if (monsterLife <= 0)
    {
        Console.WriteLine("Hero win, the world has been save... for now");
        break;
    }

    Console.WriteLine("It's monster time!");
    dice = random.Next(1, 11);

    Console.WriteLine($"Monster has hit by {dice}");

    heroLife -= dice;
    Console.WriteLine($"Hero's life remaining is {heroLife}");

    if (heroLife <= 0)
    {
        Console.WriteLine("Monster win, caos is inminent");
        break;
    }

} while (heroLife > 0 || monsterLife > 0);