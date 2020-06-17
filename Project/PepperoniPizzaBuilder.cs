using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class PepperoniPizzaBuilder : PizzaBuilder
    {
        private string _name = "Pepperoni Pizza";
        private string _calories = "620";
        public override void buildDough()
        {
            pizza.setDough("pan baked");
        }

        public override void buildSauce()
        {
            pizza.setSauce("hot");
        }

        public override void buildTopping()
        {
            pizza.setTopping("pepperoni+salami");
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
