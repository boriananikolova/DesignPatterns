using Project.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Helpers
{
    class MenuHelper
    {
        public static int GetOrder()
        {
            int choice;

            do
            {
                Console.Clear();
                Console.WriteLine("Choose a pizza:");
                string[] pizzas = Enum.GetNames(typeof(Pizzas));

                for (int i = 0; i < pizzas.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{pizzas[i]}");
                }
            }
            while (!int.TryParse(Console.ReadLine(), out choice)
                        || !Enum.IsDefined(typeof(Pizzas), choice));

            return choice;
        }
    }
}
