
// Create event store (shared by both services)

// Create the command and query services

// Perform some operations

// Query the current balance
public class DepositEvent : BankAccountEvent
{
	public DepositEvent(decimal amount) : base(amount) { }
}
