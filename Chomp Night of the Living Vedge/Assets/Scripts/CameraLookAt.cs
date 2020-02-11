using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    public Transform target;
    private void Update()
    {
        LookAt();
    }

    private void LookAt()
    {
        transform.LookAt(target);
    }
}
