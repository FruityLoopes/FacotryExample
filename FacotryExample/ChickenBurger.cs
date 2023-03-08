using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotryExample
{
    public class ChickenBurger : IBurger
    {
        public string getBun()
        {
            return "French Bread";
        }

        public string getCondiments()
        {
            return "Mayo";
        }

        public string getPatty()
        {
            return "Chicken";
        }
    }
}
