namespace ConsoleApp.MIniBankAccountCqrs.Services;

public class BankAccountCommandService
{
	private readonly EventStore.EventStore _eventStore;

	public BankAccountCommandService(EventStore.EventStore eventStore)
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