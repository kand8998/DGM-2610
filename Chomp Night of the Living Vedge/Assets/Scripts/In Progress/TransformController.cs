using UnityEngine;

public class TransformController : MonoBehaviour
{
    private Vector3Data playerData;

    private void Start()
    {
        playerData.value = playerData.value;
    }

    public void SetTransform(Transform destination)
    {
        transform.position = destination.position;
    }

    public void SetTransform(Vector3Data destination)
    {
        transform.position = destination.value;
    }

    public void SetTransform(Vector3ListData listObj)
    {
        playerData.UpdateTransform(transform);
        playerData = listObj.ReturnCurrentLine();
    }
}
