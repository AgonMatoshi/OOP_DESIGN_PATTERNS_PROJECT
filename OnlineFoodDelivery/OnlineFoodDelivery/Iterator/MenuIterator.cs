namespace OnlineFoodDelivery.Iterator;

public class MenuIterator : IMenuIterator
{
    private readonly List<MenuItem> menuItems;
    private int position = 0;

    public MenuIterator(List<MenuItem> menuItems)
    {
        this.menuItems = menuItems;
    }

    public bool HasNext()
    {
        return position < menuItems.Count;
    }

    public MenuItem Next()
    {
        if (!HasNext())
        {
            return null;
        }
        MenuItem menuItem = menuItems[position];
        position += 1;
        return menuItem;
    }
}