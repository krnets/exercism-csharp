using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        int n = number;
        int digitsLength = (int)Math.Log10(number) + 1;
        int sum = 0;

        while (n > 0)
        {
            sum += (int)Math.Pow(n % 10, digitsLength);
            n /= 10;
        }

        return sum == number;
    }
}