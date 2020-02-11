using UnityEngine;
using UnityEngine.Events;

public class MouseButtonEvents : MonoBehaviour
{
    public UnityEvent mouseButtonDownEvent, mouseButtonUpEvent;

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
    }
}