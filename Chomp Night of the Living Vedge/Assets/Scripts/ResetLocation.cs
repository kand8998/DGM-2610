using UnityEngine;

public class ResetLocation : MonoBehaviour
{
    public TransformData location;

    public void ReturnToSpawn()
    {
        GetComponent<CharacterController>().enabled = false;
        transform.position = location.value.position;
        GetComponent<CharacterController>().enabled = true;
    }

    public void UpdateCheckPoint(TransformData checkPoint)
    {
        checkPoint.value = location.value;
    }
}