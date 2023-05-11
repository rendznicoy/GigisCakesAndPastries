using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Ingredients
    {
        public string Name { get; private set; }
        public int Count { get; set; }
        public string Unit { get; private set; }
        
        public Ingredients(string name, int count, string unit) 
        {
            this.Name = name;
            this.Count = count;
            this.Unit = unit;
        }
    }
}
