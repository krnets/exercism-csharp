public class Node<T>
{
    public readonly T value;
    public Node<T> next;
    public Node<T> previous;

    public Node() { }

    public Node(Node<T> next)
    {
        this.next = next;
    }

    public Node(T value, Node<T> next, Node<T> previous)
    {
        this.value = value;
        this.next = next;
        this.previous = previous;
    }
}