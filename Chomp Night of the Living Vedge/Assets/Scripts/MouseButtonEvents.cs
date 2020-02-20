using UnityEngine;
using UnityEngine.Events;

public class MouseButtonEvents : MonoBehaviour
{
    public UnityEvent mouseButtonDownEvent, mouseButtonUpEvent, rightButtonDownEvent, rightButtonUpEvent;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LeftMouseDown();
        }

        if (Input.GetMouseButtonUp(0))
        {
            LeftMouseUp();
        }

        if (Input.GetMouseButtonDown(1))
        {
            RightMouseDown();
        }

        if (Input.GetMouseButtonUp(1))
        {
            RightMouseUp();
        }
    }

    private void LeftMouseDown()
    {
        mouseButtonDownEvent.Invoke();
    }
  
    private void LeftMouseUp()
    {
        mouseButtonUpEvent.Invoke();
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