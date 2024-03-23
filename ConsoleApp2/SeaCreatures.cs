/// <summary>
/// Бывший класс Fish после обновы теперь это отдельный класс 
/// </summary>
public abstract class SeaСreatures
{
    public int Age { get; private set; }
    public int MaxAge { get; }
    public bool IsAlive { get; private set; }

    public SeaСreatures()
    {
        Random random = new();
        Age = random.Next(1, 4);
        MaxAge = random.Next(15, 20);
        IsAlive = true;
    }

    public void IncreaseAge()
    {
        if (Age >= MaxAge)
            IsAlive = false;
        else
            Age++;
    }

    public void PrintInfoAboutIsAlive()
    {
        string isAlive = IsAlive ? "жива" : "мертва";
        Console.WriteLine($": Возраст - {Age}, Статус - {isAlive}");
    }
}

/// <summary>
/// Короче раньше Fish имел все поля и методы SeaCreatures но пришла обнова и добавились крабики теперь Fish это наследник SeaCreatures
/// </summary>
public class Fish : SeaСreatures
{
    public override string ToString()
    {
        return "Рыбка";
    }
}
/// <summary>
/// Короче раньше Fish имел все поля и методы SeaCreatures но пришла обнова и добавились крабики теперь Crab это наследник SeaCreatures
/// </summary>
public class Crab : SeaСreatures
{
    public bool Agree;
    public override string ToString()
    {
        return "Крабик";
    }
}


