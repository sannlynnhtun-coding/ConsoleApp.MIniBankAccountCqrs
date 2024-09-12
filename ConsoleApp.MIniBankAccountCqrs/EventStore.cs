
// Create event store (shared by both services)

// Create the command and query services

// Perform some operations

// Query the current balance
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
