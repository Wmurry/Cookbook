// See https://aka.ms/new-console-template for more information
using Cookbook.Recipes.Ingredients;

internal interface IIngredientsRegister
{
    IEnumerable<Ingredient> All { get; }

    Ingredient GetById(int id);
}
