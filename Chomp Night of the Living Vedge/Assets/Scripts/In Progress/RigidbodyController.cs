using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyController : MonoBehaviour
{
    public Rigidbody rigidBodyObj;

    public void AddForce()
    {
        rigidBodyObj.AddForce(0,0,100);
    }
}
