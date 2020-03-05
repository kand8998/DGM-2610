using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class InstanceObject : ScriptableObject
{
    public Transform location;
    public GameObject instanceObj;
    
    public void Instance()
    {
        Instantiate(instanceObj);
    }
    public void InstanceAtLocation()
    {
        Instantiate(instanceObj, location.position, location.rotation);
    }
}

[CreateAssetMenu]
public class SceneManagement : ScriptableObject
{
    public void LoadScene (Object sceneName)
    {
        var newName = sceneName.name;
        SceneManager.LoadScene(newName);
    }
}

[CreateAssetMenu]
public class Debugger : ScriptableObject
{
    public void OnDebug(string message)
    {
        Debug.Log(message);
    }
}

