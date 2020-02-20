using UnityEngine;
using UnityEngine.Events;

public class MouseButtonEvents : MonoBehaviour
{
    public UnityEvent mouseButtonDownEvent, mouseButtonUpEvent, rightButtonDownEvent, rightButtonUpEvent;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseButtonDownEvent.Invoke();
        }

        if (Input.GetMouseButtonUp(0))
        {
            mouseButtonUpEvent.Invoke();
        }
        if (Input.GetMouseButtonDown(1))
        {
            rightButtonDownEvent.Invoke();
        }

        if (Input.GetMouseButtonUp(1))
        {
            rightButtonUpEvent.Invoke();
        }
    }
}