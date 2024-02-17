namespace OnlineFoodDelivery.PaymentAdapter.PaymentMethods;

// Credit card payment adaptee
public class CreditCardPayment
{
    public void ChargeCreditCard(double amount)
    {
        Console.WriteLine($"Charging {amount} to the credit card.");
    }
}

// PayPal payment system adaptee
public class PayPalPayment
{
    public void SendPayment(double amount)
    {
        Console.WriteLine($"Sending {amount} using PayPal.");
    }
}
