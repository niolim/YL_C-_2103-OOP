using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class BuildingDescription
    {




        public Guid iD;

        private string name;
        private int floors; // от 1 до 12
        private int appartments; // от 1 до 5
        private int entrances; // от 1 до 10

        public void SetName (string n)
        {
            name = n;
        }

        public void SetFloors (int f)
        {
            if (f <= 0)
            {
                Console.WriteLine("Не верно указано кол-во этажей. Будет установленно минимальное значение - 1");
                floors = 1;
                return;
            }

            if (f > 12)
            {
                Console.WriteLine("Не верно указано кол-во этажей. Будет установленно максимальное значение - 12");
                floors = 12;
                return;
            }

                      
                floors = f; 
                      
        }

        public void SetApp (int a)
        {
            if (a <= 0)
            {
                Console.WriteLine("Не верно указано кол-во квартир на этаже. Будет установленно минимальное значение - 1");
                appartments = 1;
                return;
            }

            if (a > 5)
            {
                Console.WriteLine("Не верно указано кол-во квартир на этаже. Будет установленно максимальное значение - 5");
                appartments = 5;
                return;
            }


            appartments = a;

        }

        public void SetEnt (int e)
        {
            if (e <= 0)
            {
                Console.WriteLine("Не верно указано кол-во подъездов. Будет установленно минимальное значение - 1");
                entrances = 1;
                return;
            }

            if (e > 10)
            {
                Console.WriteLine("Не верно указано кол-во подъездов. Будет установленно максимальное значение - 10");
                entrances = 10;
                return;
            }


            entrances = e;

        }

      
        public void PrintInfo ()
        {
            Console.WriteLine(
                $"Наименование дома - {name} {Environment.NewLine}" +
                $"Регистрационный номер дома - {iD} {Environment.NewLine}" +
                $"Количество этажей в доме - {floors} {Environment.NewLine}" +
                $"Количество подъездов в доме - {entrances} {Environment.NewLine}" +
                $"Количество квартир на одном этаже - {appartments} {Environment.NewLine}");
        }



    }
}
