namespace Algorithm.Stack;

public class StackWithArrays
{
    private readonly static int arrayLength = 10;
    int[] arr = new int[arrayLength];
    int Top = -1;

    public bool IsEmpty =>
        Top < 0;

    public int Count => 
        arr.Length;

    public int StackCapacity
        => arrayLength;

    public int Push(int value) 
    {
        if (Top > arrayLength)
            throw new InvalidOperationException("Stack overflow.");
        arr[++Top] = value; return value;
    }

    public int Pop()
    {
        int value = Peek();
        Top--;
        return value;
    }

    public int Peek() 
    {
        IsvalidStack();
        return arr[Top];
    }
        
    
    public void StackElements() 
    {
        int count = 0;
        foreach (int item in arr)
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
