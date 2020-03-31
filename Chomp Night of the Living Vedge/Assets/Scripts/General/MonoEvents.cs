using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent;
    
    private void Start()
    {
        startEvent.Invoke();
    }

    private void Awake()
    {
        awakeEvent.Invoke();
    }
}
