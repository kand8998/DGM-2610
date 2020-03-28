using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TextMeshBehaviour : MonoBehaviour
{
    private TextMeshProUGUI textObj;
    public UnityEvent startEvent;
  
    private void Start()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }
    
    public void UpdateText(FloatData floatDataObj)
    {
        textObj.text = floatDataObj.value.ToString();
    }
}