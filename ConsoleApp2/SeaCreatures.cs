/// <summary>
/// Бывший класс Fish после обновы теперь это отдельный класс 
/// </summary>
public class SeaСreatures
{
    public int Age;
    public int MaxAge;
    public bool IsAlive = true;

    public SeaСreatures()
    {
        Random random = new Random();
        Age = random.Next(1, 4);
        MaxAge = random.Next(15, 20);
    }

    public void IncreaseAge()
    {
        if (Age >= MaxAge)
            IsAlive = false;
        else
            Age++;
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


