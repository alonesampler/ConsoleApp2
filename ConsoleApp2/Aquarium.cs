public class Aquarium
{
    public List<SeaСreatures> SeaCreatures = new List<SeaСreatures>();
    public const int Capacity = 20;

    public void AddFish()
    {
        if (CheckCapacity() == true)
            SeaCreatures.Add(new Fish());
    }

    public void AddCrab()
    {
        if (CheckCapacity() == true)
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
        if (SeaCreatures.Count > 0)
        {
            Console.Write("Введите номер рыбки для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 0 && index <= SeaCreatures.Count)
                {
                    SeaCreatures.RemoveAt(index - 1);
                }
                else
                {
                    Console.WriteLine("Неверный номер рыбки.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод.");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("В аквариуме нет рыбок.");
        }
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
        if (SeaCreatures.Count > 0)
        {
            for (int i = 0; i < SeaCreatures.Count; i++)
            {
                Console.Write($"{SeaCreatures[i].ToString()} {i + 1}");
                SeaCreatures[i].PrintInfoAboutIsAlive();
            }
        }
        else
        {
            Console.WriteLine("В аквариуме нет морских животных.");
        }
    }
}

