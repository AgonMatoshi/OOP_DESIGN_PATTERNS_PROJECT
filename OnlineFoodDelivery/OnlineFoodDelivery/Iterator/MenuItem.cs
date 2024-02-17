namespace OnlineFoodDelivery.Iterator;

public class MenuItem
{
    public string Name { get; private set; }
    public double Price { get; private set; }

    public MenuItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"{Name} - ${Price}";
    }
}