using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject item;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void SpawnDroppedItem()
    {
        var playerPos = new Vector3(player.position.x, player.position.y+3, 0);
        Instantiate(item, playerPos, Quaternion.identity);
    }
}