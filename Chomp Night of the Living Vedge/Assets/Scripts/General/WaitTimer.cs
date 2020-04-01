using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class WaitTimer : MonoBehaviour
{
    public float waitTime;
    public UnityEvent timerEvent;

    public void StartTimer()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        timerEvent.Invoke();
    }
}