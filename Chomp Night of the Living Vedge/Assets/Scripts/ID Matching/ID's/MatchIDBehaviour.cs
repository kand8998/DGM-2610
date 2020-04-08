using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchIDBehaviour : IDBehaviour
{
    [Serializable]
    public struct possibleWork
    {
        public NameID nameIdObj;
        public UnityEvent workEvent;
    }

    private IDBehaviour otherBehaviourObj;
    private NameID otherIdObj;
    public List<possibleWork> workIdList;

    private void OnTriggerEnter(Collider other)
    {
        otherBehaviourObj = other.GetComponent<IDBehaviour>();
        if (otherBehaviourObj == null) return;
        otherIdObj = otherBehaviourObj.nameIdObj;
        CheckId();
    }

    private void OnTriggerExit(Collider other)
    {
        otherBehaviourObj = other.GetComponent<IDBehaviour>();
        if (otherBehaviourObj == null) return;
        otherIdObj = otherBehaviourObj.nameIdObj;
        CheckId();
    }

    private void CheckId()
    {
        foreach (var obj in workIdList)
        {
            if (otherIdObj == obj.nameIdObj)
            {
                {
                    obj.workEvent.Invoke();
                }
            }
        }
    }
}
