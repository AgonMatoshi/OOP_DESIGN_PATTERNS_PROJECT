namespace OnlineFoodDelivery.OrderObserver;

public class Customer : IOrderObserver
{
    public void Update(Order order)
    {
        Console.WriteLine($"Customer notified: Order {order.OrderStatus}");
    }
}

public class Restaurant : IOrderObserver
{
    public void Update(Order order)
    {
        Console.WriteLine($"Restaurant notified: Order {order.OrderStatus}");
    }
}

public class DeliveryPerson : IOrderObserver
{
    public void Update(Order order)
    {
        Console.WriteLine($"Delivery person notified: Order {order.OrderStatus}");
    }
}