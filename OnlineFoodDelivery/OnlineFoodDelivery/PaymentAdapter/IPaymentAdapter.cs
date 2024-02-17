namespace OnlineFoodDelivery.PaymentAdapter;

// Adapter interface
public interface IPaymentAdapter
{
    void ProcessPayment(double amount);
}