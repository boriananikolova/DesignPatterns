using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class ConcreteCommand : Command
    {
        // Constructor

        public ConcreteCommand(PizzaMaker pizzaMaker) :
          base(pizzaMaker)
        {
        }

        public override void Execute(int pizza)
        {
            pizzaMaker.Action(pizza);
        }
    }
}
