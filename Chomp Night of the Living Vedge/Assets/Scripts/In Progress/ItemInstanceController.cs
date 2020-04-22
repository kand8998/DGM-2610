using UnityEngine;

public class ItemInstanceController : Item
{
    private Transform location;
    
    public GameObject instanceObject;
    public override void Use()
    {
        location = PlayerManager.instance.player.transform;
        base.Use();
        InstanceAtLocation();
    }
    
    private void InstanceAtLocation()
    {
        Instantiate(instanceObject, location.position, location.rotation);
    }
}