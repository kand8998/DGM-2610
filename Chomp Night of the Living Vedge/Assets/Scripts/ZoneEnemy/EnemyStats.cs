using UnityEngine.Events;

public class EnemyStats : CharStats
{
    public UnityEvent deathEvent;

    protected override void Die()
    {
        base.Die();
        deathEvent.Invoke();
    }

}
