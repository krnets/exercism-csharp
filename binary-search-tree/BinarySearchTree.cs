using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class BinarySearchTree : IEnumerable<int>
{
    public int Value { get; }
    public BinarySearchTree Left { get; private set; }
    public BinarySearchTree Right { get; private set; }
    public BinarySearchTree(int rootValue) => Value = rootValue;
    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

    public BinarySearchTree(IEnumerable<int> values) : this(values.First())
    {
        foreach (var x in values.Skip(1)) Add(x);
    }

    public BinarySearchTree Add(int value)
    {
        if (value <= Value)
            Left = Left?.Add(value) ?? new BinarySearchTree(value);
        else Right = Right?.Add(value) ?? new BinarySearchTree(value);

        return this;
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var leftValue in Left?.AsEnumerable() ?? Enumerable.Empty<int>()) yield return leftValue;

        yield return Value;

        foreach (var rightValue in Right?.AsEnumerable() ?? Enumerable.Empty<int>()) yield return rightValue;
    }
}