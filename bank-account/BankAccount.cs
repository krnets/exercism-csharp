using System;

public class BankAccount
{
    private decimal _balance = 0;
    private bool AccountIsActive { get; set; }
    public decimal Balance => AccountIsActive ? _balance : throw new InvalidOperationException();
    private readonly object _lock = new object();

    public void Open()
    {
        lock (_lock) { AccountIsActive = true; }
    }

    public void Close()
    {
        lock (_lock) { AccountIsActive = false; }
    }

    public void UpdateBalance(decimal change)
    {
        lock (_lock)
        {
            if (!AccountIsActive) { throw new InvalidOperationException(); }

            _balance += change;
        }
    }
}