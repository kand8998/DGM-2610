using UnityEngine;
using UnityEngine.Events;

public class DoWork : MonoBehaviour
{
    public NameID nameIdObj;
    public UnityEvent workEvent;

    public void Work()
    {
        workEvent.Invoke();
    }
}
