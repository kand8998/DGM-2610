using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchIDBehaviour : IDBehaviour
{
    [Serializable]
    public struct possibleMatch
    {
        public NameID nameIDObj;
        public UnityEvent workEvent, delayedEvent;
    }

    public float holdTime = 0.1f;
    public WaitForSeconds waitObj;
    public List<possibleMatch> triggerEnterMatches, triggerExitMatches;
    private NameID otherIDObj;

    private void Awake()
    {
        waitObj = new WaitForSeconds(holdTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        otherIDObj = other.GetComponent<IDBehaviour>().nameIDObj;
        StartCoroutine(CheckId(otherIDObj, triggerEnterMatches));
    }
   
    private void OnTriggerExit(Collider other)
    {
        otherIDObj = other.GetComponent<IDBehaviour>().nameIDObj;
        StartCoroutine(CheckId(otherIDObj, triggerExitMatches));
    }

    private IEnumerator CheckId(NameID nameID, List<possibleMatch> possibleMatches)
    {
      
        if (nameID == null) yield break;
      
        otherIDObj = nameID;
        foreach (var obj in possibleMatches)
        {
            if (otherIDObj == obj.nameIDObj)
            {
                obj.workEvent.Invoke();
                yield return waitObj;
                obj.delayedEvent.Invoke();
            }
        }
    }
}
