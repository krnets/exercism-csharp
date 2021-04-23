using System.Collections;
using System.Collections.Generic;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    public SimpleLinkedList(T value)
    {
        Value = value;
    }

    public SimpleLinkedList(IEnumerable<T> values)
    {
        SimpleLinkedList<T> first = null, prev = null;

        foreach (var value in values)
        {
            var node = new SimpleLinkedList<T>(value);

            if (first == null)
                first = node;

            if (prev != null)
                prev.Next = node;

            prev = node;
        }

        Value = first.Value;
        Next = first.Next;
    }

    public T Value { get; }

    public SimpleLinkedList<T> Next { get; private set; }

    public SimpleLinkedList<T> Add(T value)
    {
        var node = this;

        while (node.Next != null)
            node = node.Next;

        node.Next = new SimpleLinkedList<T>(value);

        return this;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var node = this;

        while (node != null)
        {
            yield return node.Value;
            node = node.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}