using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public GameObject otherObj;

    public void DestroyThisObject()
    {
        Destroy(this.gameObject);
    }

    public void DestroyOtherObject()
    {
        Destroy(otherObj);
    }
}
