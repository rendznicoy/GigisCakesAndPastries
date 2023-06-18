using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Ingredients
    {
        public string IngredientID { get; private set; }
        public string Name { get; private set; }
        public string Variant { get; private set; }
        public int Quantity { get; set; }
        public string Unit { get; private set; }
        
        public Ingredients(string ingredientID, string name, string variant, int quantity, string unit) 
        {
            this.IngredientID = ingredientID;
            this.Name = name;
            this.Variant = variant;
            this.Quantity = quantity;
            this.Unit = unit;
        }
    }
}
