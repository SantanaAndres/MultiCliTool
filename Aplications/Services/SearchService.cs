using Domain.Interfaces.Repository;
using Domain.Interfaces.Services;
using Spectre.Console;

namespace Aplication.Services;

public class SearchService(ISearchRepo repo): ISearchService
{
    public void Search()
    {
        try
        {
            var targetFile = AnsiConsole.Prompt(
                new TextPrompt<string>("[green]What's the target file?[/]"));
            var searchPattern = @"c:\";
            
            repo.Search(targetFile, searchPattern);
        }
        catch (Exception e)
        {
        }
    }
}