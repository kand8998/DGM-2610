using UnityEngine;

[CreateAssetMenu]
public class FloatMathSystem : WorkSystem
{
    public FloatData dataObj;
    
    public override void Work()
    {
        dataObj.value++;
        workEvent.Invoke();
    }
}
