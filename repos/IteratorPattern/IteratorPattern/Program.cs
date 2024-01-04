using System;
using System.Collections;

// Define the Iterator interface
public interface IIterator
{
    bool HasNext();
    object Next();
}

// Define the Aggregate interface
public interface IAggregate
{
    IIterator CreateIterator();
}

// Concrete Iterator
public class ConcreteIterator : IIterator
{
    private readonly ArrayList _collection;
    private int _currentIndex = 0;

    public ConcreteIterator(ArrayList collection)
    {
        _collection = collection;
    }

    public bool HasNext()
    {
        return _currentIndex < _collection.Count;
    }

    public object Next()
    {
        if (HasNext())
        {
            object nextItem = _collection[_currentIndex];
            _currentIndex++;
            return nextItem;
        }
        else
        {
            return null;
        }
    }
}

// Concrete Aggregate
public class ConcreteAggregate : IAggregate
{
    private readonly ArrayList _collection = new ArrayList();

    public void AddItem(object item)
    {
        _collection.Add(item);
    }

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(_collection);
    }
}

class Program
{
    static void Main()
    {
        ConcreteAggregate aggregate = new ConcreteAggregate();
        aggregate.AddItem("Item 1");
        aggregate.AddItem("Item 2");
        aggregate.AddItem("Item 3");

        IIterator iterator = aggregate.CreateIterator();

        while (iterator.HasNext())
        {
            object currentItem = iterator.Next();
            Console.WriteLine(currentItem);
          
        }
    }
}
