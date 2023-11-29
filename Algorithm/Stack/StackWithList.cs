namespace Algorithm.Stack;

public class StackWithList
{
    private readonly List<int> list = new();
    private int Top = -1;

    public bool IsEmpty =>
        list.Any();

    public int Count =>
        list.Count;

    public int Push(int value)
    {
        list.Add(value);
        Top++;
        return value;
    }

    public int Pop()
    {
        int value = Peek();
        list.RemoveAt(Top);
        Top--;
        return value;
    }

    public int Peek()
    {
        IsvalidStack();
        return list[Top];
    }

    public void StackElements()
    {
        int count = 0;
        foreach (int item in list)
        {
            Console.WriteLine("S no. :" + ++count + " item: " + item);
        }
    }

    private void IsvalidStack()
    {
        if (Top < 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
    }
}
