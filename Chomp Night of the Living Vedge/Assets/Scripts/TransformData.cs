using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/TransformData")]
public class TransformData : ScriptableObject
{
    public Transform value;
       
    public void UpdateValue(Transform obj)
    {
        value = obj.transform;
    }

    public void UpdateTransform(Transform obj)
    {
        obj.localPosition = value.position;
    }
}