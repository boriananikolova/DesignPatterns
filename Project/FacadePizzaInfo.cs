using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class FacadePizzaInfo
    {
        static readonly HawaiianPizzaBuilder _hawaiianPizza = new HawaiianPizzaBuilder();
        static readonly FormaggiPizzaBuilder _formaggiPizza = new FormaggiPizzaBuilder();
        static readonly PepperoniPizzaBuilder _pepperoniPizza = new PepperoniPizzaBuilder();

        public static string GetHawaiianPizzaInfo()
        {
            string info = _hawaiianPizza.getPizzaName().ToString() + " - " + _hawaiianPizza.getPizzaCalories().ToString().ToString() + " calories";
            return info;
        }

        public static string GetFormagiPizzaInfo()
        {
            string info = _formaggiPizza.getPizzaName().ToString() + " - " + _formaggiPizza.getPizzaCalories().ToString().ToString() + " calories";
            return info;
        }

        public static string GetPepperoniPizzaInfo()
        {
            string info = _pepperoniPizza.getPizzaName().ToString() + " - " + _pepperoniPizza.getPizzaCalories().ToString().ToString() + " calories";
            return info;
        }
    }
}
