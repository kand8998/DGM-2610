using UnityEngine;
using Random = UnityEngine.Random;

public class RandomRotation : MonoBehaviour
{
    public GameAction rotateAction;
    
    private void Start()
    {
        rotateAction.action += RotateObject;
    }

    private void RotateObject()
    {
        var transformRotation = transform.rotation;
        transformRotation.x += 90f;
        
        Debug.Log("the function was called");
    }

    private void RotateObjectRandom()
    {
        transform.rotation = Random.rotation;
    }
}