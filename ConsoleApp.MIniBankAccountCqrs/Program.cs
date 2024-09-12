Console.WriteLine("Mini Bank Account CQRS");

// Create event store (shared by both services)
var eventStore = new EventStore();

// Create the command and query services
var commandService = new BankAccountCommandService(eventStore);
var queryService = new BankAccountQueryService(eventStore);

// Perform some operations
commandService.DepositMoney(1000);
commandService.WithdrawMoney(200);
commandService.DepositMoney(500);

// Query the current balance
var balance = queryService.GetBalance();
Console.WriteLine($"Current Balance: {balance}"); // Output: Current Balance: 1300
Console.ReadKey();