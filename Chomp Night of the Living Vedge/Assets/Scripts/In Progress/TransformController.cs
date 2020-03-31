using UnityEngine;

public class TransformController : MonoBehaviour
{
    public void SetTransform(Transform destination)
    {
        this.transform.position = destination.position;
    }
}
