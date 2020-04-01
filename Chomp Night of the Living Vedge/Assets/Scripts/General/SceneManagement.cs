using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class SceneManagement : ScriptableObject
{
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void LoadScene (string byName)
    {
        SceneManager.LoadScene(byName);
    }
}