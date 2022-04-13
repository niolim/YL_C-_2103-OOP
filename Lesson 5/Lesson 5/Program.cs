using Lesson_5;
/*
Создать класс рациональных чисел. В классе два поля – числитель и
знаменатель. Предусмотреть конструктор. Определить операторы ==, != (метод
Equals()), <, >, <=, >=, +, – , ++, --. Переопределить метод ToString() для вывода
дроби. Определить операторы преобразования типов между типом дробь, float, int.
Определить операторы *, /, %
*/

Rn x = new Rn(1, 5);
Rn y = new Rn(2, 10);

Rn z = x * y;
Rn d = x / y;
Rn e = x + y;
Rn f = x - y;

Console.WriteLine(z > d);
Console.WriteLine(d > e);
Console.WriteLine(f < z);
Console.WriteLine(z > e);



Console.WriteLine(z.ToString());
Console.WriteLine(d.ToString());
Console.WriteLine(e.ToString());
Console.WriteLine(f.ToString());

Console.WriteLine(x > y);
Console.WriteLine(y <= x);
Console.WriteLine(x >= y);

Console.WriteLine(x != y);
Console.WriteLine(x == y);

Console.WriteLine(e == d);





