namespace OnlineFoodDelivery.OrderObserver;

public class Order
{
    private List<IOrderObserver> observers = new List<IOrderObserver>();
    public string OrderStatus { get; set; }

    public void Attach(IOrderObserver observer)
    {
        observers.Add(observer);
    }
    
    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }
}