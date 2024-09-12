
// Create event store (shared by both services)

// Create the command and query services

// Perform some operations

// Query the current balance
public class BankAccountCommandService
{
	private readonly EventStore _eventStore;

	public BankAccountCommandService(EventStore eventStore)
	{
		_eventStore = eventStore;
	}

	public void DepositMoney(decimal amount)
	{
		var depositEvent = new DepositEvent(amount);
		_eventStore.SaveEvent(depositEvent);
	}

	public void WithdrawMoney(decimal amount)
	{
		var withdrawalEvent = new WithdrawalEvent(amount);
		_eventStore.SaveEvent(withdrawalEvent);
	}
}
