using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cookbook.Recipes.Ingredients;

namespace Cookbook.Recipe
{
    internal class Recipe
    {
        public string Name { get; set; }
        public IEnumerable<Ingredient> Ingredients { get;}

        public Recipe(IEnumerable<Ingredient> ingredients,string name)
        {
            Name = name;
            Ingredients = ingredients;
        }

        public override string ToString()
        { 
            var steps = new List<string>(); 
            steps.Add(Name);
            foreach(var ingredient in Ingredients)
            { 
                steps.Add($"{ingredient.Name}: {ingredient.Instructions}");
            }
            return string.Join(Environment.NewLine, steps);        
        }
    }
}
