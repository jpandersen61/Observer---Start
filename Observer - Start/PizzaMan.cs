using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class PizzaMan : IObserver
    {
        public IPizzaFactory PizzaFactory { get; set; }
        public PizzaOven PizzaOven { get; set; }
       
      
        public PizzaMan(PizzaOven pizzaOven)
        {
            /*
                 We need a PizzaFactory together with the PizzaOven.
                 PizzaMan should also be able to observe the PizzaOven
            */

        }

        public void TakeOrder(String[] additionals)
        {
            /*
                 Make use of a PizzaFactory and a PizzaOven
            */

            
        }
        public void Notify(AbstractPizza pizza)
        {
            /*
                 Let PizzaMan announce that the pizza is ready.
                 Specific information including price should be 
                 announced
            */

            
        }
    }
}
