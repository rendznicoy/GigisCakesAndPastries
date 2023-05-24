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
        internal List<Cakes> Cake = new List<Cakes>();
        internal List<Pastries> Pastry = new List<Pastries>();
        public List<Products> Masterlist()
        {
            List<Products> Masterlist = new List<Products>();
            Masterlist.AddRange(Cake);
            Masterlist.AddRange(Pastry);

            return Masterlist;
        }
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
        public void addCakes(Cakes cake)
        {
            if (!Cake.Contains(cake))
            {
                Cake.Add(cake);
            }
        }


        public void removeCakes(Cakes cake)
        {
            if (cake.Equals(0))
            {
                Cake.Remove(cake);
            }
        }

        public void addPastries(Pastries pastries)
        {
            if (!Pastry.Contains(pastries))
            {
                Pastry.Add(pastries);
            }
        }

        public void removePastry(Pastries pastries)
        {
            if (pastries.Equals(0))
            {
                Pastry.Remove(pastries);
            }
        }

    }
}
