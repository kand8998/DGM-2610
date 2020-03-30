using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/BoolData")]
public class BoolData : ScriptableObject
{
    public bool Switch;

    public void SetBoolTrue()
    {
        Switch = true;
    }
    
    public void SetBoolFalse()
    {
        Switch = false;
    }
}