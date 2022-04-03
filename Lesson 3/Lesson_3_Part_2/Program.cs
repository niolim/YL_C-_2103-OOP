Console.WriteLine("Введите символы");

StringR(Console.ReadLine());

string StringR(string s)
{
    for (int i = s.Length - 1; i <= s.Length; i--)
    {
        Console.Write(s[i]);
        if (i <= 0) break;

    }
    return s;
}