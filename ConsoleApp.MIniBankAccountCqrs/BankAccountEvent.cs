
// Create event store (shared by both services)

// Create the command and query services

// Perform some operations

// Query the current balance
public abstract class BankAccountEvent
{
	public DateTime Timestamp { get; private set; } = DateTime.UtcNow;
	public decimal Amount { get; private set; }

	public BankAccountEvent(decimal amount)
	{
		Amount = amount;
	}
}
