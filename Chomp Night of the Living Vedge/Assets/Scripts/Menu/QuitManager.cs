using UnityEngine;

[CreateAssetMenu]
public class QuitManager : ScriptableObject
{
    public void QuitGame()
    {
        Application.Quit();
    }
}