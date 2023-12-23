namespace SimplifiedDSA.Stack;

public class StackWithArrays<T>
{
    private const int ArrayLength = 10;
    T[] _arr = new T[ArrayLength];
    int _top = -1;

    public bool IsEmpty =>
        _top < 0;

    public int Count => 
        _arr.Length;

    public int StackCapacity
        => ArrayLength;

    public T Push(T value) 
    {
        if (_top > ArrayLength)
            throw new InvalidOperationException("Stack overflow.");
        _arr[++_top] = value; return value;
    }

    public T Pop()
    {
        T value = Peek();
        _top--;
        return value;
    }

    public T Peek() 
    {
        IsvalidStack();
        return _arr[_top];
    }
        
    
    public void StackElements() 
    {
        int count = 0;
        foreach (T item in _arr)
        {
            Console.WriteLine($"Element {++count}: {item}");
        }
    }
    
    private void IsvalidStack() 
    {
        if (_top < 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
    }
}
