using UnityEngine;

[CreateAssetMenu(menuName = "Tools/AnimController")]
public class AnimController : ScriptableObject
{
    public void AnimCall(Animator animator)
    {
        animator.SetTrigger(name);
    }
}