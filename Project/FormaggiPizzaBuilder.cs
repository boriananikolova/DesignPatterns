using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class FormaggiPizzaBuilder : PizzaBuilder
    {
        private string _name = "Formaggi Pizza";
        private string _calories = "732";
        public override void buildDough()
        {
            pizza.setDough("mozzarella crust");
        }

        public override void buildSauce()
        {
            pizza.setSauce("cream");
        }

        public override void buildTopping()
        {
            pizza.setTopping("feta+cheddar+bluecheese");
        }

        public string getPizzaName()
        {
            return _name;
        }

        public string getPizzaCalories()
        {
            return _calories;
        }
    }
}
