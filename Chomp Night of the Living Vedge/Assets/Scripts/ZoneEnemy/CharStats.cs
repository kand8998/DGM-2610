using UnityEngine;
using UnityEngine.Events;

public class CharStats : MonoBehaviour
{
    public int maxHealth = 1;
    public int currentHealth { get; set; }
    
    public Stats damage;
    public UnityEvent damageEvent, dieEvent;
    
    public SliderController healthBar;
    
    private void Start()
    {
        if (healthBar != null) healthBar.SetMaxHealth(maxHealth);
    }
    
    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth += damage;
        damageEvent.Invoke();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        dieEvent.Invoke();
    }
}
