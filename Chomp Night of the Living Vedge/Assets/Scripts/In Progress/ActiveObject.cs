using UnityEngine;

[CreateAssetMenu(menuName = "Tools/SetActive")]
public class ActiveObject : ScriptableObject
{

    public void SetActiveTrue(GameObject obj)
    {
        obj.SetActive(true);
    }

    public void SetActiveFalse(GameObject obj)
    {
        obj.SetActive(false);
    }
}
