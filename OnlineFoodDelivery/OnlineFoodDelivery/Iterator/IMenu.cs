namespace OnlineFoodDelivery.Iterator;

public interface IMenu
{
    IMenuIterator CreateIterator();
}

public interface IMenuIterator
{
    bool HasNext();
    MenuItem Next();
}