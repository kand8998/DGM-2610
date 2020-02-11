using UnityEngine;
using UnityEngine.Events;

public class DestroyObj : MonoBehaviour
{
    public GameObject otherObj;
    public GameAction thisDestroyAction, otherDestroyAction;
    private void Start()
    {
        thisDestroyAction.action += DestroyThisObject;
        otherDestroyAction.action += DestroyOtherObject;
    }

    private void DestroyThisObject()
    {
        Destroy(this.gameObject);
    }

    private void DestroyOtherObject()
    {
        Destroy(otherObj);
    }
}
