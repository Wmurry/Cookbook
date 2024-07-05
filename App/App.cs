// See https://aka.ms/new-console-template for more information


using Cookbook.Recipe;

internal class App
{
    private readonly ICookbookRecord cr;
    private readonly IUserInterface ui;

    public App(IUserInterface _userInterface,
        ICookbookRecord _cookbookRecord)
    {
        ui = _userInterface;
        cr = _cookbookRecord;   
    }
    
    public void Run(string filename)
    {
        var allRecipes = cr.ReadRecord(filename);
        ui.Printrecipes(allRecipes);
        ui.prompt_to_create_recipe();
        
        bool @continue = false;
        do
        {
            var useringredients = ui.read_ingreidents();
            if (useringredients.Count() >= 0)
            {
                var recipe = new Recipe(useringredients, ui.create_a_name_for_recipe());
                allRecipes.Add(recipe);
                cr.WriteRecord(filename, allRecipes);
                @continue = ui.prompt_to_continue();
            }
            else
            {
                ui.Show_Message("There are no ingredients no recipes " +
                    "will be saved");
            }
        } while (@continue == true);
        ui.Exit();
    }
}
