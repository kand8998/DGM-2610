using UnityEngine;
using UnityEngine.Events;

public class SimpleMatchID : IDBehaviour
{
    protected NameID OtherIDObj;
    public UnityEvent matchEvent, noMatchEvent;
    
    public void OnTriggerEnter(Collider other)
    {
        OtherIDObj = other.GetComponent<IDBehaviour>().nameIDObj;
       Debug.Log("The ID is triggering");

        if (nameIDObj == OtherIDObj)
        {
            matchEvent.Invoke();
            Debug.Log("It's matching");
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
 
}
