namespace ConsoleApp.MIniBankAccountCqrs.EventStore;

public class EventStore
{
	private readonly List<BankAccountEvent> _events = new List<BankAccountEvent>();

	public void SaveEvent(BankAccountEvent bankEvent)
	{
		_events.Add(bankEvent);
	}

	public List<BankAccountEvent> GetEvents()
	{
		return _events;
	}
}