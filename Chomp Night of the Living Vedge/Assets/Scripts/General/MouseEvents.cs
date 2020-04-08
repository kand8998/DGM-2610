using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public float waitTime = 0.5f;
    public UnityEvent mousedownEvent, mouseUpEvent;
    
    private bool canUseMouse = true;
    
    private void OnMouseDown()
    {
        if (canUseMouse)
        {
            mousedownEvent.Invoke();
        }
    }

    private void OnMouseUp()
    {
        mouseUpEvent.Invoke();
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