using System.Collections;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/InstanceItem")]
public class ItemInstanceController : Item
{
    public GameObject location;
    public GameObject instanceObject;
    
    
    public override void Use()
    {
        base.Use();
        InstanceAtLocation();
    }
    
    private void InstanceAtLocation()
    {
        Instantiate(instanceObject, location.transform.position, location.transform.rotation);
    }
}