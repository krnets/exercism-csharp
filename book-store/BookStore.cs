using System.Collections.Generic;
using System.Linq;

public static class BookStore
{
    private static readonly decimal BookPrice = 8m;

    public static decimal Total(IEnumerable<int> books)
    {
        List<int> cart = books.ToList();
        List<int> bundles = new List<int>();
        int cartCount = cart.Count;

        while (cartCount > 0)
        {
            // find max bundle of distinct books
            var bundle = cart.ToHashSet();
            int bundleSize = bundle.Count;

            // if we find a bundle of 3 and we have previously
            // found a bundle of 5, remove the 5 bundle and
            // add two bundles of 4 as it is a better deal
            if (bundleSize == 3 && bundles.Contains(5))
            {
                bundles.Remove(5);
                bundles.AddRange(new[] {4, 4});
            }
            else bundles.Add(bundleSize);

            // remove the distinct books that we found from the cart
            foreach (var book in bundle)
                cart.Remove(book);

            cartCount = cart.Count;
        }

        return bundles.Sum(CalculateDiscount);
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