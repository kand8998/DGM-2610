using UnityEngine;

public class ItemHolder : MonoBehaviour
{
    public Item itemObj;
    
    public void PickUp()
    {
        bool wasPickedup = InventoryBehaviour.instance.Add(itemObj);
        if (wasPickedup)
            Destroy(gameObject);
    }
}
