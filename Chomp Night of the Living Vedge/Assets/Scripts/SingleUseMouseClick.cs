using UnityEngine;
using UnityEngine.Events;

public class SingleUseMouseClick : MonoBehaviour
{
  private bool usedBool;
  public UnityEvent UseEvent;

  private void Start()
  {
    Debug.Log("It's starting at least");
    usedBool = false;
  }

  private void OnMouseDown()
  {
    Debug.Log("Registering Mouse");
    if (usedBool == false)
    {
      Debug.Log("registering that it isn't used");
      UseEvent.Invoke();
      usedBool = true;
    }
  }
}