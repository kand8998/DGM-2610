using UnityEngine;

public class Restart : MonoBehaviour

{
    public Vector3Data location;

    public void ReturnToSpawn()
    {
        transform.position = location.value;
    }

    public void UpdateCheckPoint(Vector3Data checkPoint)
    {
        checkPoint.value = location.value;
    }

}