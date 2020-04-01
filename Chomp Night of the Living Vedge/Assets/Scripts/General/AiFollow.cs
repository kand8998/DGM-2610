using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiFollow : MonoBehaviour
{
   // public GameAction destinationAction, playerAction;
    private NavMeshAgent agent;
    public Transform playerTransform, aiTransform;
    private Transform destination;
    private void Start()
    {
        destination = aiTransform;
        agent = GetComponent<NavMeshAgent>();
//        destinationAction.action += DestinationSelfSet;
//        playerAction.action += DestinationPlayerSet;
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