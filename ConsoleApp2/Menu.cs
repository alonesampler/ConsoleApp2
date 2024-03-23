public class Menu
{
    private int _day = 1;

    public void PrintMenu(Aquarium aquarium)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"\nДень {_day}");
            Console.WriteLine("\nИнформация о рыбах:");
            DisplayFishInfo(aquarium);

            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Убрать живность");
            Console.WriteLine("2. Добавить рыбку");
            Console.WriteLine("3. Добавить крабика");
            Console.WriteLine("4. Новый день");
            Console.WriteLine("5. Выйти");

            char choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    ExecuteFirstHandler(aquarium);
                    break;
                case '2':
                    ExecuteSecondHandler(aquarium);
                    break;
                case '3':
                    ExecuteThirdHandler(aquarium);
                    break;
                case '4':
                    ExecuteFifthHandler(aquarium);
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("До свидания!");
                    return;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }

    public static void DisplayFishInfo(Aquarium aquarium)
    {
        if (aquarium.SeaCreatures.Count > 0)
        {
            for (int i = 0; i < aquarium.SeaCreatures.Count; i++)
            {
                string isAlive = aquarium.SeaCreatures[i].IsAlive ? "жива" : "мертва";
                Console.WriteLine($"{aquarium.SeaCreatures[i].ToString()} {i + 1}: Возраст - {aquarium.SeaCreatures[i].Age}, Статус - {isAlive}");
            }
        }
        else
        {
            Console.WriteLine("В аквариуме нет морских животных.");
        }
    }

    private static void ExecuteFirstHandler(Aquarium aquarium)
    {
        Console.Clear();
        DisplayFishInfo(aquarium);
        aquarium.RemoveSeaCreatures();
    }

    private static void ExecuteSecondHandler(Aquarium aquarium)
    {
        aquarium.AddFish();
    }

    private void ExecuteThirdHandler(Aquarium aquarium)
    {
        aquarium.AddCrab();
    }
    private void ExecuteFifthHandler(Aquarium aquarium)
    {
        _day++;
        aquarium.AddEnlargeAgeLiveness();
    }
}