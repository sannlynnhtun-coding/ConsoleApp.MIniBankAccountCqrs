namespace ConsoleApp.MIniBankAccountCqrs.Models;

public class WithdrawalEvent : BankAccountEvent
{
	public WithdrawalEvent(decimal amount) : base(amount) { }
}