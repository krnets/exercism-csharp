using System;

public class Deque<T>
{
    private readonly Node<T> header;
    private readonly Node<T> trailer;
    private int size;

    public Deque()
    {
        header = new Node<T>();
        trailer = new Node<T>(header);
        header.previous = trailer;
        size = 0;
    }

    public void Push(T value)
    {
        var node = new Node<T>(value, trailer.next, trailer);
        trailer.next.previous = node;
        trailer.next = node;
        size++;
    }

    public T Pop()
    {
        if (size == 0) throw new Exception();

        T element = trailer.next.value;

        trailer.next = trailer.next.next;
        trailer.next.previous = trailer;
        size--;

        return element;
    }

    public void Unshift(T value)
    {
        var node = new Node<T>(value, header, header.previous);
        header.previous.next = node;
        header.previous = node;
        size++;
    }

    public T Shift()
    {
        if (size == 0) throw new Exception();

        T element = header.previous.value;

        header.previous = header.previous.previous;
        header.previous.next = header;
        size--;

        return element;
    }
}