using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiFollow : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform playerTransform, aiTransform;
    private Transform destination;
    private void Start()
    {
        destination = aiTransform;
        agent = GetComponent<NavMeshAgent>();
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