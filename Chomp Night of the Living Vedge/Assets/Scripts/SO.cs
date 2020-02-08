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
public class GameAction : ScriptableObject
{
    public UnityAction action;
    public object call;
    public UnityAction<Transform> transformAction;

    public void Raise()
    {
        action?.Invoke();
    }

    public void Raise(Transform transformObj)
    {
        transformAction?.Invoke(transformObj);
    }
}

[CreateAssetMenu(menuName = "Single Variables/FloatData")]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float maxValue = 1f;
    public void UpdateValue(float amount)
    {
        value += amount;
    }

    private void UpdateValueLimitZero(float amount)
    {
        if (value > 0)
        {
            UpdateValue(amount);
        }
        else
        {
            value = 0;
        }
    }

    public void UpdateValueLimitZeroAndMaxValue(float amount)
    {
        if (value <= maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }
        
        UpdateValueLimitZero(amount);
    }

    public void ChangeAmount(float amount)
    {
        value = amount;
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

