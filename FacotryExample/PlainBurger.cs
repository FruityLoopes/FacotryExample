using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacotryExample
{
    public class PlainBurger : IBurger
    {
        public string getBun()
        {
            return "Wheat";
        }

        public string getCondiments()
        {
            return "Tomato sauce";
        }

        public string getPatty()
        {
            return "Beef";
        }
    }
}
