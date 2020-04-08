using System.Collections.Generic;
using UnityEngine;

public class MatchID : MonoBehaviour
{
    public List<NameID> nameIDList;
    
    private void OnTriggerEnter(Collider other)
    {
        var doWorkObj = other.GetComponent<DoWork>();
        var otherNameId = doWorkObj.nameIdObj;
        
        foreach (var nameId in nameIDList)
        {
            if (nameId == otherNameId)
            {
                doWorkObj.Work();
            }
        }
    }
}