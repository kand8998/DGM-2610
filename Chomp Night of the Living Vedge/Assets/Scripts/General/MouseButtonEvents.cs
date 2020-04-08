using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MouseButtonEvents : MonoBehaviour
{
    public float waitTime = 0.5f;
    
    public UnityEvent mouseButtonDownEvent, mouseButtonUpEvent, 
        rightButtonDownEvent, rightButtonUpEvent;
    
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
        canUseMouse = false;
        StartTimer();
    }
  
    private void RightMouseDown()
    {
        rightButtonDownEvent.Invoke();
    }
    private void RightMouseUp()
    {
        rightButtonUpEvent.Invoke();
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