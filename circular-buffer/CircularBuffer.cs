using System;

public class CircularBuffer<T>
{
    private T[] buffer;
    private readonly int capacity;
    private int size;
    private int front;
    private int back;

    public CircularBuffer(int capacity)
    {
        this.capacity = capacity;
        Clear();
    }

    public T Read()
    {
        if (size == 0)
            throw new InvalidOperationException("Tried to read from empty buffer");

        T value = buffer[front];
        front = IncrementCircularPosition(front);
        size--;

        return value;
    }

    private int IncrementCircularPosition(int position) => (position + 1) % capacity;


    public void Write(T value)
    {
        if (size == capacity)
            throw new InvalidOperationException("Tried to write to full buffer");

        AddLast(value);
    }

    private void AddLast(T value)
    {
        buffer[back % capacity] = value;
        back = IncrementCircularPosition(back);
        size++;
    }

    public void Overwrite(T value)
    {
        if (size == capacity)
        {
            buffer[front] = value;
            front = IncrementCircularPosition(front);
        }
        else AddLast(value);
    }

    public void Clear()
    {
        buffer = new T[capacity];
        size = front = back = 0;
    }
}