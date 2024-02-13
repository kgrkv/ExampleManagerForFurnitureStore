using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExampleManagerForFurnitureStore
{
    public class Furniture
    {
        public int Id { get; set; }
        public string Description { get; private set; }
        public string Position { get; set; }
        public MyDate Date { get; private set; }

        public string Info()
        {
            return $"ID:{Id} | " +
                    $"Месяц: {Date.Month}, День {Date.Day}\n" +
                    $"{Description}\n" +
                    $"Мебель: {Position}";
        }

    }
    public class MyDate
    {
        public int Day { get; private set; }
        public int Month { get; private set; }

        public MyDate(int day, int month)
        {
            if (day > 31 || day <= 0)
                throw new Exception("не корректыный день");
            if (month > 12 || month <= 0)
                throw new Exception("не корректыный месяц");

            Month = month;
            Day = day;
        }
    }

}

