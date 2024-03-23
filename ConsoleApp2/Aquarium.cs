public class Aquarium
{
    public List<SeaСreatures> SeaCreatures = [];
    public const int Capacity = 20;

    public void AddFish()
    {
        if (CheckCapacity())
            SeaCreatures.Add(new Fish());
    }

    public void AddCrab()
    {
        if (CheckCapacity())
            SeaCreatures.Add(new Crab());
    }

    public bool CheckCapacity()
    {
        if (SeaCreatures.Count < Capacity)
        {
            Console.WriteLine("Рыбка добавлена в аквариум.");
            return true;
        }
        else
        {
            Console.WriteLine("Аквариум переполнен, нельзя добавить больше рыбок.");
            return false;
        }
    }

    public void RemoveSeaCreatures()
    {
        if (SeaCreatures.Count <= 0)
        {
            Console.WriteLine("В аквариуме нет рыбок.");
            return;
        }

        Console.Write("Введите номер рыбки для удаления: ");

        bool validInput = int.TryParse(Console.ReadLine(), out int index);

        if (!validInput)
        {
            Console.WriteLine("Неверный ввод.");
            Console.ReadKey();
            return;
        }

        bool validIndex = index >= 0 && index <= SeaCreatures.Count;

        if (!validIndex)
        {
            Console.WriteLine("Неверный номер рыбки.");
            Console.ReadKey();
            return;
        }

        SeaCreatures.RemoveAt(index - 1);

    }

    public void AddEnlargeAgeLiveness()
    {
        foreach (SeaСreatures seaСreatures in SeaCreatures)
        {
            seaСreatures.IncreaseAge();
        }
    }

    public void PrintSeaCreaturesInfo()
    {
        if (SeaCreatures.Count <= 0)
        {
            Console.WriteLine("В аквариуме нет морских животных.");
            return;
        }

        for (int i = 0; i < SeaCreatures.Count; i++)
        {
            Console.Write($"{SeaCreatures[i].ToString()} {i + 1}");
            SeaCreatures[i].PrintInfoAboutIsAlive();
        }
    }
}

