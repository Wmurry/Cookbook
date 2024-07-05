
// See https://aka.ms/new-console-template for more information
using Cookbook.Recipe;

internal interface ICookbookRecord
{
    public List<Recipe> ReadRecord (string filepath);
    void WriteRecord(string filepath, List<Recipe> allRecipes);
}
