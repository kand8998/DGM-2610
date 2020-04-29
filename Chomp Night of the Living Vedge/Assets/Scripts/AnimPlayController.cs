using UnityEngine;

public class AnimPlayController : MonoBehaviour
{
    public BoolData playBoolObj;
    
    private void Awake()
    {
        if (playBoolObj.Switch == true)
        {
            playBoolObj.Switch = false;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}