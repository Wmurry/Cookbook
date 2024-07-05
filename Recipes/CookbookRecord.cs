
// See https://aka.ms/new-console-template for more information
using Cookbook.Recipe;
using Cookbook.Recipes.Ingredients;
using System.Runtime.CompilerServices;

internal class CookbookRecord : ICookbookRecord
{
    private readonly IStringsRepository _stringsrepository;
    private readonly IIngredientsRegister _ingredientsRegister;
    private const string Seperator = ",";

    public CookbookRecord(IStringsRepository stringsRepository,
    IIngredientsRegister ingredientsRegister)
    {
        _stringsrepository = stringsRepository;
        _ingredientsRegister = ingredientsRegister;
    }

    public List<Recipe> ReadRecord(string filepath)
    {
        List<string> records = _stringsrepository.Read(filepath);
        var recipes = new List<Recipe>();

        foreach (var recipeFromFile in records)
        {
            var recipe = RecipeFromString(recipeFromFile);
            recipes.Add(recipe);
        }
        return recipes;
    }

    private Recipe RecipeFromString(string recipeFromFile)
    {
        var textualIds = recipeFromFile.Split(Seperator);
        var ingredients = new List<Ingredient>();
        int count = 0;
        string name = "";
        foreach (var textualId in textualIds)
        { 
            if(count == 0) { name = textualId; }
            else 
            { 
                var id = int.Parse(textualId);
                var ingredient = _ingredientsRegister.GetById(id);
                ingredients.Add(ingredient);    
            }
            count++;
        }
        return new Recipe(ingredients,name);
    }

    public void WriteRecord(string filepath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = new List<string>();
        foreach (var recipe in allRecipes) 
        {
            var allIds = new List<int>();
            foreach (var ingredient in recipe.Ingredients)
            { 
                allIds.Add(ingredient.Id);
            }
            recipesAsStrings.Add($"{recipe.Name}," + string.Join(",", allIds));
        }
        _stringsrepository.Write(filepath, recipesAsStrings);
    }
}

