using System.Collections.Generic;
using System.Linq;

public static class BookStore
{
    private static readonly decimal BookPrice = 8m;

    public static decimal Total(IEnumerable<int> books)
    {
        List<int> cart = books.ToList();
        List<int> bundleSizes = new List<int>();
        int cartSize = cart.Count;

        while (cartSize > 0)
        {
            // find max bundle of distinct books
            var bundle = cart.ToHashSet();

            // if we find a bundle of 3 and we have previously
            // found a bundle of 5, remove the 5 bundle and
            // add two bundles of 4 as it is a better deal
            if (bundle.Count == 3 && bundleSizes.Contains(5))
            {
                bundleSizes.Remove(5);
                bundleSizes.AddRange(new[] {4, 4});
            }
            else bundleSizes.Add(bundle.Count);

            // remove the distinct books that we found from the cart
            foreach (var book in bundle)
                cart.Remove(book);

            cartSize = cart.Count;
        }

        return bundleSizes.Sum(CalculateDiscount);
    }

    private static decimal CalculateDiscount(int quantity)
    {
        decimal discount = quantity switch
        {
            2 => 0.95m,
            3 => 0.90m,
            4 => 0.80m,
            5 => 0.75m,
            _ => 1m
        };
        return quantity * BookPrice * discount;
    }
}