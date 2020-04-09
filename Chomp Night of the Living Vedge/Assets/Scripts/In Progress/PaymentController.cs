using UnityEngine;
using UnityEngine.Events;

public class PaymentController : MonoBehaviour
{
    public float paymentAmount = 300f;
    public FloatData valueObj;
    public UnityEvent badPaymentEvent, goodPaymentEvent;
    

    public void MakePayment()
    {
        if (valueObj.value <= paymentAmount)
        {
            badPaymentEvent.Invoke();
        }

        if (valueObj.value > paymentAmount)
        {
            goodPaymentEvent.Invoke();
        }
    }
}