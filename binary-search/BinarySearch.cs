public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int low = 0;
        int high = input.Length - 1;
        int mid;

        while (low <= high)
        {
            mid = (high + low) / 2;

            if (value == input[mid])
                return mid;
            if (value < input[mid]) 
                high = mid - 1;
            else low = mid + 1;
        }
        return -1;
    }
}