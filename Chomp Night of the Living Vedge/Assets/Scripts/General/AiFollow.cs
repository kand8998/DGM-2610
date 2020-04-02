using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform aiTransform;
    private Transform destination, playerTransform;
    private void Start()
    {
        destination = aiTransform;
        agent = GetComponent<NavMeshAgent>();
        playerTransform = PlayerManager.instance.player.transform;
    }
    
    private void Update()
    { 
        agent.destination = destination.position;
    }

    public void DestinationSelfSet()
    {
        agent.destination = destination.position;
        destination = aiTransform;
    }

    public void DestinationPlayerSet()
    {
        agent.destination = destination.position;
        destination = playerTransform;
    }
}