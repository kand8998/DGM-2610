using UnityEngine;

public class AnimPlayController : MonoBehaviour
{
    public BoolData playBoolObj;
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        if (playBoolObj.Switch == true)
        {
            playBoolObj.Switch = false;
        }

        if (playBoolObj.Switch == false)
        {
            gameObject.SetActive(false);
        }
    }
}
