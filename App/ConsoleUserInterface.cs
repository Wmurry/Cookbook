// See https://aka.ms/new-console-template for more information
using Cookbook.Recipe;
using Cookbook.Recipes.Ingredients;

internal class ConsoleUserInterface : IUserInterface
{
    private readonly IIngredientsRegister ingredientsRegister;

    public ConsoleUserInterface(IIngredientsRegister ir)
    { 
        ir = ingredientsRegister = ir;
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close");
        Console.ReadKey();
    }

    public void Show_Message(string message)
    {
        Console.WriteLine(message);
    }

    public void Printrecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are:" + Environment.NewLine);

            foreach (Recipe recipe in allRecipes)
            {
                Console.WriteLine(recipe.ToString());
                Console.WriteLine();
            }
        }
    }

    public void prompt_to_create_recipe()
    {
        Console.WriteLine("Create a new cookie recipe! "+"Available ingredients are:");

        foreach (var ingredient in ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }

    public IEnumerable<Ingredient> read_ingreidents()
    {
        bool shallStop = false;
        var ingredients = new List<Ingredient>();

        while (!shallStop)
        {
            Console.WriteLine("Add an ingredient by its ID,"+
                "or type anything else if finished.");

            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int id))
            {
                var selectedIngredient = ingredientsRegister.GetById(id);
                if (selectedIngredient != null)
                { 
                    ingredients.Add(selectedIngredient);
                }   
            }
            else
            {
                shallStop = true;
            }
            //?
        }

        return ingredients; 
    }

    public string create_a_name_for_recipe()
    {
        Console.WriteLine("Create a name for this recipe");

        var userInput = Console.ReadLine();

        return userInput;
    }

    public bool prompt_to_continue()
    {
        Show_Message("Do you want to make another recipe \n" +
            "Press Y to make another recipe any other key to exit");
        var input = Console.ReadLine();
        if ((input == "Y") || (input == "y"))
        { 
            return true;
        }
        return false;
    }
}
