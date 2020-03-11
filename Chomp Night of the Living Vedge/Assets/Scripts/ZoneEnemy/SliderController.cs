using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderController : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void SetMaxHealth(int amount)
    {
        slider.maxValue = amount;
        slider.value = amount;

        fill.color = gradient.Evaluate(1f);
        
    }

    public void SetHealth(int amount)
    {
        slider.value = amount;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}