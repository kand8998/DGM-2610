using UnityEngine;
using UnityEngine.Events;

public class CollisionEvents : MonoBehaviour
{
    public UnityEvent collisionEvent, boolTrueEvent;
    public BoolData switchData;
    private void OnCollisionEnter(Collision other)
    {
        if (switchData.Switch == true)
        {
            boolTrueEvent.Invoke();
        }
        collisionEvent.Invoke();
    }
}
