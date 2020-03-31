using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    private static bool gameIsPaused = false;
    public UnityEvent resumeEvent, pauseEvent;

    public void ResumeGame()
    {
        resumeEvent.Invoke();
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void PauseGame()
    {
        pauseEvent.Invoke();
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
