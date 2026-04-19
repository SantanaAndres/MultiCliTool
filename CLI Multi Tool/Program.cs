using CLI_Multi_Tool;
using CLI_Multi_Tool.Interfaces;
using CLI_Multi_Tool.Repository;
using Spectre.Console;


AnsiConsole.MarkupLine("[rgb(0,255,0)]Welcome to CLI Multi Tool!!!!!!!!!!!!!![/]");


ISearchRepo searchRepo = new SearchRepo();
IPasswordGeneratorRepo passwordGeneratorRepo = new PasswordGeneratorRepo();

ISearchService searchService = new SearchService(searchRepo);



AnsiConsole.MarkupLine("[green]✓ Build completed successfully[/]");

// Console.WriteLine(searchService.Search());
Console.WriteLine(passwordGeneratorRepo.GeneratePassword());