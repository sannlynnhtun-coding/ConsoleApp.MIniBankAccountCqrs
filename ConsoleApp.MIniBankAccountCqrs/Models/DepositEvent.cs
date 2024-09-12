namespace ConsoleApp.MIniBankAccountCqrs.Models;

public class DepositEvent : BankAccountEvent
{
	public DepositEvent(decimal amount) : base(amount) { }
}