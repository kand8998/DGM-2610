using UnityEngine;
using UnityEngine.Events;

public class RangeController : MonoBehaviour
{
  public UnityEvent rangeEvent;
  
  public float radius = 10.0f;
  private Transform target;

  private void Start()
  {
    target = PlayerManager.instance.player.transform;
  }

  private void Update()
  {
    float distance = Vector3.Distance(target.position, transform.position);
    
    if (distance < radius)
    {
      rangeEvent.Invoke();
    }
  }
  
  private void OnDrawGizmosSelected()
  {
    Gizmos.color = Color.magenta;
    Gizmos.DrawWireSphere(transform.position, radius);
  }
}
