namespace OnlineFoodDelivery.Iterator;

public class Menu : IMenu
{
    private List<MenuItem> menuItems;

    public Menu()
    {
        menuItems = new List<MenuItem>();
        
        // Some menu items
        AddItem("Pizza", 10.00);
        AddItem("Burek", 7.00);
        AddItem("Yogurt", 3.00 );
    }

    private void AddItem(string name, double price)
    {
        MenuItem menuItem = new MenuItem(name, price);
        menuItems.Add(menuItem);
    }

    public IMenuIterator CreateIterator()
    {
        return new MenuIterator(menuItems);
    }
}