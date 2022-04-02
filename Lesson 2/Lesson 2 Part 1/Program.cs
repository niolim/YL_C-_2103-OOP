BankAccount newAccount = new BankAccount();

Random random = new Random();

int id = random.Next(100000000,999999999);

Console.WriteLine("Какую сумму вы хотите положить на свой счет?");
int money = int.Parse(Console.ReadLine());

Console.WriteLine(
    $"Какой тип счета вы хотите открыть? {Environment.NewLine}" +
    $"1 - Депозитный {Environment.NewLine}" +
    $"2 - Кредитный");
int choice = int.Parse(Console.ReadLine());
if (choice < 2)
{
    newAccount.AccType = BankAccountType.deposit;
}
else
{
    newAccount.AccType = BankAccountType.credit;
}

newAccount.AccId = id;
newAccount.AccBalance = money;
newAccount.Print();

 class BankAccount
{
    private int accId;
    private int accBalance;
    private BankAccountType accType;

    public int AccId
    {
        get { return accId; }
        set { accId = value; }
    }

    public int AccBalance
    {
        get { return accBalance; }  
        set { accBalance = value; } 
    }

    public BankAccountType AccType
    {
        get { return accType; }
        set { accType = value; }
    }

    public void Print()
    {
        Console.WriteLine(
            $"Номер счета клиента - {AccId} {Environment.NewLine}" +
            $"Сумма на счету - {AccBalance}$ {Environment.NewLine}" +
            $"Тип счета - {AccType}");
    }



}

public enum BankAccountType
{
    deposit,
    credit
}