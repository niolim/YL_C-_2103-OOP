using Lesson_7;
using System.Text;


/*
Определить интерфейс IСoder, который полагает методы поддержки шифрования
строк. В интерфейсе объявляются два метода Encode() и Decode(),
используемые для шифрования и дешифрования строк. Создать класс ACoder,
реализующий интерфейс ICoder. Класс шифрует строку посредством сдвига
каждого символа на одну «алфавитную» позицию выше. (В результате такого
сдвига буква А становится буквой Б). Создать класс BCoder, реализующий
интерфейс ICoder. Класс шифрует строку, выполняя замену каждой буквы,
стоящей в алфавите на i-й позиции, на букву того же регистра, расположенную в
алфавите на i-й позиции с конца алфавита. (Например, буква В заменяется на
букву Э. Написать программу, демонстрирующую функционирование классов)
*/


ICoder codeRef;
BCoder bCode = new BCoder(k: 27);
ACoder aCode = new ACoder(); string before; string result;


codeRef = aCode;
Console.WriteLine("Введите первое слово на английском языке, которое хотите зашифровать");
before = Console.ReadLine();
result = codeRef.Encode(before);
Console.WriteLine($"Зашифрованный текст: {result}");
before = codeRef.Decode(result);
Console.WriteLine($"Расшифрованный текст: {before}");

Console.WriteLine();
Console.WriteLine();

codeRef = bCode;
Console.WriteLine("Введите второе слово на английском языке, которое хотите зашифровать");
before = Console.ReadLine();
result = codeRef.Encode(before);
Console.WriteLine($"Зашифрованный текст: {result}");
before = codeRef.Decode(result);
Console.WriteLine($"Расшифрованный текст: {before}");










