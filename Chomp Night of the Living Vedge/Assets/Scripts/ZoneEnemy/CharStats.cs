using UnityEngine;
using UnityEngine.Events;

public class CharStats : MonoBehaviour
{
    public int maxHealth = 1;
    private int currentHealth { get; set; }
    public int damage;
    
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

    public void TakeDamage()
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

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
