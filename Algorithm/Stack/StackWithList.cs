namespace SimplifiedDSA.Stack;

public class StackWithList<T>
{
    private readonly List<T> _list = new();
    private int _top = -1;

    public bool IsEmpty =>
        _list.Any();

    public int Count =>
        _list.Count;

    public T Push(T value)
    {
        _list.Add(value);
        _top++;
        return value;
    }

    public T Pop()
    {
        T value = Peek();
        _list.RemoveAt(_top);
        _top--;
        return value;
    }

    public T Peek()
    {
        IsValidStack();
        return _list[_top];
    }

    public void StackElements()
    {
        int count = 0;
        foreach (T item in _list)
        {
            Console.WriteLine($"Element {++count}: {item}");
        }
    }

    private void IsValidStack()
    {
        if (_top < 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
    }
}
