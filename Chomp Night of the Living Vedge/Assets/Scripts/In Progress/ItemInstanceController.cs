using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/InstanceItem")]
public class ItemInstanceController : Item
{
    public TransformData location;
    public GameObject instanceObject;
    
    public override void Use()
    {
        base.Use();
    }
    
    private void InstanceAtLocation()
    {
        Instantiate(instanceObject, location.value.transform.position, location.value.transform.rotation);
    }
}