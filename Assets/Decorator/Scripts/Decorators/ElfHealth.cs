public class ElfHealth : IHealthStat
{
    private IHealthStat _healthStat;
    private int _healMultiplier;

    public ElfHealth(IHealthStat healthStat, int healMultiplier)
    {
        _healthStat = healthStat;
        _healMultiplier = healMultiplier;
    }

    public int MaxHealth => _healthStat.MaxHealth;

    public int Value => _healthStat.Value;

    public void Add(int value)
    {
        value *= _healMultiplier;

        _healthStat.Add(value);
    }

    public void Reduce(int value) => _healthStat.Reduce(value);
}
