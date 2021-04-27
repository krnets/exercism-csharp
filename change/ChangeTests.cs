using System;
using Xunit;

public class ChangeTests
{
    [Fact]
    public void Single_coin_change()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 25;
        var expected = new[] {25};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    /*
    [Fact]
    public void Test1()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 1;
        var expected = new[] {1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test2()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 2;
        var expected = new[] {1, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test3()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 3;
        var expected = new[] {1, 1, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test4()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 4;
        var expected = new[] {1, 1, 1, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test5()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 5;
        var expected = new[] {5};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test6()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 6;
        var expected = new[] {5, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test7()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 7;
        var expected = new[] {5, 1, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test8()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 8;
        var expected = new[] {5, 1, 1, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test9()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 9;
        var expected = new[] {5, 1, 1, 1, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test10()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 10;
        var expected = new[] {10};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test11()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 11;
        var expected = new[] {10, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test12()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 12;
        var expected = new[] {10, 1, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test15()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 15;
        var expected = new[] {10, 5};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test16()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 16;
        var expected = new[] {10, 5, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test20()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 20;
        var expected = new[] {10, 10};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test21()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 21;
        var expected = new[] {10, 10, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test24()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 24;
        var expected = new[] {10, 10, 1, 1, 1, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test25()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 25;
        var expected = new[] {25};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test26()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 26;
        var expected = new[] {25, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Test99()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 99;
        var expected = new[] {25, 25, 25, 10, 10, 1, 1, 1, 1};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }
    */

    [Fact]
    public void Multiple_coin_change()
    {
        var coins = new[] {1, 5, 10, 25, 100};
        var target = 15;
        var expected = new[] {5, 10};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Change_with_lilliputian_coins()
    {
        var coins = new[] {1, 4, 15, 20, 50};
        var target = 23;
        var expected = new[] {4, 4, 15};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Change_with_lower_elbonia_coins()
    {
        var coins = new[] {1, 5, 10, 21, 25};
        var target = 63;
        var expected = new[] {21, 21, 21};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Large_target_values()
    {
        var coins = new[] {1, 2, 5, 10, 20, 50, 100};
        var target = 999;
        var expected = new[] {2, 2, 5, 20, 20, 50, 100, 100, 100, 100, 100, 100, 100, 100, 100};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Possible_change_without_unit_coins_available()
    {
        var coins = new[] {2, 5, 10, 20, 50};
        var target = 21;
        var expected = new[] {2, 2, 2, 5, 10};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Another_possible_change_without_unit_coins_available()
    {
        var coins = new[] {4, 5};
        var target = 27;
        var expected = new[] {4, 4, 4, 5, 5, 5};
        Assert.Equal(expected, Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void No_coins_make_0_change()
    {
        var coins = new[] {1, 5, 10, 21, 25};
        var target = 0;
        Assert.Empty(Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Error_testing_for_change_smaller_than_the_smallest_of_coins()
    {
        var coins = new[] {5, 10};
        var target = 3;
        Assert.Throws<ArgumentException>(() => Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Error_if_no_combination_can_add_up_to_target()
    {
        var coins = new[] {5, 10};
        var target = 94;
        Assert.Throws<ArgumentException>(() => Change.FindFewestCoins(coins, target));
    }

    [Fact]
    public void Cannot_find_negative_change_values()
    {
        var coins = new[] {1, 2, 5};
        var target = -5;
        Assert.Throws<ArgumentException>(() => Change.FindFewestCoins(coins, target));
    }
}