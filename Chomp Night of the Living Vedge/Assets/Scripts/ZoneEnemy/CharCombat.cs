using System.Collections;
using UnityEngine;


public class CharCombat : MonoBehaviour
{
    public float attackSpeed = 1f;
    private float attackCoolDown = 0f; 
    public float attackDelay = 0f;
    
    private CharStats myStats;
    

    public event System.Action OnAttack;
    
    private void Start()
    {
        myStats = GetComponent<CharStats>();
    }

    private void Update()
    {
        attackCoolDown -= Time.deltaTime;
    }

    public void Attack(CharStats targetStats)
    {
        if (attackCoolDown <= 0f)
        {
            StartCoroutine(DoDamage(targetStats, attackDelay ));
            if (OnAttack != null)
                OnAttack();
            
            attackCoolDown = 1f / attackSpeed;
        }
       
    }

    IEnumerator DoDamage(CharStats stats, float delay)
    {
        yield return new WaitForSeconds(delay);
        stats.TakeDamage(myStats.damage.GetValue());

    }
}