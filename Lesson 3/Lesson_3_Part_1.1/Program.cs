Console.WriteLine("Введите номер вашего банковского счета");
int myAcc = int.Parse(Console.ReadLine());


Console.WriteLine("Введите номер счета на который хотите осуществить перевод денежных средств");
int someAcc = int.Parse(Console.ReadLine());


Console.WriteLine($"Какую сумму вы хотите перевести на счет {someAcc} ? ");
int moneyToSend = int.Parse(Console.ReadLine());

BankAccount process = new BankAccount(myAcc, moneyToSend);

process.Print();


class BankAccount
{
    private int accId;
    private int moneyToSend;
    

    public BankAccount(int a1, int m1) { accId = a1; moneyToSend = m1; }
       

    public void Print ()
    {
        Console.WriteLine($"Со счета {accId} было переведено {moneyToSend}$");
    }
   
}

