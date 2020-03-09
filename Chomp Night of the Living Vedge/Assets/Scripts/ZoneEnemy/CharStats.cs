using UnityEngine;

public class CharStats : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth { get; set; }
    
    public Stats damage;
    public HealthBar healthBar;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Start()
    {
        if (healthBar != null) healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
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
