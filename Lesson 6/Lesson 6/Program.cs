using Lesson_6;

/*
Для класса банковский счет переопределить операторы == и != для
сравнения информации в двух счетах. Переопределить метод Equals
аналогично оператору ==, не забыть переопределить метод
GetHashCode(). Переопределить метод ToString() для печати
информации о счете. Протестировать функционирование
переопределенных методов и операторов на простом примере.
*/


Console.WriteLine("Введите название банка вашей 1 карты");
string cardName1 = Console.ReadLine();
Console.WriteLine("Введите сумму, которую вы бы хотели положить на 1 счет");
int cardBalance1 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("Введите название банка вашей 2 карты");
string cardName2 = Console.ReadLine();
Console.WriteLine("Введите сумму, которую вы бы хотели положить на 2 счет");
int cardBalance2 = int.Parse(Console.ReadLine());

BankAcc balance = new BankAcc(cardBalance1, cardName1);
BankAcc balance2 = new BankAcc(cardBalance2,cardName2);

Console.Clear();

if (balance.Equals(balance2) == false)
{
    Console.WriteLine(
        $"Кол-во средств на счетах разное { Environment.NewLine}" +
        $"{cardName1.ToString()} ---- {cardBalance1.ToString()}{Environment.NewLine}" +
        $"{cardName2.ToString()} ---- {cardBalance2.ToString()}{Environment.NewLine}");
}
else
{
    Console.WriteLine(
        $"Кол-во средств на счетах одинаковое { Environment.NewLine}" +
        $"{cardName1.ToString()} ---- {cardBalance1.ToString()}{Environment.NewLine}" +
        $"{cardName2.ToString()} ---- {cardBalance2.ToString()}{Environment.NewLine}");

    
}


