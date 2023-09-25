public interface IHealthStat
{
    int MaxHealth { get; }
    int Value { get; }
    void Reduce(int value);
    void Add(int value);
}
