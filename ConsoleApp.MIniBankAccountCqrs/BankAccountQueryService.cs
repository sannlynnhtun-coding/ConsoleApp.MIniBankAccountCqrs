
// Create event store (shared by both services)

// Create the command and query services

// Perform some operations

// Query the current balance
public class BankAccountQueryService
{
	private readonly EventStore _eventStore;

	public BankAccountQueryService(EventStore eventStore)
	{
		_eventStore = eventStore;
	}

	public decimal GetBalance()
	{
		decimal balance = 0;

		foreach (var bankEvent in _eventStore.GetEvents())
		{
			if (bankEvent is DepositEvent)
				balance += bankEvent.Amount;
			else if (bankEvent is WithdrawalEvent)
				balance -= bankEvent.Amount;
		}

		return balance;
	}
}
