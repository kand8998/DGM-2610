using UnityEngine;

public class FaceTargetBehaviour : MonoBehaviour
{
    private Transform target;

    private void Start()
    {
        target = PlayerManager.instance.player.transform;
    }

    private void Update()
    {
        FaceTarget();
    }

    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation =
            Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = lookRotation;
    }
}
