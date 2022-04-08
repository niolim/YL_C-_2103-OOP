using Lesson_4;


BuildingDescription building1 =  new BuildingDescription();
building1.iD = Guid.NewGuid();
Console.WriteLine("Дайте имя новому жилому комплексу");
building1.SetName(Console.ReadLine());
Console.WriteLine("Выберите кол-во этажей в одном доме от 1 до 12");
building1.SetFloors(int.Parse(Console.ReadLine()));
Console.WriteLine("Выберите кол-во подъездов в одном доме от 1 до 10");
building1.SetEnt(int.Parse(Console.ReadLine()));
Console.WriteLine("Выберите кол-во квартир на одном этаже от 1 до 5");
building1.SetApp(int.Parse(Console.ReadLine()));

Console.Clear();

BuildingDescription building2 = new BuildingDescription();
building2.iD = Guid.NewGuid();
Console.WriteLine("Дайте имя новому жилому комплексу");
building2.SetName(Console.ReadLine());
Console.WriteLine("Выберите кол-во этажей в одном доме от 1 до 12");
building2.SetFloors(int.Parse(Console.ReadLine()));
Console.WriteLine("Выберите кол-во подъездов в одном доме от 1 до 10");
building2.SetEnt(int.Parse(Console.ReadLine()));
Console.WriteLine("Выберите кол-во квартир на одном этаже от 1 до 5");
building2.SetApp(int.Parse(Console.ReadLine()));

Console.Clear();

BuildingDescription building3 = new BuildingDescription();
building3.iD = Guid.NewGuid();
Console.WriteLine("Дайте имя новому жилому комплексу");
building3.SetName(Console.ReadLine());
Console.WriteLine("Выберите кол-во этажей в одном доме от 1 до 12");
building3.SetFloors(int.Parse(Console.ReadLine()));
Console.WriteLine("Выберите кол-во подъездов в одном доме от 1 до 10");
building3.SetEnt(int.Parse(Console.ReadLine()));
Console.WriteLine("Выберите кол-во квартир на одном этаже от 1 до 5");
building3.SetApp(int.Parse(Console.ReadLine()));

Console.Clear();

building1.PrintInfo();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

building2.PrintInfo();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

building3.PrintInfo();