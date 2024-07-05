﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookbook.Recipes.Ingredients
{
    public class Chocolate : Ingredient
    {
        public override int Id => 4;
        public override string Name => "Chocolate";
        public override string Instructions => "Melt in water bath " +
            base.Instructions;
    }
}
