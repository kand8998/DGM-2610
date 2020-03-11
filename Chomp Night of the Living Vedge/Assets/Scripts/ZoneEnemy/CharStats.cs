using UnityEngine;
using UnityEngine.Events;

public class CharStats : MonoBehaviour
{
    public int maxHealth = 1;
    public int currentHealth { get; set; }
    
    public Stats damage;

    public UnityEvent damageEvent;
    //public SliderController healthBar;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Start()
    {
        //if (healthBar != null) healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
        damageEvent.Invoke();
        
        Debug.Log(transform.name + "takes" + damage + "damage.");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log(transform.name + "died");
    }
}
