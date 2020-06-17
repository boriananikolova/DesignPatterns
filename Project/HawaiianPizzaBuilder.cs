using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class HawaiianPizzaBuilder : PizzaBuilder
    {
        private string _name = "Hawaiian Pizza";
        private string _calories = "512";
        public override void buildDough()
        {
            pizza.setDough("cross");
        }

        public override void buildSauce()
        {
            pizza.setSauce("tomato");
        }

        public override void buildTopping()
        {
            pizza.setTopping("ham+pineapple");
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
