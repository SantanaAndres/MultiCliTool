using CLI_Multi_Tool.Interfaces;
using Spectre.Console;

namespace CLI_Multi_Tool;

public class SearchService(ISearchRepo repo): ISearchService
{
    public string Search()
    {
        try
        {
            var targetFile = AnsiConsole.Prompt(
                new TextPrompt<string>("[green]What's the target file?[/]"));
            var searchPattern = @"c:\";
            
            return repo.Search(targetFile, searchPattern);
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}