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
        public string Name { get; set; }
        public string Variant { get; set; }
        public string Type { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        
        public Ingredients(string ingredientID, string name, string variant, string type, double quantity, string unit) 
        {
            this.IngredientID = ingredientID;
            this.Name = name;
            this.Variant = variant;
            this.Type = type;
            this.Quantity = quantity;
            this.Unit = unit;
        }
    }
}
