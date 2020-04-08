using UnityEngine;

public class TriggerMatchID : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggering Into..." + other.name);
    }
}
