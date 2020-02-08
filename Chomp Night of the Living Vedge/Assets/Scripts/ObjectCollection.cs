using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ObjectCollection : ScriptableObject
{
    public List<CollectableObject> collectList;
    
    public void AddCoin(CollectableObject collectObj)
    {
        if (!collectList.Contains(collectObj))
        {
            collectList.Add(collectObj);
        }
    }

    public void UseCoin()
    {
        collectList[0].Spend();
        collectList.RemoveAt(0);
    }

    public void UseCoinWithValue(int value)
    {
        var number = 5;
        for (var i = 0; i < collectList.Count; i++)
        {
            var tool = collectList[i];
            if (tool.value > number)
            {
                tool.Spend();
                collectList.Remove(tool);
            }
        }
    }
}
