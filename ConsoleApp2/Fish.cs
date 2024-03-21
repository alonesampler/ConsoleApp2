public class Fish
{
    public int _age { get; set; }
    public int _maxAge { get; set; }
    public bool _isAlive { get; set; }

    public Fish()
    {
        Random random = new Random();
        _age = random.Next(1, 4);
        _maxAge = random.Next(15, 20);
        _isAlive = true;
    }

    public void IncreaseAge()
    {
        if (_age >= _maxAge)
            _isAlive = false;
        else
            _age++;
    }
}
