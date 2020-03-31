using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    private static bool gameIsPaused = false;
    public UnityEvent resumeEvent, pauseEvent;

    private void ResumeGame()
    {
        resumeEvent.Invoke();
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    private void PauseGame()
    {
        pauseEvent.Invoke();
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
