using UnityEngine;

public class ItemPickup : Interactable
{
    public Item item;
    public override void Interact()
    {
        base.Interact();
        PickUp();
    }

    private void PickUp()
    {
        bool wasPickedup = InventoryBehaviour.instance.Add(item);
        if (wasPickedup)
            Destroy(gameObject);
    }
}