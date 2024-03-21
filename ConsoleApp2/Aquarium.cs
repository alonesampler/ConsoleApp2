public class Aquarium
{
    public List<Fish> fish = new List<Fish>();
    public int capacity = 20;

    public void AddFish()
    {
        fish.Add(new Fish());
    }

    public void RemoveFish(int index)
    {
        if (index >= 0 && index < fish.Count)
        {
            fish.RemoveAt(index);
        }
    }
}
