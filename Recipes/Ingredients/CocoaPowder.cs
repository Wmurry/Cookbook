using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Recipes.Ingredients
{
    public class CocoaPowder : Ingredient
    {
        public override int Id => 8;
        public override string Name => "Cocoa Powder";
        public override string Instructions => "burn " + base.Instructions;
    }
}
