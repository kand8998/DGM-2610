using UnityEngine;

public class TransformBehaviour : MonoBehaviour
{
    private Transform transformObj;

    public float offsetFloat;
    public GameAction offsetAction;

    private void Start()
    {
        transformObj = GetComponent<Transform>();
        offsetAction.action += OffsetTransform;
    }

    private void OffsetTransform()
    {
        transformObj.position += transformObj.TransformDirection(Vector3.back) * offsetFloat;
    }
}