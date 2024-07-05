// See https://aka.ms/new-console-template for more information

public static class FileFormatExtensions
{
    public static string AsFileExtension(this FileFormat fileFormat) =>
        fileFormat == FileFormat.Json ? "json" : "txt";
}
