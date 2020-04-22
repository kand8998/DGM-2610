using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    public bool isDeletable = true;
    public UnityEvent useEvent;

    public virtual void Use()
    {
        useEvent.Invoke();
        Debug.Log("Using..." + name);
    }
}