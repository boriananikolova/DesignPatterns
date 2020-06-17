using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    abstract class Command
    {
        protected PizzaMaker pizzaMaker;

        // Constructor

        public Command(PizzaMaker pizzaMaker)
        {
            this.pizzaMaker = pizzaMaker;
        }

        public abstract void Execute(int type);
    }
}
