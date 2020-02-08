using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class WaitTimer : MonoBehaviour
{
    public float waitTime = 3f;
    public GameAction waitAction;

    private void Start()
    {
        waitAction.action += StartTimer;
    }

    private void StartTimer()
    {
        StartCoroutine(WaiteCoroutine());
    }

    private IEnumerator WaiteCoroutine()
    {
        yield return new WaitForSecondsRealtime(waitTime);
    }
}
