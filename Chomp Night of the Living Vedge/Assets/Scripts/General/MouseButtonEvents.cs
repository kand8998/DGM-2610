using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MouseButtonEvents : MonoBehaviour
{
    public float waitTime = 0.5f;

    public UnityEvent mouseButtonDownEvent, mouseButtonUpEvent;

    private bool canUseMouse = true;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canUseMouse)
            {
                LeftMouseDown();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            LeftMouseUp();
        }
    }

    private void LeftMouseDown()
    {
        mouseButtonDownEvent.Invoke();
    }
  
    private void LeftMouseUp()
    {
        mouseButtonUpEvent.Invoke();
        canUseMouse = false;
        StartTimer();
    }

    private void StartTimer()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        canUseMouse = true;
    }
}