// See https://aka.ms/new-console-template for more information

IngredientsRegister ir = new IngredientsRegister();

const FileFormat Format = FileFormat.Json;

const string FileName = "recipes";
var fileMetadata = new FileMetaData(FileName, Format);

IStringsRepository StringsRepository = Format == FileFormat.Json ? 
    new StringsJSONRepository() : 
    new StringsTextRepository();

App app = new App(new ConsoleUserInterface(new IngredientsRegister()),
    new CookbookRecord(StringsRepository,
    ir));

app.Run(fileMetadata.ToPath());
