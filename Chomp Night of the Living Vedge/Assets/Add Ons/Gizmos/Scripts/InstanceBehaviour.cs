using UnityEngine;

public class InstanceBehaviour : MonoBehaviour
{
    public Transform location;
    public GameObject instanceObj;

    private void Start()
    {
        InstanceAtLocation();
    }

    private void Instance()
    {
        Instantiate(instanceObj);
    }
    private void InstanceAtLocation()
    {
        Instantiate(instanceObj, location.position, location.rotation);
    }
}
