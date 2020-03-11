using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class EnemyHealthImageController : MonoBehaviour
{
    private Image imageComponent;
    public EnemyStats enemy;
    public Gradient gradient;
    
    private void Start()
    {
        imageComponent = GetComponent<Image>();
        imageComponent.fillAmount = 1;
        imageComponent.color = gradient.Evaluate(1f);
    }

    public void UpdateImageComponent()
    {
        imageComponent.fillAmount = enemy.currentHealth;
        imageComponent.color = gradient.Evaluate(imageComponent.fillAmount);
    }
}
