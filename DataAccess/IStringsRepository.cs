// See https://aka.ms/new-console-template for more information
public interface IStringsRepository
{ 
    List<string> Read(string filePath);
    void Write(string filePath, List<string> strings);
}

