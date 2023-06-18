using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigisCakesAndPastries
{
    public class Inventory
    {
        public string Name { get; private set; }
        internal List<Ingredients> Ingredient = new List<Ingredients>();
        internal List<Products> Products = new List<Products>();
        public Inventory(string name)
        {
            this.Name = name;
            this.Ingredient = new List<Ingredients>();
        }

        public void addIngredient(Ingredients ingredient)
        {
            Ingredient.Add(ingredient);
        }

        public int ingredientCtr(Ingredients ingredient)
        {
            return ingredient.Count;
        }

        public void addCount(Ingredients ingredient, int num)
        {
            if (ingredient == null || num < 0)
                return;
            ingredient.Count += num;
        }

        public void removeCount(Ingredients ingredient, int num)
        {
            if (ingredient == null || num > ingredient.Count || num  < 0)
                return;
            ingredient.Count -= num;
        }
        public void removeIngredient(Ingredients ingredients)
        {
            if(ingredients == null)
                return;
            Ingredient.Remove(ingredients);
        }
        public void addProduct(Products product)
        {
            if (!Products.Contains(product))
            {
                Products.Add(product);
            }
        }


        public void removeCakes(Products product)
        {
            if (product.Equals(0))
            {
                Products.Remove(product);
            }
        }
    }
}
