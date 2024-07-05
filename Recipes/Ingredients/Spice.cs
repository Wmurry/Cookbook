using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Recipes.Ingredients
{
    public abstract class Spice : Ingredient
    {
        public override string Instructions => "Take half a teaspoon " +
        base.Instructions;
    }
}
