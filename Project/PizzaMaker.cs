using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class PizzaMaker
    {
        public void Action(int pizza)
        {
            Director director = new Director();
            string pizzaInfo;

            switch (pizza)
            {
                case 1:
                    PizzaBuilder hawaiianPizzabuilder = new HawaiianPizzaBuilder();
                    director.setPizzaBuilder(hawaiianPizzabuilder);
                    director.constructPizza();
                    pizzaInfo = FacadePizzaInfo.GetHawaiianPizzaInfo();
                    break;
                case 2:
                    PizzaBuilder formaggiPizzaBuilder = new FormaggiPizzaBuilder();
                    director.setPizzaBuilder(formaggiPizzaBuilder);
                    director.constructPizza();
                    pizzaInfo = FacadePizzaInfo.GetFormagiPizzaInfo();
                    break;
                case 3:
                    PizzaBuilder pepperoniPizzaBuilder = new PepperoniPizzaBuilder();
                    director.setPizzaBuilder(pepperoniPizzaBuilder);
                    director.constructPizza();
                    pizzaInfo = FacadePizzaInfo.GetPepperoniPizzaInfo();
                    break;
                default:
                    PizzaBuilder defHawaiianPizzabuilder = new HawaiianPizzaBuilder();
                    director.setPizzaBuilder(defHawaiianPizzabuilder);
                    director.constructPizza();
                    pizzaInfo = FacadePizzaInfo.GetHawaiianPizzaInfo();
                    break;
            }

            Console.WriteLine("Your pizza is ready");
            Console.WriteLine(pizzaInfo);
        }
    }
}
