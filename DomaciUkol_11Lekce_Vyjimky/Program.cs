
using DomaciUkol_11Lekce_Vyjimky;

Account account = new Account("123456789/0800", "Sarka Mejzlikova");

Console.WriteLine(account.AccountNumber + " - " + account.OwnerName + " Balance: " + account.Balance);

try
{
    account.Deposit(100);
    account.Withdraw(-200);
    account.Withdraw(200);
    Console.WriteLine(account.Balance);
}
catch(DepositException ex)
{
    Console.WriteLine(ex.myMessage);
}
catch(WithdrawException ex)
{
    Console.WriteLine(ex.myMessage);
}
catch(BalanceException ex)
{
    Console.WriteLine(ex.myMessage);
}