public class Menu
{
    private int _day = 1;
    private Aquarium _aquarium;
    private string[] _point = { "Убрать живность", "Добавить рыбку", "Добавить крабика", "Новый день", "Выйти" };
    public Menu(Aquarium aquarium)
    {
        _aquarium = aquarium;
    }

    public void PrintMenu(Aquarium aquarium)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"\nДень {_day}");
            Console.WriteLine("\nИнформация о рыбах:");
            aquarium.PrintSeaCreaturesInfo();

            Console.WriteLine("\nВыберите действие:");
            for(int i = 0; i < _point.Length; i++)
                Console.WriteLine($"{i+1}. {_point[i]}");

            char choice = Console.ReadKey().KeyChar;

            switch (choice)
            {
                case '1':
                    ExecuteFirstHandler();
                    break;
                case '2':
                    ExecuteSecondHandler();
                    break;
                case '3':
                    ExecuteThirdHandler();
                    break;
                case '4':
                    ExecuteFifthHandler();
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

    private void ExecuteFirstHandler()
    {
        Console.Clear();
        _aquarium.PrintSeaCreaturesInfo();
        _aquarium.RemoveSeaCreatures();
    }

    private void ExecuteSecondHandler()
    {
        _aquarium.AddFish();
    }

    private void ExecuteThirdHandler()
    {
        _aquarium.AddCrab();
    }
    private void ExecuteFifthHandler()
    {
        _day++;
        _aquarium.AddEnlargeAgeLiveness();
    }
}