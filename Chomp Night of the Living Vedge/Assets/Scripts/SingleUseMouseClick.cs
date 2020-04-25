using UnityEngine;
using UnityEngine.Events;

public class SingleUseMouseClick : MonoBehaviour
{
  private bool usedBool;
  public UnityEvent UseEvent;

  private void Start()
  {
    usedBool = false;
  }

  private void OnMouseDown()
  {
    if (usedBool == false)
    {
      UseEvent.Invoke();
      usedBool = true;
    }
  }
}
