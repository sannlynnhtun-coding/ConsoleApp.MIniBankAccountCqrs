namespace ConsoleApp.MIniBankAccountCqrs.Models;

public abstract class BankAccountEvent
{
	public DateTime Timestamp { get; private set; } = DateTime.UtcNow;
	public decimal Amount { get; private set; }

	public BankAccountEvent(decimal amount)
	{
		Amount = amount;
	}
}