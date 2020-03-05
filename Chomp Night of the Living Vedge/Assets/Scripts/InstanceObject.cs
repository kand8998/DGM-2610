using UnityEngine;

[CreateAssetMenu]
public class InstanceObject : ScriptableObject
{
    public Transform location;
    public GameObject instanceObj;
    
    public void Instance()
    {
        Instantiate(instanceObj);
    }
    public void InstanceAtLocation()
    {
        Instantiate(instanceObj, location.position, location.rotation);
    }
}