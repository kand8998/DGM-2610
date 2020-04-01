using UnityEngine;

public class BillboardController : MonoBehaviour
{
    private Transform cam;

    private void Awake()
    {
       cam = Camera.main.transform;
    }

    private void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
    }
}
