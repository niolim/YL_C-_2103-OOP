BankAccount newAccount = new BankAccount();

Console.WriteLine("Введите номер вашего банковского счета");
int myAcc = int.Parse(Console.ReadLine());
newAccount.AccId = myAcc;

Console.WriteLine("Какую сумму вы хотите положить на свой счет?");
int myMoney = int.Parse(Console.ReadLine());
newAccount.AccBalance = myMoney;
Console.Clear();
newAccount.PrintMyInfo();
Console.WriteLine("Нажмите любую клавишу для продолжения операций");
Console.ReadKey();

Console.WriteLine();

Console.WriteLine("Введите номер счета на который хотите осуществить перевод денежных средств");
int someAcc = int.Parse(Console.ReadLine());
newAccount.AccId2 = someAcc;


Console.WriteLine($"Какую сумму вы хотите перевести на счет {someAcc} ? ");
int moneyToSend = int.Parse(Console.ReadLine());
newAccount.AccBalance2 = moneyToSend;
Console.Clear();
newAccount.PrintLastInfo();
Console.ReadKey();



class BankAccount
{
    private int accId;
    private int accId2;
    private int accBalance;
    private int accBalance2;

    public int AccId
    {
        get { return accId; }
        set { accId = value; }
    }

    public int AccId2
    {
        get { return accId2; }  
        set { accId2 = value; }
    }

    public int AccBalance
    {
        get { return accBalance; }
        set { accBalance = value; }
    }

    public int AccBalance2
    {
        get { return accBalance2; }
        set { accBalance2 = value; }
    }

     public void PrintMyInfo()
    {
        Console.WriteLine(
            $"Номер вашего счета - {AccId} {Environment.NewLine}" +
            $"Сумма на вашем счету - {AccBalance}");
    }

    public void PrintLastInfo()
    {
        Console.WriteLine(
            $"Со счета {AccId} был совершен перевод на сумму {AccBalance2}$ на счет {AccId2}.{Environment.NewLine}" +
            $"Остаток средств на вашем счету {AccBalance - AccBalance2}.");
    }

}

