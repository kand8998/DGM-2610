using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform player, destination;
    private void Start()
    {
        destination = player;
        agent = GetComponent<NavMeshAgent>();
    }
    
    private void Update()
    {
        agent.destination = destination.position;
        destination = player;
    }
}
