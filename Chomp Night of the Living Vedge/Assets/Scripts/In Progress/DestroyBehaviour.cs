using UnityEngine;
using UnityEngine.Events;

public class DestroyBehaviour : MonoBehaviour
{
    public UnityEvent beforeDestroyEvent, afterDestroyEvent;

    public void DestroyThis ()
    {
        beforeDestroyEvent.Invoke();
        Destroy(gameObject);

        afterDestroyEvent.Invoke();
        gameObject.SetActive(true);
    }
}
