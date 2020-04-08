using UnityEngine;
using UnityEngine.Events;

public class SimpleMatchID : IDBehaviour
{
    protected NameID OtherIDObj;
    public UnityEvent matchEvent, noMatchEvent;
    public virtual void OnTriggerEnter(Collider other)
    {
        OtherIDObj = other.GetComponent<IDBehaviour>().nameIDObj;

        if (nameIDObj == OtherIDObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}
