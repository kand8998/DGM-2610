using UnityEngine;
using UnityEngine.Events;

public class RightMouseButtonEvents : MonoBehaviour
{
    public UnityEvent rightButtonDownEvent, rightButtonUpEvent;

    private void Update()
    {
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
