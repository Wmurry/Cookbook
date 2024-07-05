
// See https://aka.ms/new-console-template for more information
using System.Text.Json;

public class StringsJSONRepository : StringsRepository
{
    protected override string? StringsToText(List<string> strings)
    {
        return JsonSerializer.Serialize(strings);
    }

    protected override List<string> TextToStrings(string fileContents)
    {
        return JsonSerializer.Deserialize<List<string>>(fileContents);
    }
}

