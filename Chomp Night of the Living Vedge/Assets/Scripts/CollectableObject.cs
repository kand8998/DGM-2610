using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class CollectableObject : ScriptableObject
{
    public UnityAction<int> coinAction;
    public int value = 10;

    public void Spend()
    {
        coinAction?.Invoke(value);
    }
}
