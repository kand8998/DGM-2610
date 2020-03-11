using UnityEngine;

[RequireComponent(typeof(EnemyController))]
[RequireComponent(typeof(CharCombat))]
public class Enemy : Interactable
{
    private PlayerManager playerManager;
    private CharStats enemyStats;

    private void Start()
    {
        playerManager = PlayerManager.instance;
        enemyStats = GetComponent<CharStats>();
    }

    public override void Interact()
    {
        base.Interact();
        CharCombat playerCombat = playerManager.player.GetComponent<CharCombat>();

        if (playerCombat != null)
        {
            playerCombat.Attack(enemyStats);
            Debug.Log("Enemy is being attacked!");
        }
    }
}
