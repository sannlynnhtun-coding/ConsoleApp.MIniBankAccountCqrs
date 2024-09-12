
// Create event store (shared by both services)

// Create the command and query services

// Perform some operations

// Query the current balance
public class WithdrawalEvent : BankAccountEvent
{
	public WithdrawalEvent(decimal amount) : base(amount) { }
}
