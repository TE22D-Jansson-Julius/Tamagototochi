Tomomomomomogatchi tomomomomomogatchi = new();
Console.WriteLine("Write a name for your tomagatchi");
tomomomomomogatchi.name = Console.ReadLine();

while (tomomomomomogatchi.GetAlive())
{
    tomomomomomogatchi.PrintStats();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("1.Feed 2.Hi 3.Teach");


    string choise = Console.ReadLine();

    if (choise == "1") tomomomomomogatchi.Feed();

    else if (choise == "2") tomomomomomogatchi.Hi();

    else if (choise == "3") tomomomomomogatchi.Teach();

    tomomomomomogatchi.Tick();
}

Console.WriteLine($"Du är så bajs att {tomomomomomogatchi.name} dog");
Console.ReadLine();

