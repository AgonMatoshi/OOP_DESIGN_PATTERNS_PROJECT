using OnlineFoodDelivery.PaymentAdapter.PaymentMethods;

namespace OnlineFoodDelivery.PaymentAdapter;

// Adapter for Credit Card Payment
public class CreditCardPaymentAdapter : IPaymentAdapter
{
    private readonly CreditCardPayment _creditCardPayment;

    public CreditCardPaymentAdapter(CreditCardPayment creditCardPayment)
    {
        _creditCardPayment = creditCardPayment;
    }

    public void ProcessPayment(double amount)
    {
        _creditCardPayment.ChargeCreditCard(amount);
    }
}

// Adapter for PayPal Payment
public class PayPalPaymentAdapter : IPaymentAdapter
{
    private readonly PayPalPayment _payPalPayment;

    public PayPalPaymentAdapter(PayPalPayment payPalPayment)
    {
        _payPalPayment = payPalPayment;
    }

    public void ProcessPayment(double amount)
    {
        _payPalPayment.SendPayment(amount);
    }
}
