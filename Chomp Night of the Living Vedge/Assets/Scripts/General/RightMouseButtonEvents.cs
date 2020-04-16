using UnityEngine;
using UnityEngine.Events;

public class RightMouseButtonEvents : MonoBehaviour
{
    public UnityEvent rightButtonDownEvent, rightButtonUpEvent;
    public BoolData canSprint;
    
    private void Update()
    {
        if (!canSprint.Switch) return;
        if (Input.GetMouseButtonDown(1))
        {
            RightMouseDown();
        }

        if (Input.GetMouseButtonUp(1))
        {
            RightMouseUp();
        }
    }
    
    private void RightMouseDown()
    {
        rightButtonDownEvent.Invoke();
    }
    private void RightMouseUp()
    {
        rightButtonUpEvent.Invoke();
    }
}
