using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent, boolTrueEvent;
    public BoolData switchData;
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        
        if (!switchData.Switch)
        {
            boolTrueEvent.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}
