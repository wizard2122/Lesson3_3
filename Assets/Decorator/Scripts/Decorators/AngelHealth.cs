using System.Collections;
using UnityEngine;

public class AngelHealth : IHealthStat
{
    private const int TicksCount = 4;

    private IHealthStat _healthStat;
    private float _healDuration;
    private int _additinalHeal;

    private MonoBehaviour _context;
    private Coroutine _heal;

    public AngelHealth(IHealthStat healthStat, float healDuration, int additinalHeal, MonoBehaviour context)
    {
        _healthStat = healthStat;
        _healDuration = healDuration;
        _additinalHeal = additinalHeal;

        _context = context;
    }

    public int MaxHealth => _healthStat.MaxHealth;

    public int Value => _healthStat.Value;

    public void Add(int value)
    {
        _healthStat.Add(value);

        if(_heal != null)
            _context.StopCoroutine(_heal);

        _heal = _context.StartCoroutine(Heal());
    }

    public void Reduce(int value) => _healthStat.Reduce(value);

    private IEnumerator Heal()
    {
        float tickDuration = _healDuration / TicksCount;
        int healthPerTick = _additinalHeal / TicksCount;

        for (int i = 0; i < TicksCount; i++)
        {
            _healthStat.Add(healthPerTick);

            yield return new WaitForSeconds(tickDuration);
        }
    }
}
