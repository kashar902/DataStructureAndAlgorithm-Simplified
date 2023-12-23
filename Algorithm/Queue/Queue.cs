namespace SimplifiedDSA.Queue;

public class Queue<T>
{
    private List<T> list = new();

    public bool IsEmpty => list.Count == 0;

    public void Enqueue(T value) => list.Add(value);

    public T Dequeue()
    {
        IsValidQueue();
        T removedValue = list[0];
        list.RemoveAt(0);
        return removedValue;
    }

    public T Peek()
    {
        IsValidQueue();
        return list[0];
    }

    public void PrintElements()
    {
        int count = 0;
        foreach (T item in list)
        {
            Console.WriteLine($"Element {++count}: {item}");
        }
    }

    private void IsValidQueue()
    {
        if (list.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
    }
}
