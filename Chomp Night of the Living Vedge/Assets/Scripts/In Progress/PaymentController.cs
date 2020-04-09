using UnityEngine;
using UnityEngine.Events;

public class PaymentController : MonoBehaviour
{
    public FloatData valueObj;
    public UnityEvent badPaymentEvent, goodPaymentEvent;

    public void MakePayment()
    {
        if (valueObj.value <= 200)
        {
            badPaymentEvent.Invoke();
        }

        if (valueObj.value > 200)
        {
            goodPaymentEvent.Invoke();
        }
    }
}
