using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class GradientController : ScriptableObject
{
    public Gradient gradient;
    public Image fill;
    
    private void SetGradient()
    {
        fill.color = gradient.Evaluate(1f); 
    }

    private void UpdateGradient(FloatData amount)
    {
        fill.color = gradient.Evaluate(amount.value);
    }
}
