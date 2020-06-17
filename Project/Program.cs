using Project.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int pizza = MenuHelper.GetOrder();

            // Create receiver, command, and invoker

            PizzaMaker pizzaMaker = new PizzaMaker();
            Command command = new ConcreteCommand(pizzaMaker);
            Waiter invoker = new Waiter();

            // Set and execute command

            invoker.SetCommand(command);
            invoker.ExecuteCommand(pizza);
        }
    }
}
