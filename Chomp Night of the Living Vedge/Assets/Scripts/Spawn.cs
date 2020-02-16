using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;
    public GameAction droppedAction;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        droppedAction.action += SpawnDroppedItem;
    }

    public void SpawnDroppedItem()
    {
        var playerPos = new Vector3(player.position.x, player.position.y+3, 0);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}