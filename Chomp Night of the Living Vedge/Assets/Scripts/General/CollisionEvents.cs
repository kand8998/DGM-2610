using UnityEngine;
using UnityEngine.Events;

public class CollisionEvents : MonoBehaviour
{
    public UnityEvent collisionEvent;
    private void OnCollisionEnter(Collision other)
    {
        collisionEvent.Invoke();
    }
}
