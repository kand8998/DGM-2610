using UnityEngine;
using UnityEngine.Events;

public class RightMouseButtonEvents : MonoBehaviour
{
    public UnityEvent rightButtonDownEvent, rightButtonUpEvent, checkEvent;
    public BoolData canSprint;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            checkEvent.Invoke();
            if (!canSprint.Switch) return;
            RightMouseDown();
        }
        
        if (Input.GetMouseButtonUp(1))
        {
            if (!canSprint.Switch) return;
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
