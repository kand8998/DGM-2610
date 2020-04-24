using UnityEngine;

public class AddForceTrigger : MonoBehaviour
{
    private Transform transformObj;

    public float offsetFloat;

    private void Start()
    {
        transformObj = GetComponent<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.transform.CompareTag("Player")) return;
        var direction = (transformObj.position - other.transform.position).normalized;
        transformObj.position += direction * offsetFloat;
    }
}