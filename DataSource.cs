using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCAD16_Assignment3_4wpf
{
    internal class DataSource
    {
        public static List<Coffee> Coffees;

        public static void CreateData()

        {
            Coffees = new List<Coffee>()
            {
                new Coffee() { DrinkId = 1, SizeInOunces = 16, DrinkType = "Drip", Temp = Temp.hot, DrinkSweetener = "Sugar", DrinkAdd = "Cream" },
                new Coffee() { DrinkId = 2, SizeInOunces = 8, DrinkType = "Cappuccino", Temp = Temp.hot, DrinkSweetener = "None", DrinkAdd = "None" },
                new Coffee() { DrinkId = 3, SizeInOunces = 16, DrinkType = "Cold Brew", Temp = Temp.cold, DrinkSweetener = "None", DrinkAdd = "None" },
                new Coffee() { DrinkId = 4, SizeInOunces = 20, DrinkType = "Macchiato", Temp = Temp.iced, DrinkSweetener = "Caramel", DrinkAdd = "Milk"}
            };
        }
    }
}
