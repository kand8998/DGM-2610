using UnityEngine;

public class TransformController : MonoBehaviour
{
    public void SetTransform(Transform destination)
    {
        transform.position = destination.position;
    }

    public void SetTransform(Vector3Data destination)
    {
        transform.position = destination.value;
    }
}