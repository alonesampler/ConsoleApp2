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
            Console.WriteLine("1. Убрать рыбку");
            Console.WriteLine("2. Добавить рыбку");
            Console.WriteLine("3. Новый день");
            Console.WriteLine("4. Выйти");

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
                    _day++;
                    break;
                case '4':
                    Console.WriteLine("До свидания!");
                    return;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }

            if (choice == '3')
            {
                foreach (Fish fish in aquarium.fish)
                {
                    fish.IncreaseAge();
                }
            }
        }
    }

    private static void DisplayFishInfo(Aquarium aquarium)
    {
        if (aquarium.fish.Count > 0)
        {
            for (int i = 0; i < aquarium.fish.Count; i++)
            {
                string isAlive = aquarium.fish[i]._isAlive ? "жива" : "мертва";
                Console.WriteLine($"Рыбка {i + 1}: Возраст - {aquarium.fish[i]._age}, Статус - {isAlive}");
            }
        }
        else
        {
            Console.WriteLine("В аквариуме нет рыбок.");
        }
    }

    private static void ExecuteFirstHandler(Aquarium aquarium)
    {
        Console.Clear();
        DisplayFishInfo(aquarium);

        if (aquarium.fish.Count > 0)
        {
            Console.Write("Введите номер рыбки для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 1 && index <= aquarium.fish.Count)
                {
                    aquarium.RemoveFish(index - 1);
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

    private static void ExecuteSecondHandler(Aquarium aquarium)
    {
        if (aquarium.fish.Count < aquarium.capacity)
        {
            aquarium.AddFish();
            Console.WriteLine("Рыбка добавлена в аквариум.");
        }
        else
        {
            Console.WriteLine("Аквариум переполнен, нельзя добавить больше рыбок.");
        }
    }
}