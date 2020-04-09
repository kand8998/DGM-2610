using UnityEngine;
using UnityEngine.Events;

public class CollisionEvents : MonoBehaviour
{
    public UnityEvent collisionEvent, boolTrueEvent;
    
    private void OnCollisionEnter(Collision other)
    {
        collisionEvent.Invoke();
       
    }
}
