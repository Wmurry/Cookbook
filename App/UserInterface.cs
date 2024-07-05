// See https://aka.ms/new-console-template for more information
using Cookbook.Recipe;
using Cookbook.Recipes.Ingredients;

internal interface IUserInterface
{
    void Show_Message(string message);

    public void Exit();

    void Printrecipes(IEnumerable<Recipe> allRecipes);
    void prompt_to_create_recipe();
    IEnumerable<Ingredient> read_ingreidents();
    string create_a_name_for_recipe();
    bool prompt_to_continue();
}
