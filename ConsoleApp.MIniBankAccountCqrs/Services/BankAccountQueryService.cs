namespace ConsoleApp.MIniBankAccountCqrs.Services;

public class BankAccountQueryService
{
	private readonly EventStore.EventStore _eventStore;

	public BankAccountQueryService(EventStore.EventStore eventStore)
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